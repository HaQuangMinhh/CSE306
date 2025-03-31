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

namespace Assignment2_AES
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


            //Encryted
            using (TripleDES tripleDes = TripleDES.Create())
            {
                key = tripleDes.Key;
                iv = tripleDes.IV;

                //vì dùng filesteam nên bắt buộc phải tạo file

                //mã hóa
                using (FileStream fStream = File.Open("encrypted.txt", FileMode.Create))
                using (ICryptoTransform encryptor = tripleDes.CreateEncryptor(key, iv))
                using (var cStream = new CryptoStream(fStream, encryptor, CryptoStreamMode.Write))
                {
                    // Chuyển chuỗi nhập sang mảng byte
                    byte[] toEncrypt = Encoding.UTF8.GetBytes(txtInput.Text); //byte này chưa dc mã hóa

                    cStream.Write(toEncrypt, 0, toEncrypt.Length); //phải ghi dữ liệu thì hàm giải mới đọc và giải dc
                    cStream.Close();
                    
                }

                // Đọc lại nội dung đã mã hóa từ file để hiển thị
                byte[] encryptedData;
                using (FileStream fStreamRead = File.Open("encrypted.txt", FileMode.Open))
                {
                    encryptedData = new byte[fStreamRead.Length];
                    fStreamRead.Read(encryptedData, 0, encryptedData.Length);
                }

                // Chuyển dữ liệu mã hóa sang b64 
                string encryptedText = Convert.ToBase64String(encryptedData);
                txtEncrypt.Text = encryptedText;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //string decryptedText;
            using (FileStream fs = new FileStream("encrypted.txt", FileMode.Open, FileAccess.Read))
            using (TripleDES tripleDes = TripleDES.Create())
            using (ICryptoTransform decryptor = tripleDes.CreateDecryptor(key, iv))
            using (var cStream = new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
            using (StreamReader reader = new StreamReader(cStream, Encoding.UTF8))
            {
                txtDecrypt.Text = reader.ReadToEnd();
            }
       
        }
    }
}
