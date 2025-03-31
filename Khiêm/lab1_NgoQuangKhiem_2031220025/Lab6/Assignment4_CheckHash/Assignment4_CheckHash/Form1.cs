using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_CheckHash
{
    public partial class Form1 : Form
    {
        //byte[] hashedData;
        //byte[] hashedDataMD5;
        //StringBuilder sb = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
            }



            byte[] hashedDataSHA1;
            using (SHA1 sha1 = SHA1.Create())
            {
                hashedDataSHA1 = sha1.ComputeHash(File.ReadAllBytes(txtPath.Text));
            }

            StringBuilder sbSHA1 = new StringBuilder();
            foreach (byte b in hashedDataSHA1)
            {
                sbSHA1.Append(b.ToString("x2"));
            }
            //for (int i = 0; i < hashedDataSHA1.Length; i++)
            //{
            //    sbSHA1.Append(hashedDataSHA1[i].ToString("x2"));
            //}
            txtSHA1.Text = sbSHA1.ToString();




            byte[] hashedDataMD5;
            using (MD5 md5 = MD5.Create())
            {
                hashedDataMD5 = md5.ComputeHash(File.ReadAllBytes(txtPath.Text));
            }

            StringBuilder sbMD5 = new StringBuilder();
            foreach (byte b in hashedDataMD5)
            {
                sbMD5.Append(b.ToString("x2"));
            }
            //for (int i = 0; i < hashedDataMD5.Length; i++)
            //{
            //    sbMD5.Append(hashedDataMD5[i].ToString("x2"));
            //}
            txtMD5.Text = sbMD5.ToString().ToUpper();

        }

        private void btnCompapre_Click(object sender, EventArgs e)
        {

            if (txtCompareHash.Text == txtMD5.Text)
            {
                MessageBox.Show("Hashes math!", "Integrity Check"); //tbao + tên bảng tb
            }
            else
            {
                MessageBox.Show("IT DOESN'T MATCH HONEY!!", "Integrity Check");
            }
        }
    }
}
