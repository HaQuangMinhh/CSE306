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

namespace Assignmnet3_SHA256
{
    public partial class Form1 : Form
    {
        List<string> listBoxItems = new List<string>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(txtPassword.Text);
            byte[] hashedData;


            using (SHA256 sHA256 = SHA256.Create())
            {
                hashedData = sHA256.ComputeHash(data);
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hashedData.Length; i++)
            {
                stringBuilder.Append(hashedData[i].ToString("x2"));
            }
            //đầu tiên sẽ xóa hết lb
            lbHashList.Items.Clear();
            //add sb mới vào list
            listBoxItems.Add(stringBuilder.ToString());
            //in từng item trong list ra
            foreach (var item in listBoxItems)
            {
                lbHashList.Items.Add(item);
            }
   
            txtPassword.Clear();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(txtKeyword.Text);
            byte[] hashedData;

            using (SHA256 sHA256 = SHA256.Create())
            {
                hashedData = sHA256.ComputeHash(data);
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hashedData.Length; i++)
            {
                stringBuilder.Append(hashedData[i].ToString("x2"));
            }
            for(int i = 0;i < listBoxItems.Count; i++)
            {
                if (listBoxItems[i].ToString() == stringBuilder.ToString())
                {
                    lbHashList.Items.Clear();
                    lbHashList.Items.Add(stringBuilder.ToString());

                }
                
            }
            txtKeyword.Clear();
        }
    }
}
