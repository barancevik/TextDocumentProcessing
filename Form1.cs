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



namespace Text_Document_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamWriter sw;
        string documentname, documentpath;

        private void btnSave_Click(object sender, EventArgs e)
        {
            documentname = txtdocumentname.Text;
            sw = File.CreateText(documentpath + "\\" + documentname + ".txt");
            sw.Close();
            MessageBox.Show("Document created");

        }

        private void btnImportthelist_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                string line = read.ReadLine();
                while(line!=null)
                {
                    listBox1.Items.Add(line);
                    line = read.ReadLine();
                }

            }
        }

        private void btnSavedata_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
           
            

            try
            {
                saveFileDialog1.Title = "Select the path to save";
                saveFileDialog1.Filter = "Text Document (*.txt) | *.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter save = new StreamWriter(saveFileDialog1.FileName);
                save.WriteLine(richTextBox1.Text);
                save.Close();
                MessageBox.Show("The source was printed in a text document");



            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void btnchooceapath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                documentpath = folderBrowserDialog1.SelectedPath.ToString();
                txtdocumentpath.Text = documentpath.ToString();
            }
        }




    }
}
