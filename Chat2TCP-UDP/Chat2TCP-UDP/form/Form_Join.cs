// Form_Join.cs
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Point;
using Chat2TCP_UDP.class_server_client;
using System.Threading.Tasks;
namespace Chat2TCP_UDP.form
{
    public partial class Form_Join : Form
    {
        public Form_Join()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lbIpAddress = new Label();
            this.tbIpAddress = new TextBox();
            this.lbPort = new Label();
            this.tbPort = new TextBox();
            this.btnJoin = new Button();

            // IP Address Label
            this.lbIpAddress.Text = "Địa chỉ IP:";
            this.lbIpAddress.Location = new Point(10, 10);
            this.Controls.Add(this.lbIpAddress);

            // IP Address TextBox
            this.tbIpAddress.Location = new Point(120, 10);
            this.Controls.Add(this.tbIpAddress);

            // Port Label
            this.lbPort.Text = "Port:";
            this.lbPort.Location = new Point(10, 40);
            this.Controls.Add(this.lbPort);

            // Port TextBox
            this.tbPort.Location = new Point(120, 40);
            this.Controls.Add(this.tbPort);

            // Join Button
            this.btnJoin.Text = "Tham Gia";
            this.btnJoin.Location = new Point(120, 70);
            this.btnJoin.Click += new EventHandler(this.BtnJoin_Click);
            this.Controls.Add(this.btnJoin);

            // Form Join
            this.ClientSize = new Size(300, 110);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Tham Gia Phòng";
        }
        private chatclient chatClient;
        private void BtnJoin_Click(object sender, EventArgs e)
        {
            string ipAddress = tbIpAddress.Text;
            int port = int.Parse(tbPort.Text);
            bool isTcp = true; // Determine this based on some user input or predefined setting

            chatClient = new chatclient(ipAddress, port, isTcp);
            Task.Run(() => chatClient.ConnectAsync());

            MessageBox.Show("Đã tham gia phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private Label lbIpAddress;
        private TextBox tbIpAddress;
        private Label lbPort;
        private TextBox tbPort;
        private Button btnJoin;
    }
}
