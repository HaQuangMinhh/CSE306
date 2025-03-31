using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_RSA
{
    public partial class Form1 : Form
    {
        

        private RSACryptoServiceProvider rsa;

        public Form1()
        {
            InitializeComponent();
            // Tạo cặp khóa RSA (Công khai và Riêng)
            rsa = new RSACryptoServiceProvider(2048); // Sử dụng cặp khóa 2048 bit
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = txtInput.Text;
            byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plainText);

            // Mã hóa 
            byte[] encryptedData;
            encryptedData = rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.Pkcs1);

            // Chuyển dữ liệu mã hóa thành chuỗi 
            string encryptedText = Convert.ToBase64String(encryptedData);
            txtEncrypt.Text = encryptedText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = txtEncrypt.Text;
            byte[] encryptedData = Convert.FromBase64String(encryptedText);

            // Giải mã
            byte[] decryptedData;
            decryptedData = rsa.Decrypt(encryptedData, RSAEncryptionPadding.Pkcs1);

            // Chuyển dữ liệu giải mã thành chuỗi
            string decryptedText = Encoding.UTF8.GetString(decryptedData);
            txtDecrypt.Text = decryptedText;
        }

    }
}