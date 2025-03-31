using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace StreamReaderAndWriter
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //openFileDialog.Filter = "file txt (*.txt)|*.txt| all file (*.*)|*.*";
            //openFileDialog.FilterIndex = 1;
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    txtFilePath.Text = openFileDialog.FileName;

            //}
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


        

        private void btnB_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "file txt (*.txt)|*.txt| all file (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;

            }
        }

        private void btnReadandShow_Click(object sender, EventArgs e)
        {
            byte[] byteData = File.ReadAllBytes(txtPath.Text);
            UTF8Encoding temp = new UTF8Encoding(true);
            txtContent.Text = temp.GetString(byteData);
        }

        //btnSave
        private void button3_Click(object sender, EventArgs e)
        {
            string text = txtContent.Text;
            UTF8Encoding temp = new UTF8Encoding(true);
            byte[] byteData2 = temp.GetBytes(text);
            File.WriteAllBytes(txtPath.Text, byteData2);

        }

        private void btnSave_Load(object sender, EventArgs e)
        {

        }
    }
}
