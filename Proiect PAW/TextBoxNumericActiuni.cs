using System;
using System.Linq;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class TextBoxNumericActiuni : UserControl
    {
        public TextBoxNumericActiuni()
        {
            InitializeComponent();
            textBox1.KeyPress += textBox1_KeyPress;
        }

        public float Valoare
        {
            get
            {
                float v = 0;
                float.TryParse(textBox1.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out v);
                return v;
            }
            set
            {
                textBox1.Text = value.ToString();
            }
        }

        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
                e.Handled = true;

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (textBox1.Text.Contains('.') || textBox1.Text.Contains(',')))
                e.Handled = true;
        }
    }
}
