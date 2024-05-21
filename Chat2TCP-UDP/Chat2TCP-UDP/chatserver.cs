using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
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

        private List<TcpClient> connectedClients = new List<TcpClient>();

        public Chatserver()
        {
            InitializeComponent();
        }

        private void selectTCP_CheckedChanged(object sender, EventArgs e)
        {
            if (selectTCP.Checked)
            {
                selectUDP.Checked = false;
                stopUDPserver();
                startTCPserver();
            }
        }

        private void selectUDP_CheckedChanged(object sender, EventArgs e)
        {
            if (selectUDP.Checked)
            {
                selectTCP.Checked = false;
                stopTCPserver();
                startUDPserver();
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
            tcpThread = new Thread(new ThreadStart(Tcplisten));
            tcpThread.Start();
        }

        private void Tcplisten()
        {
            listener = new TcpListener(IPAddress.Any, mainport);
            listener.Start();
            while (_listening)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    lock (connectedClients)
                    {
                        connectedClients.Add(client);
                    }
                    ThreadPool.QueueUserWorkItem(HandleTcpClient, client);
                }
                catch (SocketException ex)
                {
                    if (_listening)
                    {
                        update("Lỗi khi chấp nhận kết nối TCP: " + ex.Message);
                    }
                }
            }
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
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        string sender = clientIpAddress; // Hoặc sử dụng tên người dùng nếu có

                        update($"{sender} ({clientIpAddress}): {message}");
                        BroadcastMessageToAllClients(sender, message, client);
                    }
                }
            }
            catch (Exception e)
            {
                update("Client đã đóng kết nối: " + clientIpAddress + " - " + e.Message);
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
            update("Server đang dùng giao thức UDP ip:port: " + serverIpAddress + ":" + mainport);
            statusSV.Image = Properties.Resources.Status_Empty;
            statusSV.SizeMode = PictureBoxSizeMode.Zoom;

            _listening = true;
            udpThread = new Thread(new ThreadStart(UdpListener));
            udpThread.Start();
        }

        private void UdpListener()
        {
            udpClient = new UdpClient(mainport);
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            try
            {
                while (_listening)
                {
                    byte[] data = udpClient.Receive(ref remoteEP);
                    string message = Encoding.UTF8.GetString(data);
                    string timestampedMessage = "[" + DateTime.Now.ToString("HH:mm:ss") + "] Kết nối từ UDP: " + message;
                    update(timestampedMessage);
                    // BroadcastMessage(message);
                }
            }
            catch (Exception ex)
            {
                if (_listening)
                {
                    update("Lỗi khi nhận dữ liệu UDP: " + ex.Message);
                }
            }
            finally
            {
                udpClient.Close();
            }
        }
        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        private T Deserialize<T>(byte[] data)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(data))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (T)formatter.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine("Lỗi khi deserialize: " + ex.Message);
                return default(T);
            }
        }

        private void BroadcastMessageToAllClients(string sender, string content, TcpClient senderClient)
        {
            Message message = new Message
            {
                Sender = sender,
                Content = content,
                Timestamp = DateTime.Now
            };

            byte[] data = Serialize(message);

            lock (connectedClients)
            {
                foreach (var client in connectedClients)
                {
                    if (client != senderClient)
                    {
                        try
                        {
                            NetworkStream stream = client.GetStream();
                            stream.Write(data, 0, data.Length);
                            stream.Flush();
                        }
                        catch (Exception ex)
                        {
                            update("Lỗi gửi tin nhắn đến client: " + ex.Message);
                        }
                    }
                }
            }

            // Gửi tin nhắn đến tất cả các UDP client (nếu có)
            if (udpClient != null)
            {
                try
                {
                    udpClient.Send(data, data.Length);
                }
                catch (Exception ex)
                {
                    update("Lỗi gửi tin nhắn UDP: " + ex.Message);
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
            _listening = false;
            listener?.Stop();
            tcpThread?.Join();

            lock (connectedClients)
            {
                foreach (var client in connectedClients)
                {
                    client.Close();
                }
                connectedClients.Clear();
            }
        }

        private void stopUDPserver()
        {
            _listening = false;
            udpClient?.Close();
            udpThread?.Join();
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

        private void AddConnectedClient(string clientIdentifier)
        {
            if (!connectedClients.Exists(c => ((IPEndPoint)c.Client.RemoteEndPoint).Address.ToString() + ":" + ((IPEndPoint)c.Client.RemoteEndPoint).Port.ToString() == clientIdentifier))
            {
                UpdateConnectedIpAddresses();
            }
        }

        private void RemoveDisconnectedClient(string clientIdentifier)
        {
            UpdateConnectedIpAddresses();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lock (connectedClients)
            {
                connectedClients.Clear();
            }
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
                lock (connectedClients)
                {
                    foreach (var client in connectedClients)
                    {
                        string clientIdentifier = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString() + ":" + ((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString();
                        listipconnect.Items.Add(clientIdentifier);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_mahoa.Text == String.Empty)
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string msg = textBox_mahoa.Text;
            string strEnry = (Encrypt(msg));

            textBox_giaima.Clear();
            textBox_giaima.Text = strEnry;

        }
        private void btn_giaima_Click(object sender, EventArgs e)
        {
            if (textBox_giaima.Text == String.Empty)
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string msg1 = textBox_giaima.Text;
            string strDecry = (Decrypt(msg1));

            textBox_mahoa.Clear();
            textBox_mahoa.Text = strDecry;
        }
        public static class GlobalKey
        {
            public const String STRING_PERMUTATION = "baitapchatvamahoa";
            public const Int32 BYTE_PERMUTATION_1 = 0x19;
            public const Int32 BYTE_PERMUTATION_2 = 0x59;
            public const Int32 BYTE_PERMUTATION_3 = 0x17;
            public const Int32 BYTE_PERMUTATION_4 = 0x41;
        }
        // encoding
        public static string Encrypt(string strData)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(strData)));
        }
        // decoding
        public static string Decrypt(string strData)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(strData)));
        }

        public static byte[] Encrypt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
           new PasswordDeriveBytes(GlobalKey.STRING_PERMUTATION,
           new byte[] { GlobalKey.BYTE_PERMUTATION_1,
            GlobalKey.BYTE_PERMUTATION_2,
            GlobalKey.BYTE_PERMUTATION_3,
            GlobalKey.BYTE_PERMUTATION_4 });
            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);
            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateEncryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }
        public static byte[] Decrypt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
           new PasswordDeriveBytes(GlobalKey.STRING_PERMUTATION,
           new byte[] { GlobalKey.BYTE_PERMUTATION_1,
            GlobalKey.BYTE_PERMUTATION_2,
            GlobalKey.BYTE_PERMUTATION_3,
            GlobalKey.BYTE_PERMUTATION_4});
            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);
            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateDecryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_mahoa.Clear();
            textBox_giaima.Clear();
        }
    }
}
