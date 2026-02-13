using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormActiune: Form
    {
        public Actiune actiuneLocala;
        public FormActiune(Actiune actiune)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += FormActiune_KeyDown;
            if (actiune != null)
            {
                tbSimbol.Text = actiune.simbol;
                tbDenumire.Text = actiune.denumire;
                cmbSector.Text = actiune.sector;
                txtBoxNumericPret.Text = actiune.pretCurent;
                txtBoxNumericNr.Text = actiune.numarActiuni;
                dtpDataActualizare.Value = actiune.dataActualizare;
                this.Text = "Editeaza actiunea";
                adaugaBTN.Text = "Editeaza actiunea";
            }
            else
            {
                actiune = new Actiune(0,"", "", "", "", "", DateTime.Now);
            }
            actiuneLocala = actiune;
        }

        private void adaugaBTN_Click(object sender, EventArgs e)
        {
            actiuneLocala.simbol = tbSimbol.Text;
            actiuneLocala.denumire = tbDenumire.Text;
            actiuneLocala.sector = cmbSector.Text;
            actiuneLocala.pretCurent = txtBoxNumericPret.Text;
            actiuneLocala.numarActiuni = txtBoxNumericNr.Text;
            actiuneLocala.dataActualizare = dtpDataActualizare.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void renuntaBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbDenumire_Validating(object sender, CancelEventArgs e)
        {
            if (tbDenumire.Text.Length < 2)
            {
                errorProvider1.SetError(tbDenumire, "Introduceti o denumire valida!");
                e.Cancel = true;
            }
        }

        private void tbDenumire_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbDenumire, "");
        }

        private void FormActiune_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                adaugaBTN.PerformClick(); 
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                renuntaBTN.PerformClick(); 
                e.Handled = true;
            }
        }
    }
}
