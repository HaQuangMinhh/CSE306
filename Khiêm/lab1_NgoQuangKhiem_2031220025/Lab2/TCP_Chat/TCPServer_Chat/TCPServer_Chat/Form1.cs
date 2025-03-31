using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCPServer_Chat
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener;
        TcpClient tcpClient;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            lbContent.Items.Add("Waiting for a connection..." + Environment.NewLine);
            tcpListener = new TcpListener(IPAddress.Parse(txtIP.Text), Int32.Parse(txtPort.Text));
            Thread t = new Thread(Listen);
            tcpListener.Start();
            t.Start();
        }

        void Listen()
        {
            while (true)
            {
                tcpClient = tcpListener.AcceptTcpClient();

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
                        lbContent.Items.Add("Client: " + message + Environment.NewLine);
                    }));
                }
                tcpClient.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream ns = tcpClient.GetStream();

            string text = txtText.Text;
            lbContent.Items.Add("Sever: " + text);
            ns.Write(Encoding.UTF8.GetBytes(text), 0, Encoding.UTF8.GetBytes(text).Length);

            txtText.Clear();
        }

    }
}
