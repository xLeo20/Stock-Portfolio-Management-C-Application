namespace Proiect_PAW
{
    partial class FormActiuniDB
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
            this.dataGridViewActiuni = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretCurentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarActiuniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataActualizareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceActiuni = new System.Windows.Forms.BindingSource(this.components);
            this.actiuniDataSet = new Proiect_PAW.ActiuniDataSet();
            this.tbNumarActiuni = new System.Windows.Forms.TextBox();
            this.tbSimbol = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbPretCurent = new System.Windows.Forms.TextBox();
            this.dtpDataActualizare = new System.Windows.Forms.DateTimePicker();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.adaugaBTN = new System.Windows.Forms.Button();
            this.salvareBTN = new System.Windows.Forms.Button();
            this.actiuniTableAdapter = new Proiect_PAW.ActiuniDataSetTableAdapters.ActiuniTableAdapter();
            this.stergeBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActiuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actiuniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActiuni
            // 
            this.dataGridViewActiuni.AutoGenerateColumns = false;
            this.dataGridViewActiuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.simbolDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.sectorDataGridViewTextBoxColumn,
            this.pretCurentDataGridViewTextBoxColumn,
            this.numarActiuniDataGridViewTextBoxColumn,
            this.dataActualizareDataGridViewTextBoxColumn});
            this.dataGridViewActiuni.DataSource = this.bindingSourceActiuni;
            this.dataGridViewActiuni.Location = new System.Drawing.Point(117, 43);
            this.dataGridViewActiuni.MultiSelect = false;
            this.dataGridViewActiuni.Name = "dataGridViewActiuni";
            this.dataGridViewActiuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActiuni.Size = new System.Drawing.Size(741, 235);
            this.dataGridViewActiuni.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // simbolDataGridViewTextBoxColumn
            // 
            this.simbolDataGridViewTextBoxColumn.DataPropertyName = "Simbol";
            this.simbolDataGridViewTextBoxColumn.HeaderText = "Simbol";
            this.simbolDataGridViewTextBoxColumn.Name = "simbolDataGridViewTextBoxColumn";
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            // 
            // sectorDataGridViewTextBoxColumn
            // 
            this.sectorDataGridViewTextBoxColumn.DataPropertyName = "Sector";
            this.sectorDataGridViewTextBoxColumn.HeaderText = "Sector";
            this.sectorDataGridViewTextBoxColumn.Name = "sectorDataGridViewTextBoxColumn";
            // 
            // pretCurentDataGridViewTextBoxColumn
            // 
            this.pretCurentDataGridViewTextBoxColumn.DataPropertyName = "PretCurent";
            this.pretCurentDataGridViewTextBoxColumn.HeaderText = "PretCurent";
            this.pretCurentDataGridViewTextBoxColumn.Name = "pretCurentDataGridViewTextBoxColumn";
            // 
            // numarActiuniDataGridViewTextBoxColumn
            // 
            this.numarActiuniDataGridViewTextBoxColumn.DataPropertyName = "NumarActiuni";
            this.numarActiuniDataGridViewTextBoxColumn.HeaderText = "NumarActiuni";
            this.numarActiuniDataGridViewTextBoxColumn.Name = "numarActiuniDataGridViewTextBoxColumn";
            // 
            // dataActualizareDataGridViewTextBoxColumn
            // 
            this.dataActualizareDataGridViewTextBoxColumn.DataPropertyName = "DataActualizare";
            this.dataActualizareDataGridViewTextBoxColumn.HeaderText = "DataActualizare";
            this.dataActualizareDataGridViewTextBoxColumn.Name = "dataActualizareDataGridViewTextBoxColumn";
            // 
            // bindingSourceActiuni
            // 
            this.bindingSourceActiuni.DataMember = "Actiuni";
            this.bindingSourceActiuni.DataSource = this.actiuniDataSet;
            // 
            // actiuniDataSet
            // 
            this.actiuniDataSet.DataSetName = "ActiuniDataSet";
            this.actiuniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNumarActiuni
            // 
            this.tbNumarActiuni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActiuni, "NumarActiuni", true));
            this.tbNumarActiuni.Location = new System.Drawing.Point(693, 302);
            this.tbNumarActiuni.Name = "tbNumarActiuni";
            this.tbNumarActiuni.Size = new System.Drawing.Size(100, 20);
            this.tbNumarActiuni.TabIndex = 1;
            // 
            // tbSimbol
            // 
            this.tbSimbol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActiuni, "Simbol", true));
            this.tbSimbol.Location = new System.Drawing.Point(248, 301);
            this.tbSimbol.Name = "tbSimbol";
            this.tbSimbol.Size = new System.Drawing.Size(100, 20);
            this.tbSimbol.TabIndex = 2;
            // 
            // tbDenumire
            // 
            this.tbDenumire.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActiuni, "Denumire", true));
            this.tbDenumire.Location = new System.Drawing.Point(354, 301);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 20);
            this.tbDenumire.TabIndex = 3;
            // 
            // tbPretCurent
            // 
            this.tbPretCurent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActiuni, "PretCurent", true));
            this.tbPretCurent.Location = new System.Drawing.Point(587, 302);
            this.tbPretCurent.Name = "tbPretCurent";
            this.tbPretCurent.Size = new System.Drawing.Size(100, 20);
            this.tbPretCurent.TabIndex = 4;
            // 
            // dtpDataActualizare
            // 
            this.dtpDataActualizare.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceActiuni, "DataActualizare", true));
            this.dtpDataActualizare.Location = new System.Drawing.Point(799, 302);
            this.dtpDataActualizare.Name = "dtpDataActualizare";
            this.dtpDataActualizare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataActualizare.TabIndex = 5;
            // 
            // cmbSector
            // 
            this.cmbSector.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceActiuni, "Sector", true));
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
            this.cmbSector.Location = new System.Drawing.Point(460, 301);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(121, 21);
            this.cmbSector.TabIndex = 6;
            // 
            // adaugaBTN
            // 
            this.adaugaBTN.Location = new System.Drawing.Point(117, 360);
            this.adaugaBTN.Name = "adaugaBTN";
            this.adaugaBTN.Size = new System.Drawing.Size(109, 40);
            this.adaugaBTN.TabIndex = 7;
            this.adaugaBTN.Text = "Adauga";
            this.adaugaBTN.UseVisualStyleBackColor = true;
            this.adaugaBTN.Click += new System.EventHandler(this.adaugaBTN_Click);
            // 
            // salvareBTN
            // 
            this.salvareBTN.Location = new System.Drawing.Point(117, 299);
            this.salvareBTN.Name = "salvareBTN";
            this.salvareBTN.Size = new System.Drawing.Size(109, 35);
            this.salvareBTN.TabIndex = 8;
            this.salvareBTN.Text = "Salveaza";
            this.salvareBTN.UseVisualStyleBackColor = true;
            this.salvareBTN.Click += new System.EventHandler(this.salvareBTN_Click);
            // 
            // actiuniTableAdapter
            // 
            this.actiuniTableAdapter.ClearBeforeFill = true;
            // 
            // stergeBTN
            // 
            this.stergeBTN.Location = new System.Drawing.Point(248, 360);
            this.stergeBTN.Name = "stergeBTN";
            this.stergeBTN.Size = new System.Drawing.Size(118, 40);
            this.stergeBTN.TabIndex = 9;
            this.stergeBTN.Text = "Sterge";
            this.stergeBTN.UseVisualStyleBackColor = true;
            this.stergeBTN.Click += new System.EventHandler(this.stergeBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(392, 360);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(118, 40);
            this.updateBTN.TabIndex = 10;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            // 
            // FormActiuniDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 437);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.stergeBTN);
            this.Controls.Add(this.salvareBTN);
            this.Controls.Add(this.adaugaBTN);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.dtpDataActualizare);
            this.Controls.Add(this.tbPretCurent);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbSimbol);
            this.Controls.Add(this.tbNumarActiuni);
            this.Controls.Add(this.dataGridViewActiuni);
            this.Name = "FormActiuniDB";
            this.Text = "FormActiuniDB";
            this.Load += new System.EventHandler(this.FormActiuniDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActiuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actiuniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceActiuni;
        private System.Windows.Forms.DataGridView dataGridViewActiuni;
        private System.Windows.Forms.TextBox tbNumarActiuni;
        private System.Windows.Forms.TextBox tbSimbol;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPretCurent;
        private System.Windows.Forms.DateTimePicker dtpDataActualizare;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Button adaugaBTN;
        private System.Windows.Forms.Button salvareBTN;
        private ActiuniDataSet actiuniDataSet;
        private ActiuniDataSetTableAdapters.ActiuniTableAdapter actiuniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretCurentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarActiuniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataActualizareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button stergeBTN;
        private System.Windows.Forms.Button updateBTN;
    }
}