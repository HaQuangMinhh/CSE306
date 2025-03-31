using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //File 
            TcpListener fileSever = new TcpListener(IPAddress.Any, 31000);
            fileSever.Start();

            Thread fileThread = new Thread(ListenFile);
            fileThread.Start(fileSever);
        }

        void ListenFile(object _server)
        {
            TcpListener server = (TcpListener)_server;
            byte[] buffer = new byte[1024];
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream ns = client.GetStream();
                string fileName = @".\" + DateTime.Now.ToString("yyyyddMM-HHmmss") + ".txt";
                Stream fileStream = File.OpenWrite(fileName);
                byte[] dtByte = new byte[1024];
                int blockSize = 1024;
                int thisRead;
                while ((thisRead = ns.Read(dtByte, 0, blockSize)) != 0)
                {
                    fileStream.Write(dtByte, 0, thisRead);
                }
                fileStream.Close();
                txtContents.Invoke(new Action(() =>
                {
                    txtContents.AppendText("\r\nReceived an image: " + DateTime.Now.ToString("yyyyddMM-HHmmss") + ".jpg");

                }));
                ns.Close();
                client.Close();
            }
        }
    }
}
