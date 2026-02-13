using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormActiuniDB : Form
    {
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ActiuniDB;Integrated Security=True";
        DataSet DSActiuni = new DataSet();
        string selectCommand = "SELECT * FROM dbo.Actiuni";
        private bool justAdded = false;

        public FormActiuniDB()
        {
            InitializeComponent();
            this.Load += FormActiuniDB_Load;
            adaugaBTN.Click += adaugaBTN_Click;
            stergeBTN.Click += stergeBTN_Click;
            updateBTN.Click += updateBTN_Click;
            salvareBTN.Click += salvareBTN_Click;
        }

        private void FormActiuniDB_Load(object sender, EventArgs e)
        {
            IncarcaDate();
            dataGridViewActiuni.DataSource = DSActiuni.Tables["Actiuni"];
            dataGridViewActiuni.AllowUserToAddRows = false;
            ResetFields();
        }

        void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);
            DSActiuni.Clear();
            adaptor.Fill(DSActiuni, "Actiuni");
            var dt = DSActiuni.Tables["Actiuni"];
            if (dt.PrimaryKey.Length == 0)
                dt.PrimaryKey = new DataColumn[] { dt.Columns["Id"] };
            if (!dt.Columns["Id"].AutoIncrement)
            {
                dt.Columns["Id"].AutoIncrement = true;
                dt.Columns["Id"].AutoIncrementSeed = -1;
                dt.Columns["Id"].AutoIncrementStep = -1;
                dt.Columns["Id"].ReadOnly = false;
            }
        }

        private void adaugaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (justAdded)
                    return;

                if (string.IsNullOrWhiteSpace(tbSimbol.Text) ||
                    string.IsNullOrWhiteSpace(tbDenumire.Text) ||
                    cmbSector.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(tbPretCurent.Text) ||
                    string.IsNullOrWhiteSpace(tbNumarActiuni.Text))
                {
                    MessageBox.Show("Completează toate câmpurile!");
                    return;
                }

                decimal pretCurent;
                int numarActiuni;
                if (!decimal.TryParse(tbPretCurent.Text.Replace(',', '.'),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture,
                        out pretCurent))
                {
                    MessageBox.Show("Prețul trebuie să fie un număr valid (ex: 120.5 sau 120,5)!");
                    return;
                }
                if (!int.TryParse(tbNumarActiuni.Text, out numarActiuni))
                {
                    MessageBox.Show("Numărul de acțiuni trebuie să fie un număr întreg!");
                    return;
                }

                DataRow randNou = DSActiuni.Tables["Actiuni"].NewRow();
                randNou["Simbol"] = tbSimbol.Text;
                randNou["Denumire"] = tbDenumire.Text;
                randNou["Sector"] = cmbSector.Text;
                randNou["PretCurent"] = pretCurent;
                randNou["NumarActiuni"] = numarActiuni;
                randNou["DataActualizare"] = dtpDataActualizare.Value;
                DSActiuni.Tables["Actiuni"].Rows.Add(randNou);

                justAdded = true; 
                ResetFields();
                justAdded = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare: " + ex.Message);
            }
        }

        private void ResetFields()
        {
            tbSimbol.Text = "";
            tbDenumire.Text = "";
            cmbSector.SelectedIndex = -1;
            tbPretCurent.Text = "";
            tbNumarActiuni.Text = "";
            dtpDataActualizare.Value = DateTime.Now;
        }

        private void stergeBTN_Click(object sender, EventArgs e)
        {
            try
            {
 
                if (dataGridViewActiuni.CurrentRow != null && !dataGridViewActiuni.CurrentRow.IsNewRow)
                {
                    DataRowView rowView = dataGridViewActiuni.CurrentRow.DataBoundItem as DataRowView;
                    if (rowView != null)
                    {
                        var confirmare = MessageBox.Show(
                            "Sigur vrei să ștergi această acțiune?\nSchimbarea va fi aplicată după 'Salvează'.",
                            "Confirmare ștergere",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirmare == DialogResult.Yes)
                        {
                            rowView.Row.Delete();
                            MessageBox.Show("Acțiunea a fost marcată pentru ștergere. Apasă 'Salvează' pentru a confirma.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selectează un singur rând pentru ștergere!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergere: " + ex.Message);
            }
        }


        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                BindingContext[DSActiuni.Tables["Actiuni"]].EndCurrentEdit();

                using (SqlConnection conexiune = new SqlConnection(stringConexiune))
                {
                    SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);

                    adaptor.InsertCommand = new SqlCommand(
                        "INSERT INTO dbo.Actiuni (Simbol, Denumire, Sector, PretCurent, NumarActiuni, DataActualizare) VALUES (@Simbol, @Denumire, @Sector, @PretCurent, @NumarActiuni, @DataActualizare)", conexiune);
                    adaptor.InsertCommand.Parameters.Add("@Simbol", SqlDbType.NVarChar, 10, "Simbol");
                    adaptor.InsertCommand.Parameters.Add("@Denumire", SqlDbType.NVarChar, 50, "Denumire");
                    adaptor.InsertCommand.Parameters.Add("@Sector", SqlDbType.NVarChar, 50, "Sector");
                    adaptor.InsertCommand.Parameters.Add("@PretCurent", SqlDbType.Decimal, 0, "PretCurent");
                    adaptor.InsertCommand.Parameters.Add("@NumarActiuni", SqlDbType.Int, 0, "NumarActiuni");
                    adaptor.InsertCommand.Parameters.Add("@DataActualizare", SqlDbType.DateTime, 0, "DataActualizare");

                    adaptor.UpdateCommand = new SqlCommand(
                        "UPDATE dbo.Actiuni SET Simbol=@Simbol, Denumire=@Denumire, Sector=@Sector, PretCurent=@PretCurent, NumarActiuni=@NumarActiuni, DataActualizare=@DataActualizare WHERE Id=@Id", conexiune);
                    adaptor.UpdateCommand.Parameters.Add("@Simbol", SqlDbType.NVarChar, 10, "Simbol");
                    adaptor.UpdateCommand.Parameters.Add("@Denumire", SqlDbType.NVarChar, 50, "Denumire");
                    adaptor.UpdateCommand.Parameters.Add("@Sector", SqlDbType.NVarChar, 50, "Sector");
                    adaptor.UpdateCommand.Parameters.Add("@PretCurent", SqlDbType.Decimal, 0, "PretCurent");
                    adaptor.UpdateCommand.Parameters.Add("@NumarActiuni", SqlDbType.Int, 0, "NumarActiuni");
                    adaptor.UpdateCommand.Parameters.Add("@DataActualizare", SqlDbType.DateTime, 0, "DataActualizare");
                    adaptor.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                    adaptor.DeleteCommand = new SqlCommand(
                        "DELETE FROM dbo.Actiuni WHERE Id=@Id", conexiune);
                    adaptor.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                    int nr = adaptor.Update(DSActiuni.Tables["Actiuni"]);
                    MessageBox.Show($"Au fost actualizate {nr} linii.");
                    DSActiuni.Tables["Actiuni"].AcceptChanges();
                }

                DSActiuni.Tables["Actiuni"].Clear();
                IncarcaDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la update: " + ex.Message);
            }
        }

        private void salvareBTN_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                BindingContext[DSActiuni.Tables["Actiuni"]].EndCurrentEdit();

                using (SqlConnection conexiune = new SqlConnection(stringConexiune))
                {
                    SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);

                    adaptor.InsertCommand = new SqlCommand(
                        "INSERT INTO dbo.Actiuni (Simbol, Denumire, Sector, PretCurent, NumarActiuni, DataActualizare) VALUES (@Simbol, @Denumire, @Sector, @PretCurent, @NumarActiuni, @DataActualizare)", conexiune);
                    adaptor.InsertCommand.Parameters.Add("@Simbol", SqlDbType.NVarChar, 10, "Simbol");
                    adaptor.InsertCommand.Parameters.Add("@Denumire", SqlDbType.NVarChar, 50, "Denumire");
                    adaptor.InsertCommand.Parameters.Add("@Sector", SqlDbType.NVarChar, 50, "Sector");
                    adaptor.InsertCommand.Parameters.Add("@PretCurent", SqlDbType.Decimal, 0, "PretCurent");
                    adaptor.InsertCommand.Parameters.Add("@NumarActiuni", SqlDbType.Int, 0, "NumarActiuni");
                    adaptor.InsertCommand.Parameters.Add("@DataActualizare", SqlDbType.DateTime, 0, "DataActualizare");

                    adaptor.UpdateCommand = new SqlCommand(
                        "UPDATE dbo.Actiuni SET Simbol=@Simbol, Denumire=@Denumire, Sector=@Sector, PretCurent=@PretCurent, NumarActiuni=@NumarActiuni, DataActualizare=@DataActualizare WHERE Id=@Id", conexiune);
                    adaptor.UpdateCommand.Parameters.Add("@Simbol", SqlDbType.NVarChar, 10, "Simbol");
                    adaptor.UpdateCommand.Parameters.Add("@Denumire", SqlDbType.NVarChar, 50, "Denumire");
                    adaptor.UpdateCommand.Parameters.Add("@Sector", SqlDbType.NVarChar, 50, "Sector");
                    adaptor.UpdateCommand.Parameters.Add("@PretCurent", SqlDbType.Decimal, 0, "PretCurent");
                    adaptor.UpdateCommand.Parameters.Add("@NumarActiuni", SqlDbType.Int, 0, "NumarActiuni");
                    adaptor.UpdateCommand.Parameters.Add("@DataActualizare", SqlDbType.DateTime, 0, "DataActualizare");
                    adaptor.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                    adaptor.DeleteCommand = new SqlCommand(
                        "DELETE FROM dbo.Actiuni WHERE Id=@Id", conexiune);
                    adaptor.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                    adaptor.Update(DSActiuni.Tables["Actiuni"]);
                    DSActiuni.Tables["Actiuni"].AcceptChanges();
                }

                DSActiuni.Tables["Actiuni"].Clear();
                IncarcaDate();
                MessageBox.Show("Salvare cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }
    }
}
