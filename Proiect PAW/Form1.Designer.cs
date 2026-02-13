namespace Proiect_PAW
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            this.lvActiuni = new System.Windows.Forms.ListView();
            this.Simbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PretCurent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumarActiuni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataActualizare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaBTN = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbActiuni = new System.Windows.Forms.ListBox();
            this.salveazaBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSimbol = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbPretCurent = new System.Windows.Forms.TextBox();
            this.tbNumarActiuni = new System.Windows.Forms.TextBox();
            this.dtpDataActualizare = new System.Windows.Forms.DateTimePicker();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.salvareCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.salvareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarePortofoliiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschiderePortofoliiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiuneActiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiunePortofoliiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actiuniDataSet = new Proiect_PAW.ActiuniDataSet();
            this.lvPortofolii = new System.Windows.Forms.ListView();
            this.denumireCLMN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desciereCLMN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCreare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripPortofoliu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaPortofoliuBTN = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actiuniDataSet)).BeginInit();
            this.contextMenuStripPortofoliu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvActiuni
            // 
            this.lvActiuni.CheckBoxes = true;
            this.lvActiuni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Simbol,
            this.Denumire,
            this.Sector,
            this.PretCurent,
            this.NumarActiuni,
            this.DataActualizare});
            this.lvActiuni.ContextMenuStrip = this.contextMenuStrip1;
            this.lvActiuni.HideSelection = false;
            this.lvActiuni.Location = new System.Drawing.Point(632, 149);
            this.lvActiuni.Name = "lvActiuni";
            this.lvActiuni.Size = new System.Drawing.Size(424, 246);
            this.lvActiuni.TabIndex = 0;
            this.lvActiuni.UseCompatibleStateImageBehavior = false;
            this.lvActiuni.View = System.Windows.Forms.View.Details;
            this.lvActiuni.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvActiuni_ItemDrag);
            // 
            // Simbol
            // 
            this.Simbol.Text = "Simbol";
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            // 
            // Sector
            // 
            this.Sector.Text = "Sector";
            // 
            // PretCurent
            // 
            this.PretCurent.Text = "Pret Curent";
            this.PretCurent.Width = 79;
            // 
            // NumarActiuni
            // 
            this.NumarActiuni.Text = "Numar Actiuni";
            // 
            // DataActualizare
            // 
            this.DataActualizare.Text = "Data Actualizare";
            this.DataActualizare.Width = 91;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem,
            this.stergereToolStripMenuItem,
            this.adaugareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 70);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.editareToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // adaugaBTN
            // 
            this.adaugaBTN.Location = new System.Drawing.Point(109, 398);
            this.adaugaBTN.Name = "adaugaBTN";
            this.adaugaBTN.Size = new System.Drawing.Size(372, 36);
            this.adaugaBTN.TabIndex = 1;
            this.adaugaBTN.Text = "Adauga";
            this.adaugaBTN.UseVisualStyleBackColor = true;
            this.adaugaBTN.Click += new System.EventHandler(this.adaugaBTN_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(632, 431);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(424, 140);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(109, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 180);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbActiuni
            // 
            this.lbActiuni.FormattingEnabled = true;
            this.lbActiuni.Location = new System.Drawing.Point(632, 40);
            this.lbActiuni.Name = "lbActiuni";
            this.lbActiuni.Size = new System.Drawing.Size(424, 95);
            this.lbActiuni.TabIndex = 5;
            // 
            // salveazaBTN
            // 
            this.salveazaBTN.Location = new System.Drawing.Point(109, 307);
            this.salveazaBTN.Name = "salveazaBTN";
            this.salveazaBTN.Size = new System.Drawing.Size(372, 59);
            this.salveazaBTN.TabIndex = 6;
            this.salveazaBTN.Text = "Salveaza";
            this.salveazaBTN.UseVisualStyleBackColor = true;
            this.salveazaBTN.Click += new System.EventHandler(this.salveazaBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Simbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PretCurent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numar Actiuni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Actualizare";
            // 
            // tbSimbol
            // 
            this.tbSimbol.Location = new System.Drawing.Point(144, 40);
            this.tbSimbol.Name = "tbSimbol";
            this.tbSimbol.Size = new System.Drawing.Size(345, 20);
            this.tbSimbol.TabIndex = 13;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(144, 75);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(345, 20);
            this.tbDenumire.TabIndex = 14;
            // 
            // tbPretCurent
            // 
            this.tbPretCurent.Location = new System.Drawing.Point(144, 142);
            this.tbPretCurent.Name = "tbPretCurent";
            this.tbPretCurent.Size = new System.Drawing.Size(345, 20);
            this.tbPretCurent.TabIndex = 15;
            // 
            // tbNumarActiuni
            // 
            this.tbNumarActiuni.Location = new System.Drawing.Point(144, 189);
            this.tbNumarActiuni.Name = "tbNumarActiuni";
            this.tbNumarActiuni.Size = new System.Drawing.Size(345, 20);
            this.tbNumarActiuni.TabIndex = 16;
            // 
            // dtpDataActualizare
            // 
            this.dtpDataActualizare.Location = new System.Drawing.Point(144, 235);
            this.dtpDataActualizare.Name = "dtpDataActualizare";
            this.dtpDataActualizare.Size = new System.Drawing.Size(345, 20);
            this.dtpDataActualizare.TabIndex = 17;
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
            this.cmbSector.Location = new System.Drawing.Point(144, 104);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(345, 21);
            this.cmbSector.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.gestiuneActiuniToolStripMenuItem,
            this.gestiunePortofoliiToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareBinarToolStripMenuItem,
            this.deschidereBinarToolStripMenuItem,
            this.toolStripSeparator4,
            this.salvareCSVToolStripMenuItem,
            this.deschidereCSVToolStripMenuItem,
            this.toolStripSeparator3,
            this.salvareXMLToolStripMenuItem,
            this.deschidereXMLToolStripMenuItem,
            this.toolStripSeparator2,
            this.salvarePortofoliiToolStripMenuItem,
            this.deschiderePortofoliiToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salvareBinarToolStripMenuItem.Text = "Salvare binar";
            this.salvareBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareBinarToolStripMenuItem_Click);
            // 
            // deschidereBinarToolStripMenuItem
            // 
            this.deschidereBinarToolStripMenuItem.Name = "deschidereBinarToolStripMenuItem";
            this.deschidereBinarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deschidereBinarToolStripMenuItem.Text = "Deschidere binar";
            this.deschidereBinarToolStripMenuItem.Click += new System.EventHandler(this.deschidereBinarToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // salvareCSVToolStripMenuItem
            // 
            this.salvareCSVToolStripMenuItem.Name = "salvareCSVToolStripMenuItem";
            this.salvareCSVToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salvareCSVToolStripMenuItem.Text = "Salvare CSV";
            this.salvareCSVToolStripMenuItem.Click += new System.EventHandler(this.salvareCSVToolStripMenuItem_Click);
            // 
            // deschidereCSVToolStripMenuItem
            // 
            this.deschidereCSVToolStripMenuItem.Name = "deschidereCSVToolStripMenuItem";
            this.deschidereCSVToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deschidereCSVToolStripMenuItem.Text = "Deschidere CSV";
            this.deschidereCSVToolStripMenuItem.Click += new System.EventHandler(this.deschidereCSVToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // salvareXMLToolStripMenuItem
            // 
            this.salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            this.salvareXMLToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salvareXMLToolStripMenuItem.Text = "Salvare XML";
            this.salvareXMLToolStripMenuItem.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem_Click);
            // 
            // deschidereXMLToolStripMenuItem
            // 
            this.deschidereXMLToolStripMenuItem.Name = "deschidereXMLToolStripMenuItem";
            this.deschidereXMLToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deschidereXMLToolStripMenuItem.Text = "Deschidere XML";
            this.deschidereXMLToolStripMenuItem.Click += new System.EventHandler(this.deschidereXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // salvarePortofoliiToolStripMenuItem
            // 
            this.salvarePortofoliiToolStripMenuItem.Name = "salvarePortofoliiToolStripMenuItem";
            this.salvarePortofoliiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salvarePortofoliiToolStripMenuItem.Text = "Salvare Portofolii";
            this.salvarePortofoliiToolStripMenuItem.Click += new System.EventHandler(this.salvarePortofoliiToolStripMenuItem_Click);
            // 
            // deschiderePortofoliiToolStripMenuItem
            // 
            this.deschiderePortofoliiToolStripMenuItem.Name = "deschiderePortofoliiToolStripMenuItem";
            this.deschiderePortofoliiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deschiderePortofoliiToolStripMenuItem.Text = "Deschidere Portofolii";
            this.deschiderePortofoliiToolStripMenuItem.Click += new System.EventHandler(this.deschiderePortofoliiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gestiuneActiuniToolStripMenuItem
            // 
            this.gestiuneActiuniToolStripMenuItem.Name = "gestiuneActiuniToolStripMenuItem";
            this.gestiuneActiuniToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.gestiuneActiuniToolStripMenuItem.Text = "Gestiune actiuni";
            this.gestiuneActiuniToolStripMenuItem.Click += new System.EventHandler(this.gestiuneActiuniToolStripMenuItem_Click);
            // 
            // gestiunePortofoliiToolStripMenuItem
            // 
            this.gestiunePortofoliiToolStripMenuItem.Name = "gestiunePortofoliiToolStripMenuItem";
            this.gestiunePortofoliiToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.gestiunePortofoliiToolStripMenuItem.Text = "Gestiune Portofolii";
            this.gestiunePortofoliiToolStripMenuItem.Click += new System.EventHandler(this.gestiunePortofoliiToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // actiuniDataSet
            // 
            this.actiuniDataSet.DataSetName = "ActiuniDataSet";
            this.actiuniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lvPortofolii
            // 
            this.lvPortofolii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.denumireCLMN,
            this.desciereCLMN,
            this.dataCreare});
            this.lvPortofolii.ContextMenuStrip = this.contextMenuStripPortofoliu;
            this.lvPortofolii.HideSelection = false;
            this.lvPortofolii.Location = new System.Drawing.Point(1122, 149);
            this.lvPortofolii.Name = "lvPortofolii";
            this.lvPortofolii.Size = new System.Drawing.Size(295, 246);
            this.lvPortofolii.TabIndex = 20;
            this.lvPortofolii.UseCompatibleStateImageBehavior = false;
            this.lvPortofolii.View = System.Windows.Forms.View.Details;
            this.lvPortofolii.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvPortofolii_DragDrop);
            this.lvPortofolii.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvPortofolii_DragEnter);
            // 
            // denumireCLMN
            // 
            this.denumireCLMN.Text = "Denumire";
            this.denumireCLMN.Width = 99;
            // 
            // desciereCLMN
            // 
            this.desciereCLMN.Text = "Descriere";
            this.desciereCLMN.Width = 104;
            // 
            // dataCreare
            // 
            this.dataCreare.Text = "Data Creare";
            this.dataCreare.Width = 83;
            // 
            // contextMenuStripPortofoliu
            // 
            this.contextMenuStripPortofoliu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adugareToolStripMenuItem,
            this.editareToolStripMenuItem1,
            this.stergereToolStripMenuItem1});
            this.contextMenuStripPortofoliu.Name = "contextMenuStripPortofoliu";
            this.contextMenuStripPortofoliu.Size = new System.Drawing.Size(126, 70);
            // 
            // adugareToolStripMenuItem
            // 
            this.adugareToolStripMenuItem.Name = "adugareToolStripMenuItem";
            this.adugareToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adugareToolStripMenuItem.Text = "Adaugare";
            this.adugareToolStripMenuItem.Click += new System.EventHandler(this.adugareToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem1
            // 
            this.editareToolStripMenuItem1.Name = "editareToolStripMenuItem1";
            this.editareToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.editareToolStripMenuItem1.Text = "Editare";
            this.editareToolStripMenuItem1.Click += new System.EventHandler(this.editareToolStripMenuItem1_Click);
            // 
            // stergereToolStripMenuItem1
            // 
            this.stergereToolStripMenuItem1.Name = "stergereToolStripMenuItem1";
            this.stergereToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.stergereToolStripMenuItem1.Text = "Stergere";
            this.stergereToolStripMenuItem1.Click += new System.EventHandler(this.stergereToolStripMenuItem1_Click);
            // 
            // adaugaPortofoliuBTN
            // 
            this.adaugaPortofoliuBTN.Location = new System.Drawing.Point(1141, 431);
            this.adaugaPortofoliuBTN.Name = "adaugaPortofoliuBTN";
            this.adaugaPortofoliuBTN.Size = new System.Drawing.Size(144, 63);
            this.adaugaPortofoliuBTN.TabIndex = 21;
            this.adaugaPortofoliuBTN.Text = "Adauga Portofoliu";
            this.adaugaPortofoliuBTN.UseVisualStyleBackColor = true;
            this.adaugaPortofoliuBTN.Click += new System.EventHandler(this.adaugaPortofoliuBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 753);
            this.Controls.Add(this.adaugaPortofoliuBTN);
            this.Controls.Add(this.lvPortofolii);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.dtpDataActualizare);
            this.Controls.Add(this.tbNumarActiuni);
            this.Controls.Add(this.tbPretCurent);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbSimbol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salveazaBTN);
            this.Controls.Add(this.lbActiuni);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.adaugaBTN);
            this.Controls.Add(this.lvActiuni);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actiuniDataSet)).EndInit();
            this.contextMenuStripPortofoliu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvActiuni;
        private System.Windows.Forms.ColumnHeader Simbol;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Sector;
        private System.Windows.Forms.ColumnHeader PretCurent;
        private System.Windows.Forms.ColumnHeader NumarActiuni;
        private System.Windows.Forms.ColumnHeader DataActualizare;
        private System.Windows.Forms.Button adaugaBTN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbActiuni;
        private System.Windows.Forms.Button salveazaBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSimbol;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPretCurent;
        private System.Windows.Forms.TextBox tbNumarActiuni;
        private System.Windows.Forms.DateTimePicker dtpDataActualizare;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ActiuniDataSet actiuniDataSet;
        private System.Windows.Forms.ToolStripMenuItem gestiuneActiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiunePortofoliiToolStripMenuItem;
        private System.Windows.Forms.ListView lvPortofolii;
        private System.Windows.Forms.ColumnHeader denumireCLMN;
        private System.Windows.Forms.ColumnHeader desciereCLMN;
        private System.Windows.Forms.Button adaugaPortofoliuBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salvarePortofoliiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschiderePortofoliiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader dataCreare;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPortofoliu;
        private System.Windows.Forms.ToolStripMenuItem adugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}

