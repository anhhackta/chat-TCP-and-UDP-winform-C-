using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat2TCP_UDP.class_server_client
{
    public class chatclient
    {
        private TcpClient tcpClient;
        private UdpClient udpClient;
        private bool isTcp;
        private string ipAddress;
        private int port;

        public chatclient(string ipAddress, int port, bool isTcp)
        {
            this.ipAddress = ipAddress;
            this.port = port;
            this.isTcp = isTcp;
        }

        public async Task ConnectAsync()
        {
            if (isTcp)
            {
                tcpClient = new TcpClient();
                await tcpClient.ConnectAsync(ipAddress, port);
                Console.WriteLine("Connected to TCP server");

                // Start listening for incoming messages
                Task.Run(() => ListenForTcpMessages());
            }
            else
            {
                udpClient = new UdpClient();
                Console.WriteLine("Connected to UDP server");

                // Start listening for incoming messages
                Task.Run(() => ListenForUdpMessages());
            }
        }

        private async void ListenForTcpMessages()
        {
            NetworkStream stream = tcpClient.GetStream();
            byte[] buffer = new byte[1024];

            while (true)
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received TCP message: " + message);
            }
        }

        private async void ListenForUdpMessages()
        {
            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();
                string message = Encoding.UTF8.GetString(result.Buffer);
                Console.WriteLine("Received UDP message: " + message);
            }
        }

        public async Task SendMessageAsync(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            if (isTcp)
            {
                NetworkStream stream = tcpClient.GetStream();
                await stream.WriteAsync(buffer, 0, buffer.Length);
            }
            else
            {
                await udpClient.SendAsync(buffer, buffer.Length, ipAddress, port);
            }
        }

        public void Disconnect()
        {
            if (isTcp)
            {
                tcpClient.Close();
            }
            else
            {
                udpClient.Close();
            }
        }
    }
}
