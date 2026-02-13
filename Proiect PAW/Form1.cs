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
using System.Xml.Serialization;
using System.Drawing.Printing;

namespace Proiect_PAW
{
    public partial class Form1 : Form
    {

        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private Font printFont = new Font("Arial", 10);
        public Form1()
        {
            InitializeComponent();
            lvActiuni.ItemDrag += lvActiuni_ItemDrag;
            treeView1.DragEnter += treeView1_DragEnter;
            treeView1.DragDrop += treeView1_DragDrop;
            lvPortofolii.AllowDrop = true;
            lvPortofolii.DragEnter += lvPortofolii_DragEnter;
            lvPortofolii.DragDrop += lvPortofolii_DragDrop;
        }

        private void adaugaBTN_Click(object sender, EventArgs e)
        {
            Actiune actiune = null;
            FormActiune formActiune = new FormActiune(actiune);
            if (formActiune.ShowDialog() == DialogResult.OK)
            {
                actiune = formActiune.actiuneLocala;
                ListViewItem lv = lvActiuni.Items.Add(actiune.simbol);
                lv.SubItems.Add(actiune.denumire);
                lv.SubItems.Add(actiune.sector);
                lv.SubItems.Add(actiune.pretCurent);
                lv.SubItems.Add(actiune.numarActiuni);
                lv.SubItems.Add(actiune.dataActualizare.ToString());
                lv.Tag = actiune;
            }
        }

        private void salveazaBTN_Click(object sender, EventArgs e)
        {
            string simbol = tbSimbol.Text;
            string denumire = tbDenumire.Text;
            string sector = cmbSector.Text;
            string PretCurent = tbPretCurent.Text;
            string numarActiuni = tbNumarActiuni.Text;
            DateTime dataActualizare = dtpDataActualizare.Value;
            if (cmbSector.SelectedIndex > -1)
            {
                Actiune a = new Actiune(simbol, denumire, sector, PretCurent, numarActiuni, dataActualizare);
                lbActiuni.Items.Add(a.ToString());
            }
            else
            {
                if (
                MessageBox.Show("Selectati sectorul!", "Mesaj Informare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    == DialogResult.Cancel)
                {
                    MessageBox.Show("Ati apasat butonul Cancel");
                }
            }
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvActiuni.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvActiuni.SelectedItems[0];
                Actiune actiune = (Actiune)lv.Tag;
                FormActiune formA = new FormActiune(actiune);
                if (formA.ShowDialog() == DialogResult.OK)
                {
                    lv.SubItems[0].Text = actiune.simbol;
                    lv.SubItems[1].Text = actiune.denumire;
                    lv.SubItems[2].Text = actiune.sector;
                    lv.SubItems[3].Text = actiune.pretCurent;
                    lv.SubItems[4].Text = actiune.numarActiuni;
                    lv.SubItems[5].Text = actiune.dataActualizare.ToString();
                }
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvActiuni.SelectedItems.Count > 0)
            {
                lvActiuni.SelectedItems[0].Remove();
            }
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugaBTN_Click(sender, e);
        }

        private void salvareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Fisiere binare.bin|*.bin";
            saveFile.CheckPathExists = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Stream fisier = File.Create(saveFile.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Actiune> listaActiuni = new List<Actiune>();
                foreach (ListViewItem item in lvActiuni.Items)
                {
                    listaActiuni.Add((Actiune)item.Tag);
                }
#pragma warning disable SYSLIB0011
                serializator.Serialize(fisier, listaActiuni);
#pragma warning restore SYSLIB0011
                fisier.Close();
            }
        }

        private void deschidereBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Fisiere binare.bin|*.bin";
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Stream fisier = File.OpenRead(openFile.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Actiune> listaActiuni;
#pragma warning disable SYSLIB0011
                listaActiuni = (List<Actiune>)serializator.Deserialize(fisier);
#pragma warning restore SYSLIB0011
                fisier.Close();
                foreach (Actiune a in listaActiuni)
                {
                    ListViewItem itm = new ListViewItem(new string[] { a.simbol, a.denumire, a.sector, a.pretCurent, a.numarActiuni, a.dataActualizare.ToString() });
                    itm.Tag = a;
                    lvActiuni.Items.Add(itm);
                }
            }
        }

        private void salvareCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Fisiere CSV|*.csv";
            saveFile.CheckPathExists = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                List<Actiune> listaActiuni = new List<Actiune>();
                foreach (ListViewItem item in lvActiuni.Items)
                {
                    listaActiuni.Add((Actiune)item.Tag);
                }
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Simbol, Denumire, Sector, PretCurent, NumarActiuni, DataActualizare");
                foreach (Actiune a in listaActiuni)
                {
                    sb.AppendLine(a.simbol + "," + a.denumire + "," + a.sector + "," + a.pretCurent + "," + a.numarActiuni + "," + a.dataActualizare.ToString());
                }
                File.WriteAllText(saveFile.FileName, sb.ToString());
            }
        }

        private void deschidereCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Fisiere csv|*.csv";
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lvActiuni.Items.Clear();
                var linii = File.ReadAllLines(openFile.FileName);
                for (int i = 1; i < linii.Length; i++)
                {
                    string[] valori = linii[i].Split(',');
                    if (valori.Length == 6)
                    {
                        Actiune a = new Actiune(valori[0], valori[1], valori[2], valori[3], valori[4], DateTime.Parse(valori[5]));
                        ListViewItem itm = new ListViewItem(new string[] { a.simbol, a.denumire, a.sector, a.pretCurent, a.numarActiuni, a.dataActualizare.ToString() });
                        itm.Tag = a;
                        lvActiuni.Items.Add(itm);
                    }
                }
            }
        }

        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Fisiere XML|*.xml";
            saveFile.CheckPathExists = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                TextWriter fisier = new StreamWriter(saveFile.FileName);
                XmlSerializer xmlSerializator = new XmlSerializer(typeof(List<Actiune>));
                List<Actiune> listaActiuni = new List<Actiune>();
                foreach (ListViewItem item in lvActiuni.Items)
                {
                    listaActiuni.Add((Actiune)item.Tag);
                }
                xmlSerializator.Serialize(fisier, listaActiuni);
                fisier.Close();
            }
        }

        private void deschidereXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Fisiere xml|*.xml";
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fisier = File.OpenRead(openFile.FileName);
                XmlSerializer xmlSerializator = new XmlSerializer(typeof(List<Actiune>));
                List<Actiune> listaActiuni;
                listaActiuni = (List<Actiune>)xmlSerializator.Deserialize(fisier);
                fisier.Close();
                foreach (Actiune a in listaActiuni)
                {
                    ListViewItem itm = new ListViewItem(new string[] { a.simbol, a.denumire, a.sector, a.pretCurent, a.numarActiuni, a.dataActualizare.ToString() });
                    itm.Tag = a;
                    lvActiuni.Items.Add(itm);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen creionRosu = new Pen(Color.Red, 2);
            Rectangle zonaDesen = e.ClipRectangle;
            Brush fundal = new SolidBrush(Color.White);

            g.FillRectangle(fundal, zonaDesen);

            zonaDesen.X += 2;
            zonaDesen.Y += 2;
            zonaDesen.Width -= 4;
            zonaDesen.Height -= 4;

            g.DrawRectangle(creionRosu, zonaDesen);

            float[] sume = new float[] { 0f, 0f, 0f };
            foreach (TreeNode nodParinte in treeView1.Nodes)
            {
                foreach (TreeNode nodCopil in nodParinte.Nodes)
                {
                    string[] vector = nodCopil.Text.Split('-');
                    sume[nodParinte.Index] += float.Parse(vector[1]);
                }
            }
            for (int i = 0; i < 3; i++)
                g.DrawRectangle(new Pen(Color.Blue), 5, i * 55 + 5,
                    e.ClipRectangle.Width * 0.9f * (sume[i] > 0 ? sume[i] : 1) / (sume.Max() > 0 ? sume.Max() : 1), 50);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.SelectedNode.Parent == null)
            {
                FormCategorie f2 = new FormCategorie();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    treeView1.SelectedNode.Nodes.Add(f2.nodNou);
                    panel1.Invalidate();
                }
            }
        }

        private void gestiuneActiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActiuniDB f = new FormActiuniDB();
            f.ShowDialog();
        }

        private void lvActiuni_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvActiuni.DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                Point pt = treeView1.PointToClient(new Point(e.X, e.Y));
                TreeNode targetNode = treeView1.GetNodeAt(pt);

                string text = item.SubItems[0].Text
                    + " | " + item.SubItems[1].Text
                    + " | " + item.SubItems[2].Text
                    + " | " + item.SubItems[3].Text
                    + " | " + item.SubItems[4].Text
                    + " | " + item.SubItems[5].Text;

                if (targetNode != null)
                {
                    targetNode.Nodes.Add(text);
                    targetNode.Expand();
                }
                else
                {
                    treeView1.Nodes.Add(text);
                }
                item.Remove();
            }
        }

        private void adaugaPortofoliuBTN_Click(object sender, EventArgs e)
        {
            Portofoliu portofoliu = null;
            FormPortofoliu formPortofoliu = new FormPortofoliu(portofoliu);
            if (formPortofoliu.ShowDialog() == DialogResult.OK)
            {
                portofoliu = formPortofoliu.portofoliuLocal;
                ListViewItem lv = lvPortofolii.Items.Add(portofoliu.denumire);
                lv.SubItems.Add(portofoliu.descriere);
                lv.SubItems.Add(portofoliu.dataCreare.ToString("dd/MM/yyyy"));
                lv.SubItems.Add(portofoliu.actiuni.Count.ToString());
                lv.Tag = portofoliu;
            }
        }

        private void gestiunePortofoliiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPortofoliuDB f = new FormPortofoliuDB();
            f.ShowDialog();

        }

        private void lvPortofolii_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lvPortofolii_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem itemActiune = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                Actiune actiune = (Actiune)itemActiune.Tag;

                Point pt = lvPortofolii.PointToClient(new Point(e.X, e.Y));
                ListViewItem targetItem = lvPortofolii.GetItemAt(pt.X, pt.Y);

                if (targetItem != null)
                {
                    Portofoliu portofoliu = (Portofoliu)targetItem.Tag;
                    portofoliu.actiuni.Add(actiune);

                    targetItem.SubItems[3].Text = portofoliu.actiuni.Count.ToString();

                    itemActiune.Remove();

                    MessageBox.Show($"Acțiunea {actiune.simbol} a fost adăugată în portofoliul {portofoliu.denumire}");
                }
            }
        }

        private void salvarePortofoliiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Fisiere binare portofolii|*.pfb";
            saveFile.CheckPathExists = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Stream fisier = File.Create(saveFile.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Portofoliu> listaPortofolii = new List<Portofoliu>();

                foreach (ListViewItem item in lvPortofolii.Items)
                {
                    listaPortofolii.Add((Portofoliu)item.Tag);
                }

#pragma warning disable SYSLIB0011
                serializator.Serialize(fisier, listaPortofolii);
#pragma warning restore SYSLIB0011
                fisier.Close();
                MessageBox.Show("Portofoliile au fost salvate cu succes!");
            }
        }

        private void deschiderePortofoliiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Fisiere binare portofolii|*.pfb";
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Stream fisier = File.OpenRead(openFile.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Portofoliu> listaPortofolii;

#pragma warning disable SYSLIB0011
                listaPortofolii = (List<Portofoliu>)serializator.Deserialize(fisier);
#pragma warning restore SYSLIB0011
                fisier.Close();

                foreach (Portofoliu p in listaPortofolii)
                {
                    ListViewItem itm = new ListViewItem(new string[] {
                p.denumire,
                p.descriere,
                p.dataCreare.ToString(),
                p.actiuni.Count.ToString()
            });
                    itm.Tag = p;
                    lvPortofolii.Items.Add(itm);
                }
                MessageBox.Show("Portofoliile au fost încărcate cu succes!");
            }
        }

        private void editareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvPortofolii.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvPortofolii.SelectedItems[0];
                Portofoliu portofoliu = (Portofoliu)lv.Tag;
                FormPortofoliu formP = new FormPortofoliu(portofoliu);
                if (formP.ShowDialog() == DialogResult.OK)
                {
                    lv.SubItems[0].Text = portofoliu.denumire;
                    lv.SubItems[1].Text = portofoliu.descriere;
                    lv.SubItems[2].Text = portofoliu.dataCreare.ToString("dd/MM/yyyy");
                    lv.SubItems[3].Text = portofoliu.actiuni.Count.ToString();
                }
            }
        }

        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvPortofolii.SelectedItems.Count > 0)
            {
                var confirmare = MessageBox.Show(
                    "Sigur vrei să ștergi acest portofoliu?",
                    "Confirmare",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmare == DialogResult.Yes)
                {
                    lvPortofolii.SelectedItems[0].Remove();
                }
            }
        }

        private void adugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugaPortofoliuBTN_Click(sender, e);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage -= printDocument1_PrintPage;
            printDocument1.PrintPage += printDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = e.MarginBounds.Top;
            float left = e.MarginBounds.Left;
            float lineHeight = printFont.GetHeight(e.Graphics) + 4;
            float colWidth = 100;
            int colIndex = 0;

            string[] headers = { "Simbol", "Denumire", "Sector", "Pret Curent", "Numar Actiuni", "Data Actualizare" };
            foreach (var header in headers)
            {
                e.Graphics.DrawString(header, printFont, Brushes.Black, left + colIndex * colWidth, y);
                colIndex++;
            }
            y += lineHeight;

            foreach (ListViewItem item in lvActiuni.Items)
            {
                colIndex = 0;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    e.Graphics.DrawString(subItem.Text, printFont, Brushes.Black, left + colIndex * colWidth, y);
                    colIndex++;
                }
                y += lineHeight;
                if (y > e.MarginBounds.Bottom) 
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            e.HasMorePages = false;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.Document = printDocument1;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrintPage -= printDocument1_PrintPage;
                printDocument1.PrintPage += printDocument1_PrintPage;
                printDocument1.Print();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

