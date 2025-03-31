using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Assignmnet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void btnChooseList_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg; *.png|Text Files (*.txt)|*.txt| All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //filePath = openFileDialog.FileName;
                txtEmailTo.Text = openFileDialog.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkCredential myCredential = new NetworkCredential(txtUsername.Text, txtPass.Text);

            SmtpClient client = new SmtpClient();
            client.Host = txtGmail.Text;
            client.Port = Int32.Parse( txtPort.Text);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = myCredential;

            //MailAddress from = new MailAddress(txtEmailFrom.Text, "Khiem");
            //MailAddress to = new MailAddress("khiemkhanhkhai@gmail.com"); //chưa

            MailMessage message = new MailMessage();
            message.From = new MailAddress(txtEmailFrom.Text);
            foreach (string email in File.ReadAllLines(txtEmailTo.Text)) 
            { 
                message.To.Add(new MailAddress(email));
            
            }
         

            message.Subject = txtTitle.Text;
            message.Body = txtMess.Text;

            client.Send(message);
            message.Dispose();
            MessageBox.Show("Sent");
            //Console.WriteLine("Done");
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Net.Mail;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Threading;
//using System.IO;

//namespace Assigment_2
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void btnSend_Click(object sender, EventArgs e)
//        {
//            NetworkCredential myCredential = new NetworkCredential(txtUsername.Text, txtPassword.Text);

//            SmtpClient client = new SmtpClient();
//            client.Host = txtGmail.Text;
//            client.Port = Int32.Parse(txtPort.Text);

//            client.EnableSsl = true;
//            client.UseDefaultCredentials = false;
//            client.Credentials = myCredential;

//            MailMessage message = new MailMessage();

//            message.From = new MailAddress(txtEmailFrom.Text);

//            foreach (string email in File.ReadAllLines(txtEmailTo.Text))
//            {
//                message.To.Add(new MailAddress(email));
//            };
//            message.Subject = txtTitle.Text;
//            message.Body = txtMessage.Text;
//            client.Send(message);
//            message.Dispose();
//            MessageBox.Show("Sent!");
//        }

//        private void btnChooseList_Click(object sender, EventArgs e)
//        {
//            openFileDialog.Filter = "files txt(*.txt)|*.txt| All files(*.*)|*.*";
//            if (openFileDialog.ShowDialog() == DialogResult.OK)
//            {
//                txtEmailTo.Text = openFileDialog.FileName;
//            }
//        }

//        private void btnChooseFile_Click(object sender, EventArgs e)
//        {
//            openFileDialog.Filter = "files txt(*.txt)|*.txt| All files(*.*)|*.*";
//            if (openFileDialog.ShowDialog() == DialogResult.OK)
//            {
//                txtEmailTo.Text = openFileDialog.FileName;
//            }
//        }
//    }
//}
