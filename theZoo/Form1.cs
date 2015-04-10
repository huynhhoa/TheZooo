using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace theZoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML file(*.xml)|*.xml";
            sfd.RestoreDirectory = true;
            // Mởtập tin
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter xtw = new XmlTextWriter(sfd.FileName, null);
                xtw.WriteStartDocument();
                xtw.WriteStartElement("danhsach");
                for (int i = 0; i <= lstdanhsach.Items.Count - 1; i++)
                    xtw.WriteElementString("ten", lstdanhsach.Items[i].ToString());
                xtw.WriteEndElement();
                xtw.WriteEndDocument();
                xtw.Flush();
                xtw.Close();
            }
        }
        private void mnutai_Click(object sender, EventArgs e)
        {
            lstthumoi.Items.Clear();
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "XML file(*.xml)|*.xml";
            sfd.RestoreDirectory = true;
            // Mởtập tin
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XmlTextReader xtr = new XmlTextReader(sfd.FileName);
                while (xtr.Read())
                     if (xtr.NodeType == XmlNodeType.Element)
                        {
                            if (xtr.LocalName.Equals("ten"))
                                lstthumoi.Items.Add(xtr.ReadElementString());
                        }
            }
                     
            
             }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblngaythang.Text = string.Format("Bây giờ {0}:{1}:{2} là ngày {3} tháng {4} năm {5} ",
                DateTime.Now.Hour, DateTime.Now.Minute
                , DateTime.Now.Second, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }

        private void lstdanhsach_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat)) //kiem tra du lieu vao can sao chep dung k
            {
                ListBox lb = (ListBox)sender;
                if (!lstdanhsach.Items.Contains(lstthumoi.SelectedItem.ToString()))
                    lb.Items.Add(e.Data.GetData(DataFormats.Text));
            }
        }

        private void lstdanhsach_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstthumoi_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int index = lb.IndexFromPoint(e.X, e.Y);
            // neu da chon dc item
            if (index != -1)
            { // bat dau drag items(chi can text cua item do
                DragDropEffects effect = lb.DoDragDrop(lb.Items[index].ToString(), DragDropEffects.Move);
                
                
            }
        }

        private void lstthumoi_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void saoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
