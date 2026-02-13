using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proiect_PAW
{
    public partial class FormPortofoliu : Form
    {
        public Portofoliu portofoliuLocal;
         public FormPortofoliu(Portofoliu portofoliu)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += FormPortofoliu_KeyDown;

            if (portofoliu != null)
            {
                tbDenumire.Text = portofoliu.denumire;
                tbDescriere.Text = portofoliu.descriere;
                dtpDataCreare.Value = portofoliu.dataCreare;
                this.Text = "Editează portofoliul";
                adaugaBTN.Text = "Editează portofoliul";
            }
            else
            {
                portofoliu = new Portofoliu("", "");
                dtpDataCreare.Value = DateTime.Now;
            }
            portofoliuLocal = portofoliu;
        }

        private void adaugaBTN_Click_1(object sender, EventArgs e)
        {
            portofoliuLocal.denumire = tbDenumire.Text;
            portofoliuLocal.descriere = tbDescriere.Text;
            portofoliuLocal.dataCreare = dtpDataCreare.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void renuntaBTN_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbDenumire_Validating_1(object sender, CancelEventArgs e)
        {
            if (tbDenumire.Text.Length < 2)
            {
                errorProvider1.SetError(tbDenumire, "Introduceți o denumire validă!");
                e.Cancel = true;
            }
        }

        private void tbDenumire_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbDenumire, "");
        }

        private void FormPortofoliu_KeyDown(object sender, KeyEventArgs e)
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