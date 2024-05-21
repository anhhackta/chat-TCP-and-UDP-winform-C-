using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
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
                SendMessage(clientName);
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

        private byte[] Serialize(object obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                return stream.ToArray();
            }
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
                Console.WriteLine("Lỗi khi deserialize: " + ex.Message);
                return default(T);
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
                    if (udpClient != null) // 
                    {
                        udpClient.Send(data, data.Length);
                    }
                    else
                    {
                        UpdateMessage("UDP client chưa được khởi tạo.");
                    }
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

                    // Gửi thông báo cho server biết client đã đóng kết nối
                    SendMessage("Client đã đóng kết nối");
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
                UpdateMessage("Lỗi trong lúc disconnect " + ex.Message);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_mahoa.Text == String.Empty)
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string msg = tb_mahoa.Text;
            string strEnry = (Encrypt(msg));

            tb_giaima.Clear();
            tb_giaima.Text = strEnry;

        }
        private void btn_giaima_Click(object sender, EventArgs e)
        {
            if (tb_giaima.Text == String.Empty)
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string msg1 = tb_giaima.Text;
            string strDecry = (Decrypt(msg1));

            tb_mahoa.Clear();
            tb_mahoa.Text = strDecry;
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
            tb_mahoa.Clear();
            tb_giaima.Clear();
        }
    }
}
