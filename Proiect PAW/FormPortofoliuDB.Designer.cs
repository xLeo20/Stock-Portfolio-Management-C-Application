namespace Proiect_PAW
{
    partial class FormPortofoliuDB
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
            this.dataGridViewPortofolii = new System.Windows.Forms.DataGridView();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.dtpDataCreare = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adaugaBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.salvareBTN = new System.Windows.Forms.Button();
            this.stergeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPortofolii)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPortofolii
            // 
            this.dataGridViewPortofolii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPortofolii.Location = new System.Drawing.Point(113, 62);
            this.dataGridViewPortofolii.Name = "dataGridViewPortofolii";
            this.dataGridViewPortofolii.Size = new System.Drawing.Size(573, 201);
            this.dataGridViewPortofolii.TabIndex = 0;
            // 
            // tbDescriere
            // 
            this.tbDescriere.Location = new System.Drawing.Point(197, 355);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(200, 20);
            this.tbDescriere.TabIndex = 1;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(197, 314);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(200, 20);
            this.tbDenumire.TabIndex = 3;
            // 
            // dtpDataCreare
            // 
            this.dtpDataCreare.Location = new System.Drawing.Point(197, 394);
            this.dtpDataCreare.Name = "dtpDataCreare";
            this.dtpDataCreare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataCreare.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Creare";
            // 
            // adaugaBTN
            // 
            this.adaugaBTN.Location = new System.Drawing.Point(426, 380);
            this.adaugaBTN.Name = "adaugaBTN";
            this.adaugaBTN.Size = new System.Drawing.Size(118, 34);
            this.adaugaBTN.TabIndex = 8;
            this.adaugaBTN.Text = "Adauga";
            this.adaugaBTN.UseVisualStyleBackColor = true;
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(585, 288);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(137, 46);
            this.updateBTN.TabIndex = 9;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            // 
            // salvareBTN
            // 
            this.salvareBTN.Location = new System.Drawing.Point(585, 384);
            this.salvareBTN.Name = "salvareBTN";
            this.salvareBTN.Size = new System.Drawing.Size(139, 34);
            this.salvareBTN.TabIndex = 10;
            this.salvareBTN.Text = "Salvare";
            this.salvareBTN.UseVisualStyleBackColor = true;
            // 
            // stergeBTN
            // 
            this.stergeBTN.Location = new System.Drawing.Point(426, 288);
            this.stergeBTN.Name = "stergeBTN";
            this.stergeBTN.Size = new System.Drawing.Size(118, 46);
            this.stergeBTN.TabIndex = 11;
            this.stergeBTN.Text = "Sterge";
            this.stergeBTN.UseVisualStyleBackColor = true;
            // 
            // FormPortofoliuDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stergeBTN);
            this.Controls.Add(this.salvareBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.adaugaBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataCreare);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.dataGridViewPortofolii);
            this.Name = "FormPortofoliuDB";
            this.Text = "FormPortofoliuDB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPortofolii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPortofolii;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.DateTimePicker dtpDataCreare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adaugaBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button salvareBTN;
        private System.Windows.Forms.Button stergeBTN;
    }
}