using System;
using System.Drawing;
using System.Windows.Forms;
using Chat2TCP_UDP.class_server_client;
using System.Threading.Tasks;

namespace Chat2TCP_UDP.form
{
    public partial class Form_createroom : Form
    {
        public Form_createroom()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lbRoomName = new Label();
            this.tbRoomName = new TextBox();
            this.lbProtocol = new Label();
            this.cbProtocol = new ComboBox();
            this.lbEncryption = new Label();
            this.cbEncryption = new ComboBox();
            this.btnCreate = new Button();

            // Room Name Label
            this.lbRoomName.Text = "Tên Phòng:";
            this.lbRoomName.Location = new Point(10, 10);
            this.Controls.Add(this.lbRoomName);

            // Room Name TextBox
            this.tbRoomName.Location = new Point(120, 10);
            this.Controls.Add(this.tbRoomName);

            // Protocol Label
            this.lbProtocol.Text = "Phương Thức:";
            this.lbProtocol.Location = new Point(10, 40);
            this.Controls.Add(this.lbProtocol);

            // Protocol ComboBox
            this.cbProtocol.Items.AddRange(new object[] { "TCP", "UDP" });
            this.cbProtocol.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbProtocol.Location = new Point(120, 40);
            this.Controls.Add(this.cbProtocol);

            // Encryption Label
            this.lbEncryption.Text = "Mã Hóa:";
            this.lbEncryption.Location = new Point(10, 70);
            this.Controls.Add(this.lbEncryption);

            // Encryption ComboBox
            this.cbEncryption.Items.AddRange(new object[] { "AES", "RSA" });
            this.cbEncryption.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbEncryption.Location = new Point(120, 70);
            this.Controls.Add(this.cbEncryption);

            // Create Button
            this.btnCreate.Text = "Tạo Phòng";
            this.btnCreate.Location = new Point(120, 100);
            this.btnCreate.Click += new EventHandler(this.BtnCreate_Click);
            this.Controls.Add(this.btnCreate);

            // Form Create Room
            this.ClientSize = new Size(300, 150);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Tạo Phòng";
        }

        private Chatserver chatServer;

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string roomName = tbRoomName.Text;
            string protocol = cbProtocol.SelectedItem.ToString();
            string encryption = cbEncryption.SelectedItem.ToString();

            bool isTcp = protocol == "TCP";
            int port = 12345; // You can allow user to set this too

            chatServer = new Chatserver(port, isTcp);
            Task.Run(() => chatServer.StartAsync());

            MessageBox.Show("Phòng đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private Label lbRoomName;
        private TextBox tbRoomName;
        private Label lbProtocol;
        private ComboBox cbProtocol;
        private Label lbEncryption;
        private ComboBox cbEncryption;
        private Button btnCreate;
    }
}
