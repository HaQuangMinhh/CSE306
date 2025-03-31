using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.Net.Http;
using System.Xml.Linq;


namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseandSend_Click(object sender, EventArgs e)
        {
            //txtPath.Clear();
            //open file
            openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg; *.png|Text Files (*.txt)|*.txt| All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;

            }

            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 31000);
            
            NetworkStream ns = tcpClient.GetStream();


            //read file to byte[]
            byte[] byteData = File.ReadAllBytes(txtPath.Text);
           
            ns.Write(byteData, 0,byteData.Length);
            ns.Close();
            tcpClient.Close();

        }
    }
}
