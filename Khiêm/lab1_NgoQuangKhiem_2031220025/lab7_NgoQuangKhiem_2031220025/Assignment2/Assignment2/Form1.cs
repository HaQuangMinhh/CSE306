using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "zip";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ZipFile.CreateFromDirectory(txtFolderPath.Text, saveFileDialog.FileName);
                MessageBox.Show("Done!");
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Zip files (*zip;*gz)|*.zip;*.gz | All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)     
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            //string destinationFolder = folderBrowserDialog.SelectedPath;
            //string sourceFilePath = txtFilePath.Text;
            //if (Path.GetExtension(sourceFilePath) == ".zip")
            //{
            //    ZipFile.ExtractToDirectory(sourceFilePath, destinationFolder);
            //    MessageBox.Show("Done!");
            //}

            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                ZipFile.ExtractToDirectory(txtFilePath.Text, folderBrowserDialog.SelectedPath);
                MessageBox.Show("Done!");
            }
        }
    }
}
