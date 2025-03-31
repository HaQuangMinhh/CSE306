using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient_Chat
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient;
        //StreamReader reader;
        //StreamWriter writer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient(txtIP.Text, Int32.Parse(txtPort.Text));

            Thread connect = new Thread(Connetion);
            connect.Start();

        }
        private void Connetion()
        {
            while (true)
            {
                //tcpClient = tcpServer.AcceptTcpClient();

                lbContent.Invoke(new Action(() =>
                {
                    lbContent.Items.Add("Connected!" + Environment.NewLine);
                }));

                NetworkStream ns = tcpClient.GetStream(); // khởi tạo luôn

                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                String message;

                while ((bytesRead = ns.Read(buffer, 0, buffer.Length)) != 0)
                {
                    message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    lbContent.Invoke(new Action(() =>
                    {
                        lbContent.Items.Add("Server: " + message + Environment.NewLine);
                    }));
                }
                tcpClient.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream ns = tcpClient.GetStream();

            string text = txtText.Text;
            lbContent.Items.Add("Client: " + text);
            ns.Write(Encoding.UTF8.GetBytes(text), 0, Encoding.UTF8.GetBytes(text).Length);

            txtText.Clear();
        
        }
    }
}
