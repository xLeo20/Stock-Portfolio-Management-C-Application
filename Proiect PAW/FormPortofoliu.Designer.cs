namespace Proiect_PAW
{
    partial class FormPortofoliu
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
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.dtpDataCreare = new System.Windows.Forms.DateTimePicker();
            this.adaugaBTN = new System.Windows.Forms.Button();
            this.renuntaBTN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(117, 71);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(200, 20);
            this.tbDenumire.TabIndex = 2;
            this.tbDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.tbDenumire_Validating_1);
            this.tbDenumire.Validated += new System.EventHandler(this.tbDenumire_Validated_1);
            // 
            // tbDescriere
            // 
            this.tbDescriere.Location = new System.Drawing.Point(117, 124);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(200, 20);
            this.tbDescriere.TabIndex = 3;
            // 
            // dtpDataCreare
            // 
            this.dtpDataCreare.Location = new System.Drawing.Point(117, 183);
            this.dtpDataCreare.Name = "dtpDataCreare";
            this.dtpDataCreare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataCreare.TabIndex = 4;
            // 
            // adaugaBTN
            // 
            this.adaugaBTN.Location = new System.Drawing.Point(26, 272);
            this.adaugaBTN.Name = "adaugaBTN";
            this.adaugaBTN.Size = new System.Drawing.Size(134, 57);
            this.adaugaBTN.TabIndex = 5;
            this.adaugaBTN.Text = "Adauga";
            this.adaugaBTN.UseVisualStyleBackColor = true;
            this.adaugaBTN.Click += new System.EventHandler(this.adaugaBTN_Click_1);
            // 
            // renuntaBTN
            // 
            this.renuntaBTN.Location = new System.Drawing.Point(230, 272);
            this.renuntaBTN.Name = "renuntaBTN";
            this.renuntaBTN.Size = new System.Drawing.Size(149, 57);
            this.renuntaBTN.TabIndex = 6;
            this.renuntaBTN.Text = "Renunta";
            this.renuntaBTN.UseVisualStyleBackColor = true;
            this.renuntaBTN.Click += new System.EventHandler(this.renuntaBTN_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "&Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "&Descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data creare";
            // 
            // FormPortofoliu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.renuntaBTN);
            this.Controls.Add(this.adaugaBTN);
            this.Controls.Add(this.dtpDataCreare);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.tbDenumire);
            this.Name = "FormPortofoliu";
            this.Text = "FormPortofoliuDB";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPortofoliu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.DateTimePicker dtpDataCreare;
        private System.Windows.Forms.Button adaugaBTN;
        private System.Windows.Forms.Button renuntaBTN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}