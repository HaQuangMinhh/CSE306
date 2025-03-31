using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        HttpListener listener = new HttpListener();
        WebSocket socket;



        public Form1()
        {
            InitializeComponent();

        }


      
        private async Task ProcessWebSocketRequest(HttpListenerContext context)
        {
            HttpListenerWebSocketContext webSocketContext = await context.AcceptWebSocketAsync(null);
            socket = webSocketContext.WebSocket;

            // Handle incoming messages
            byte[] buffer = new byte[1024];
            while (socket.State == WebSocketState.Open)
            {
                WebSocketReceiveResult result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Text)
                {
                    string receivedMessage = System.Text.Encoding.UTF8.GetString(buffer, 0, result.Count);

                    lbContent.Items.Add($"Received message: {receivedMessage}" + Environment.NewLine);

                   
                }
                else if (result.MessageType == WebSocketMessageType.Close)
                {
                    await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);

                }
            }            
        }
        private async void btnSend_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text); //rep từ server
            await socket.SendAsync(new ArraySegment<byte>(data, 0, data.Length), WebSocketMessageType.Text, true, CancellationToken.None);
            lbContent.Items.Add($"Sent message: {txtMessage.Text}" + Environment.NewLine);
            txtMessage.Clear();
        }

        private async void btnListen_Click_1(object sender, EventArgs e)
        {
            listener.Prefixes.Add($"http://{txtIP.Text}:{txtPort.Text}/");
            listener.Start();
            lbContent.Items.Add("Server started. Waiting for connections..." + Environment.NewLine);
            

            while (true)
            {
                HttpListenerContext context = await listener.GetContextAsync();
                if (context.Request.IsWebSocketRequest)
                {
                    await ProcessWebSocketRequest(context);
                }
                else
                {
                    context.Response.StatusCode = 400;
                    context.Response.Close();
                }
            }

        }
    }
}
