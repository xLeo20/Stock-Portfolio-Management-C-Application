namespace Proiect_PAW
{
    partial class FormCategorie
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.renuntaBTN = new System.Windows.Forms.Button();
            this.okBTN = new System.Windows.Forms.Button();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtValoare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Denumire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valoare";
            // 
            // renuntaBTN
            // 
            this.renuntaBTN.Location = new System.Drawing.Point(216, 132);
            this.renuntaBTN.Name = "renuntaBTN";
            this.renuntaBTN.Size = new System.Drawing.Size(114, 48);
            this.renuntaBTN.TabIndex = 2;
            this.renuntaBTN.Text = "Renunta";
            this.renuntaBTN.UseVisualStyleBackColor = true;
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(58, 132);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(106, 48);
            this.okBTN.TabIndex = 3;
            this.okBTN.Text = "OK";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(97, 24);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(233, 20);
            this.txtDenumire.TabIndex = 4;
            // 
            // txtValoare
            // 
            this.txtValoare.Location = new System.Drawing.Point(97, 67);
            this.txtValoare.Name = "txtValoare";
            this.txtValoare.Size = new System.Drawing.Size(233, 20);
            this.txtValoare.TabIndex = 5;
            // 
            // FormCategorie
            // 
            this.ClientSize = new System.Drawing.Size(549, 328);
            this.Controls.Add(this.txtValoare);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.renuntaBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button renuntaBTN;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtValoare;
    }
}