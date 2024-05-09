using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Chat2TCP_UDP
{
    public partial class Chatserver : MetroForm
    {
        private TcpListener listener;
        private UdpClient udpClient;
        private bool _listening;
        private const int mainport = 2002;
        private Thread tcpThread;
        private Thread udpThread;
        private bool accpectconnect = true;

        private Dictionary<string, string> clientIpAddresses = new Dictionary<string, string>();

        public Chatserver()
        {
            InitializeComponent();
        }

        private void selectTCP_CheckedChanged(object sender, EventArgs e)
        {
            if (selectTCP.Checked)
            {
                selectUDP.Checked = false;
            }
        }

        private void selectUDP_CheckedChanged(object sender, EventArgs e)
        {
            if (selectUDP.Checked)
            {
                selectTCP.Checked = false;
            }
        }

        public static string GetLocalIpAddress()
        {
            string hostName = Dns.GetHostName();
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);

            foreach (IPAddress address in addresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    return address.ToString();
                }
            }
            return "Không tìm thấy địa chỉ IPv4";
        }

        private void startTCPserver()
        {
            string serverIpAddress = GetLocalIpAddress();
            textBox1.Text = serverIpAddress;
            update("Server đang dùng giao thức TCP ip:port : " + serverIpAddress + ":" + mainport);
            statusSV.Image = Properties.Resources.Status_Empty;
            statusSV.SizeMode = PictureBoxSizeMode.Zoom;

            _listening = true;
            Tcplisten();
        }

        private void Tcplisten()
        {
            listener = new TcpListener(IPAddress.Any, mainport);
            listener.Start();
            listener.BeginAcceptTcpClient(new AsyncCallback(AcceptTcpClientCallback), listener);
        }

        private void AcceptTcpClientCallback(IAsyncResult asyncResult)
        {
            TcpListener tcpListener = (TcpListener)asyncResult.AsyncState;

            try
            {
                TcpClient client = tcpListener.EndAcceptTcpClient(asyncResult);
                ThreadPool.QueueUserWorkItem(HandleTcpClient, client);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                update("Lỗi khi chấp nhận kết nối TCP: " + ex.Message);
            }

            // Tiếp tục lắng nghe kết nối mới
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(AcceptTcpClientCallback), tcpListener);
        }





        private void HandleTcpClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[4096];
            int bytesRead;
            string clientIpAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

            try
            {
                while (client.Connected)
                {
                    AddConnectedClient(clientIpAddress);
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        update(" (" + clientIpAddress + "): " + message);
                        BroadcastMessageToAllClients(message, client);
                    }
                }
            }
            catch (Exception e)
            {
                update("client đã đóng kết nối:" + clientIpAddress + ":" + e.Message);
                RemoveDisconnectedClient(clientIpAddress);
            }
            finally
            {
                client.Close();
            }
        }

        private void startUDPserver()
        {
            string serverIpAddress = GetLocalIpAddress();
            textBox1.Text = serverIpAddress;
            update("Server đang dùng giao thức UDP ip:port:" + serverIpAddress + ":" + mainport);
            statusSV.Image = Properties.Resources.Status_Empty;
            statusSV.SizeMode = PictureBoxSizeMode.Zoom;

            udpThread = new Thread(new ThreadStart(UdpListener));
            udpThread.Start();
        }

        private void UdpListener()
        {
            udpClient = new UdpClient(mainport);
            IPEndPoint remoteEP = null;

            try
            {
                while (_listening)
                {
                    byte[] data = udpClient.Receive(ref remoteEP);
                    string message = Encoding.UTF8.GetString(data);
                    update("Kết nối từ UDP: " + message);
                    //BroadcastMessage(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                udpClient.Close();
            }
        }

        private void BroadcastMessageToAllClients(string message, TcpClient senderClient)
        {
            foreach (var kvp in clientIpAddresses)
            {
                string clientName = kvp.Key;
                string clientIpAddress = kvp.Value;

                // Kiểm tra xem client có phải là senderClient không
                if (clientIpAddress != ((IPEndPoint)senderClient.Client.RemoteEndPoint).Address.ToString())
                {
                    try
                    {
                        TcpClient client = new TcpClient(clientIpAddress, mainport);
                        NetworkStream stream = client.GetStream();
                        byte[] buffer = Encoding.UTF8.GetBytes(message);
                        stream.Write(buffer, 0, buffer.Length);
                        stream.Flush();
                        client.Close();
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi khi gửi tin nhắn đến client
                        update("Lỗi gửi tin nhắn đến client: " + ex.Message);
                    }
                }
            }
        }

        private void modebg_CheckedChanged_1(object sender, EventArgs e)
        {
            if (modebg.Checked)
            {
                if (selectTCP.Checked)
                {
                    startTCPserver();
                }
                else if (selectUDP.Checked)
                {
                    stopTCPserver();
                    startUDPserver();
                }
            }
            else
            {
                stopsv();
                statusSV.Image = Properties.Resources.Status_Repair;
                statusSV.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void stopTCPserver()
        {
            accpectconnect = false;

            if (listener != null && listener.Server.IsBound)
            {
                listener.Stop();
            }
        }
        private void stopUDPserver()
        {
            udpClient?.Close();
        }
        private void stopsv()
        {
            stopTCPserver();
            stopUDPserver();
        }

        private void update(string message)
        {   
            if (listmessage.InvokeRequired)
            {
                listmessage.Invoke((MethodInvoker)delegate { update(message); });
            }
            else
            {
                listmessage.Items.Add(message);
            }
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopsv();
        }

        private void logofb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/anhhackta.official");
        }


        private void AddConnectedClient(string clientName)
        {
            if (!clientIpAddresses.ContainsKey(clientName))
            {
                string clientIpAddress = ((IPEndPoint)listener.LocalEndpoint).Address.ToString();
                clientIpAddresses.Add(clientName, clientIpAddress);
                UpdateConnectedIpAddresses();
            }
        }
        private void RemoveDisconnectedClient(string clientName)
        {
            if (clientIpAddresses.ContainsKey(clientName))
            {
                clientIpAddresses.Remove(clientName);
                UpdateConnectedIpAddresses();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clientIpAddresses.Clear();
            UpdateConnectedIpAddresses();
        }

        private void UpdateConnectedIpAddresses()
        {
            if (listipconnect.InvokeRequired)
            {
                listipconnect.Invoke((MethodInvoker)delegate { UpdateConnectedIpAddresses(); });
            }
            else
            {
                listipconnect.Items.Clear();
                foreach (var vkp in clientIpAddresses)
                {
                    listipconnect.Items.Add(vkp.Key + " - " + vkp.Value);
                }
            }
        }

    }
}
