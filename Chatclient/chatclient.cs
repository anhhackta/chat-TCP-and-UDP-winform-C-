using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Chatclient
{
    public partial class login : MetroFramework.Forms.MetroForm
    {
        private TcpClient tcpClient;
        private UdpClient udpClient;
        private NetworkStream tcpStream;
        private Thread receiveThread;
        private string serverIp;
        private int serverPort;
        private bool isTcpConnected = false;

        public login()
        {
            InitializeComponent();
        }

        private void ConnectToServer(string clientName)
        {
            try
            {
                
                tcpClient = new TcpClient(serverIp, serverPort);
                tcpStream = tcpClient.GetStream();
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
                UpdateMessage("Kết nối bằng giao thức TCP.");
                statussv.Image = Properties.Resources.Status_Empty;
                statussv.SizeMode = PictureBoxSizeMode.Zoom;
                isTcpConnected = true;
            }
            catch (Exception)
            {
                try
                {
                    
                    udpClient = new UdpClient();
                    udpClient.Connect(serverIp, serverPort);
                    UpdateMessage("Kết nối bằng giao thức UDP.");
                    statussv.Image = Properties.Resources.Status_Empty;
                    statussv.SizeMode = PictureBoxSizeMode.Zoom;
                    isTcpConnected = false;
                }
                catch (Exception ex)
                {
                    UpdateMessage("Lỗi kết nối server: " + ex.Message);
                }
            }
        }

        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead = tcpStream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        UpdateMessage(message);
                    }
                }
            }
            catch (Exception ex)
            {
                UpdateMessage("lỗi tin nhắn nhận: " + ex.Message);
            }
        }

        private void SendMessage(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                if (isTcpConnected)
                {
                    tcpStream.Write(data, 0, data.Length);
                }
                else
                {
                    udpClient.Send(data, data.Length);
                }
            }
            catch (Exception ex)
            {
                UpdateMessage("Lỗi tin nhắn: " + ex.Message);
            }
        }

        private void UpdateMessage(string message)
        {
            if (listmess.InvokeRequired)
            {
                listmess.Invoke((MethodInvoker)delegate { UpdateMessage(message); });
            }
            else
            {
                listmess.Items.Add(message);
            }
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entername.Text) || string.IsNullOrWhiteSpace(boxipport.Text))
            {
                MessageBox.Show("Vui lòng nhập Ip:port đã tính tiếp.");
                return;
            }

            string clientName = entername.Text;
            string ipAndPort = boxipport.Text;
            string[] parts = ipAndPort.Split(':');

            if (parts.Length != 2)
            {
                MessageBox.Show("Vui lòng nhập Ip:port cho đúng");
                return;
            }

            serverIp = parts[0];
            if (!int.TryParse(parts[1], out serverPort) || serverPort <= 0)
            {
                MessageBox.Show("Vui lòng nhập cổng hợp lệ (mặc định port 2002)");
                return;
            }

            ConnectToServer(clientName);
        }

        private void entersend_Click(object sender, EventArgs e)
        {
            string message = boxmess.Text;
            string clientName = entername.Text;

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("hãy gõ tin nhắn rồi nhấp gửi đi fen");
                return;
            }

            SendMessage(clientName + ": " + message);
            UpdateMessage(clientName + ": " + message);
        }

        private void btndis_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void Disconnect()
        {
            try
            {
                if (tcpClient != null)
                {
                    tcpClient.Close();
                    statussv.Image = Properties.Resources.Status_Repair;
                    statussv.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (udpClient != null)
                {
                    udpClient.Close();
                    statussv.Image = Properties.Resources.Status_Repair;
                    statussv.SizeMode = PictureBoxSizeMode.Zoom;
                }
                UpdateMessage("Đã ngắt kết nối server");
            }
            catch (Exception ex)
            {
                UpdateMessage("lỗi trong lúc disconnect " + ex.Message);
            }
        }

        private void entersend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                entersend_Click(sender, e);
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }
    }
}
