using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormPortofoliuDB : Form
    {
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ActiuniDB;Integrated Security=True";
        DataSet DSPortofolii = new DataSet();
        string selectCommand = "SELECT * FROM dbo.Portofoliu";

        public FormPortofoliuDB()
        {
            InitializeComponent();
            this.Load += FormPortofoliuDB_Load;
            adaugaBTN.Click += adaugaBTN_Click;
            salvareBTN.Click += salvareBTN_Click;
            stergeBTN.Click += stergeBTN_Click;
            updateBTN.Click += updateBTN_Click;
        }

        private void FormPortofoliuDB_Load(object sender, EventArgs e)
        {
            IncarcaDate();

            dataGridViewPortofolii.DataSource = DSPortofolii.Tables["Portofoliu"];
            dataGridViewPortofolii.ReadOnly = false;
            dataGridViewPortofolii.AllowUserToAddRows = false;

            tbDenumire.DataBindings.Clear();
            tbDescriere.DataBindings.Clear();
            dtpDataCreare.DataBindings.Clear();

            tbDenumire.DataBindings.Add("Text", DSPortofolii.Tables["Portofoliu"], "Denumire", true, DataSourceUpdateMode.OnPropertyChanged);
            tbDescriere.DataBindings.Add("Text", DSPortofolii.Tables["Portofoliu"], "Descriere", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpDataCreare.DataBindings.Add("Value", DSPortofolii.Tables["Portofoliu"], "DataCreare", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);
            DSPortofolii.Clear();
            adaptor.Fill(DSPortofolii, "Portofoliu");

            var dt = DSPortofolii.Tables["Portofoliu"];
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
                DataRow randNou = DSPortofolii.Tables["Portofoliu"].NewRow();
                randNou["Denumire"] = tbDenumire.Text;
                randNou["Descriere"] = tbDescriere.Text;
                randNou["DataCreare"] = dtpDataCreare.Value;
                DSPortofolii.Tables["Portofoliu"].Rows.Add(randNou);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare: " + ex.Message);
            }
        }

        private void stergeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPortofolii.CurrentRow != null && dataGridViewPortofolii.CurrentRow.Index >= 0)
                {
                    DataRowView rowView = dataGridViewPortofolii.CurrentRow.DataBoundItem as DataRowView;
                    if (rowView != null)
                    {
                        rowView.Row.Delete();
                        MessageBox.Show("Portofoliul a fost marcat pentru ștergere. Apasă 'Salvare' pentru a confirma.");
                    }
                }
                else
                {
                    MessageBox.Show("Selectează un rând pentru a-l șterge!");
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
                BindingContext[DSPortofolii.Tables["Portofoliu"]].EndCurrentEdit();

                using (SqlConnection conexiune = new SqlConnection(stringConexiune))
                {
                    SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);

                    adaptor.InsertCommand = new SqlCommand(
                        "INSERT INTO dbo.Portofoliu (Denumire, Descriere, DataCreare) VALUES (@Denumire, @Descriere, @DataCreare)", conexiune);
                    adaptor.InsertCommand.Parameters.Add("@Denumire", SqlDbType.NVarChar, 100, "Denumire");
                    adaptor.InsertCommand.Parameters.Add("@Descriere", SqlDbType.NVarChar, 500, "Descriere");
                    adaptor.InsertCommand.Parameters.Add("@DataCreare", SqlDbType.DateTime, 0, "DataCreare");

                    adaptor.UpdateCommand = new SqlCommand(
                        "UPDATE dbo.Portofoliu SET Denumire=@Denumire, Descriere=@Descriere, DataCreare=@DataCreare WHERE Id=@Id", conexiune);
                    adaptor.UpdateCommand.Parameters.Add("@Denumire", SqlDbType.NVarChar, 100, "Denumire");
                    adaptor.UpdateCommand.Parameters.Add("@Descriere", SqlDbType.NVarChar, 500, "Descriere");
                    adaptor.UpdateCommand.Parameters.Add("@DataCreare", SqlDbType.DateTime, 0, "DataCreare");
                    adaptor.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                    adaptor.DeleteCommand = new SqlCommand(
                        "DELETE FROM dbo.Portofoliu WHERE Id=@Id", conexiune);
                    adaptor.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                    int nr = adaptor.Update(DSPortofolii.Tables["Portofoliu"]);
                    MessageBox.Show($"Au fost actualizate {nr} linii.");
                    DSPortofolii.Tables["Portofoliu"].AcceptChanges();
                }

                DSPortofolii.Tables["Portofoliu"].Clear();
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
                BindingContext[DSPortofolii.Tables["Portofoliu"]].EndCurrentEdit();

                using (SqlConnection conexiune = new SqlConnection(stringConexiune))
                {
                    SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);

                    adaptor.InsertCommand = new SqlCommand(
                                 "INSERT INTO dbo.Portofoliu (Denumire, Descriere, DataCreare) VALUES (@Denumire, @Descriere, @DataCreare)", conexiune);
                    adaptor.InsertCommand.Parameters.Add("@Denumire", SqlDbType.NVarChar, 100, "Denumire");
                    adaptor.InsertCommand.Parameters.Add("@Descriere", SqlDbType.NVarChar, 500, "Descriere");
                    adaptor.InsertCommand.Parameters.Add("@DataCreare", SqlDbType.DateTime, 0, "DataCreare");

                    adaptor.UpdateCommand = new SqlCommand(
                        "UPDATE dbo.Portofoliu SET Denumire=@Denumire, Descriere=@Descriere, DataCreare=@DataCreare WHERE Id=@Id", conexiune);
                    adaptor.UpdateCommand.Parameters.Add("@Denumire", SqlDbType.NVarChar, 100, "Denumire");
                    adaptor.UpdateCommand.Parameters.Add("@Descriere", SqlDbType.NVarChar, 500, "Descriere");
                    adaptor.UpdateCommand.Parameters.Add("@DataCreare", SqlDbType.DateTime, 0, "DataCreare");
                    adaptor.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                    adaptor.DeleteCommand = new SqlCommand(
                        "DELETE FROM dbo.Portofoliu WHERE Id=@Id", conexiune);
                    adaptor.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");

                    int nr = adaptor.Update(DSPortofolii.Tables["Portofoliu"]);
                    MessageBox.Show($"Salvat {nr} modificări cu succes!");
                    DSPortofolii.Tables["Portofoliu"].AcceptChanges();
                }

                DSPortofolii.Tables["Portofoliu"].Clear();
                IncarcaDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }
    }
}
