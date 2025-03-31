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

namespace Assignment1_AES
{
    public partial class Form1 : Form
    {
        byte[] key;
        byte[] iv;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Encrypted using AES
            using (Aes aes = Aes.Create())
            {
                key = aes.Key; 
                iv = aes.IV;  

                // Mã hóa và lưu vào file
                using (FileStream fStream = File.Open("encrypted.txt", FileMode.Create))
                using (ICryptoTransform encryptor = aes.CreateEncryptor(key, iv))
                using (CryptoStream cStream = new CryptoStream(fStream, encryptor, CryptoStreamMode.Write))
                {
                    byte[] toEncrypt = Encoding.UTF8.GetBytes(txtInput.Text);
                    cStream.Write(toEncrypt, 0, toEncrypt.Length);  
      
                }

                // Đọc lại dữ liệu đã mã hóa từ file
                byte[] encryptedData;
                using (FileStream fStreamRead = File.Open("encrypted.txt", FileMode.Open))
                {
                    encryptedData = new byte[fStreamRead.Length];
                    fStreamRead.Read(encryptedData, 0, encryptedData.Length);
                }

                // Chuyển dữ liệu mã hóa thành chuỗi Base64 để hiển thị
                string encryptedText = Convert.ToBase64String(encryptedData);
                txtEncrypt.Text = encryptedText;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = txtEncrypt.Text;
            byte[] encryptedData = Convert.FromBase64String(encryptedText);
            string txt = null;
            // Decrypt using AES
            using (MemoryStream msDecrypt = new MemoryStream(encryptedData)) 
            using (Aes aes = Aes.Create())
            using (ICryptoTransform decryptor = aes.CreateDecryptor(key, iv))
            using (var cStream = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            using (StreamReader reader = new StreamReader(cStream, Encoding.UTF8))
            {
                txtDecrypt.Text = reader.ReadToEnd(); // Đọc và hiển thị nội dung đã giải mã
            }
            
        }
    }
}