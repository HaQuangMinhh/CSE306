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

namespace FileStreamandEncoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "file txt (*.txt)|*.txt| all file (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;

            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(txtPath.Text, FileMode.Open))
            {
                UTF8Encoding temp = new UTF8Encoding(true);
                UnicodeEncoding temp2 = new UnicodeEncoding();

                int lenght = 0;
                byte[]readData = new byte[1024];
                while ((lenght = fs.Read(readData, 0, readData.Length)) > 0)
                {
                    if (rbUTF8.Checked)
                    {
                        txtContent.Text = temp.GetString(readData);
                    } 
                    else
                    {
                        txtContent.Text = temp2.GetString(readData);
                    }    
                }    
            }                       
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = File.OpenWrite(txtPath.Text);
                string text = txtContent.Text;
                UTF8Encoding temp = new UTF8Encoding(true);
                UnicodeEncoding temp2 = new UnicodeEncoding();

                if (rbUTF8.Checked)
                {
                    byte[] byteData = temp.GetBytes(text);
                    fs.Write(byteData, 0, byteData.Length);
                }
                else
                {
                    byte[] byteData = temp2.GetBytes(text);
                    fs.Write(byteData, 0, byteData.Length);
                }

            }
            catch (Exception ex) { }
            MessageBox.Show("Save Successful");
        }
    }
}
