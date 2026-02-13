namespace Proiect_PAW
{
    partial class FormActiune
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSimbol = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.dtpDataActualizare = new System.Windows.Forms.DateTimePicker();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.adaugaBTN = new System.Windows.Forms.Button();
            this.renuntaBTN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBoxNumericNr = new Proiect_PAW.TextBoxNumericActiuni();
            this.txtBoxNumericPret = new Proiect_PAW.TextBoxNumericActiuni();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Simbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Sector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&PretCurent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "&NumarActiuni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "&Data Actualizare";
            // 
            // tbSimbol
            // 
            this.tbSimbol.Location = new System.Drawing.Point(145, 34);
            this.tbSimbol.Name = "tbSimbol";
            this.tbSimbol.Size = new System.Drawing.Size(287, 20);
            this.tbSimbol.TabIndex = 6;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(145, 72);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(287, 20);
            this.tbDenumire.TabIndex = 8;
            this.tbDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.tbDenumire_Validating);
            this.tbDenumire.Validated += new System.EventHandler(this.tbDenumire_Validated);
            // 
            // dtpDataActualizare
            // 
            this.dtpDataActualizare.Location = new System.Drawing.Point(145, 237);
            this.dtpDataActualizare.Name = "dtpDataActualizare";
            this.dtpDataActualizare.Size = new System.Drawing.Size(287, 20);
            this.dtpDataActualizare.TabIndex = 11;
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Items.AddRange(new object[] {
            "Financiar",
            "Energie",
            "Tehnologie",
            "Sanatate",
            "Industrie",
            "Bunuri de consum",
            "Servicii de consum",
            "Materiale",
            "Telecomunicatii"});
            this.cmbSector.Location = new System.Drawing.Point(145, 111);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(287, 21);
            this.cmbSector.TabIndex = 12;
            // 
            // adaugaBTN
            // 
            this.adaugaBTN.Location = new System.Drawing.Point(39, 346);
            this.adaugaBTN.Name = "adaugaBTN";
            this.adaugaBTN.Size = new System.Drawing.Size(149, 83);
            this.adaugaBTN.TabIndex = 13;
            this.adaugaBTN.Text = "Adauga";
            this.adaugaBTN.UseVisualStyleBackColor = true;
            this.adaugaBTN.Click += new System.EventHandler(this.adaugaBTN_Click);
            // 
            // renuntaBTN
            // 
            this.renuntaBTN.Location = new System.Drawing.Point(327, 346);
            this.renuntaBTN.Name = "renuntaBTN";
            this.renuntaBTN.Size = new System.Drawing.Size(163, 83);
            this.renuntaBTN.TabIndex = 14;
            this.renuntaBTN.Text = "Renunta";
            this.renuntaBTN.UseVisualStyleBackColor = true;
            this.renuntaBTN.Click += new System.EventHandler(this.renuntaBTN_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtBoxNumericNr
            // 
            this.txtBoxNumericNr.Location = new System.Drawing.Point(27, 138);
            this.txtBoxNumericNr.Name = "txtBoxNumericNr";
            this.txtBoxNumericNr.Size = new System.Drawing.Size(405, 78);
            this.txtBoxNumericNr.TabIndex = 16;
            this.txtBoxNumericNr.Valoare = 0F;
            // 
            // txtBoxNumericPret
            // 
            this.txtBoxNumericPret.Location = new System.Drawing.Point(27, 107);
            this.txtBoxNumericPret.Name = "txtBoxNumericPret";
            this.txtBoxNumericPret.Size = new System.Drawing.Size(405, 75);
            this.txtBoxNumericPret.TabIndex = 15;
            this.txtBoxNumericPret.Valoare = 0F;
            // 
            // FormActiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 578);
            this.Controls.Add(this.renuntaBTN);
            this.Controls.Add(this.adaugaBTN);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.dtpDataActualizare);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbSimbol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNumericPret);
            this.Controls.Add(this.txtBoxNumericNr);
            this.Name = "FormActiune";
            this.Text = "FormActiune";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormActiune_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSimbol;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.DateTimePicker dtpDataActualizare;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Button adaugaBTN;
        private System.Windows.Forms.Button renuntaBTN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private TextBoxNumericActiuni txtBoxNumericNr;
        private TextBoxNumericActiuni txtBoxNumericPret;
    }
}