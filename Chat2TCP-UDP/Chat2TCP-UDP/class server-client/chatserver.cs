using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Chat2TCP_UDP.class_server_client
{
    public  class chatserver
    {
        private TcpListener tcpListener;
        private UdpClient udpClient;
        private bool isTcp;
        private int port;

        public chatserver(int port, bool isTcp)
        {
            this.port = port;
            this.isTcp = isTcp;
        }

        public async Task StartAsync()
        {
            if (isTcp)
            {
                tcpListener = new TcpListener(IPAddress.Any, port);
                tcpListener.Start();
                Console.WriteLine("TCP Server started on port " + port);

                while (true)
                {
                    TcpClient client = await tcpListener.AcceptTcpClientAsync();
                    HandleTcpClient(client);
                }
            }
            else
            {
                udpClient = new UdpClient(port);
                Console.WriteLine("UDP Server started on port " + port);

                while (true)
                {
                    UdpReceiveResult result = await udpClient.ReceiveAsync();
                    HandleUdpClient(result);
                }
            }
        }

        private async void HandleTcpClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received TCP message: " + message);

            
        }

        private void HandleUdpClient(UdpReceiveResult result)
        {
            string message = Encoding.UTF8.GetString(result.Buffer);
            Console.WriteLine("Received UDP message: " + message);

            
        }

        public void Stop()
        {
            if (isTcp)
            {
                tcpListener.Stop();
            }
            else
            {
                udpClient.Close();
            }
        }
    }
}
