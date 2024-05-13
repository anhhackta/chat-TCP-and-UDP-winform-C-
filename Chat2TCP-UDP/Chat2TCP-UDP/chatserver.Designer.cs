namespace Chat2TCP_UDP
{
    partial class Chatserver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modebg = new MetroFramework.Controls.MetroToggle();
            this.pnbuttonip = new MetroFramework.Controls.MetroPanel();
            this.btn_encrypt = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectUDP = new System.Windows.Forms.RadioButton();
            this.selectTCP = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logofb = new System.Windows.Forms.Button();
            this.statusSV = new System.Windows.Forms.PictureBox();
            this.pnmess = new MetroFramework.Controls.MetroPanel();
            this.panel_showmess = new System.Windows.Forms.Panel();
            this.messchat = new MetroFramework.Controls.MetroLabel();
            this.listmessage = new System.Windows.Forms.ListView();
            this.pannel_chatsv = new System.Windows.Forms.Panel();
            this.tb_sendsv = new System.Windows.Forms.TextBox();
            this.pn_ip = new MetroFramework.Controls.MetroPanel();
            this.btnResetIp = new System.Windows.Forms.Button();
            this.listipconnect = new System.Windows.Forms.ListBox();
            this.ListIP = new MetroFramework.Controls.MetroLabel();
            this.hoangbutton1 = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.hoangbutton2 = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.hoangbutton3 = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.pnbuttonip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusSV)).BeginInit();
            this.pnmess.SuspendLayout();
            this.panel_showmess.SuspendLayout();
            this.pannel_chatsv.SuspendLayout();
            this.pn_ip.SuspendLayout();
            this.SuspendLayout();
            // 
            // modebg
            // 
            this.modebg.AutoSize = true;
            this.modebg.Location = new System.Drawing.Point(201, 16);
            this.modebg.Margin = new System.Windows.Forms.Padding(2);
            this.modebg.Name = "modebg";
            this.modebg.Size = new System.Drawing.Size(80, 17);
            this.modebg.TabIndex = 0;
            this.modebg.Text = "Off";
            this.modebg.UseVisualStyleBackColor = true;
            this.modebg.CheckedChanged += new System.EventHandler(this.modebg_CheckedChanged_1);
            // 
            // pnbuttonip
            // 
            this.pnbuttonip.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.pnbuttonip.Controls.Add(this.btn_encrypt);
            this.pnbuttonip.Controls.Add(this.panel1);
            this.pnbuttonip.Controls.Add(this.textBox1);
            this.pnbuttonip.Controls.Add(this.logofb);
            this.pnbuttonip.Controls.Add(this.statusSV);
            this.pnbuttonip.Controls.Add(this.modebg);
            this.pnbuttonip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnbuttonip.HorizontalScrollbarBarColor = true;
            this.pnbuttonip.HorizontalScrollbarHighlightOnWheel = false;
            this.pnbuttonip.HorizontalScrollbarSize = 8;
            this.pnbuttonip.Location = new System.Drawing.Point(15, 60);
            this.pnbuttonip.Margin = new System.Windows.Forms.Padding(2);
            this.pnbuttonip.Name = "pnbuttonip";
            this.pnbuttonip.Size = new System.Drawing.Size(800, 70);
            this.pnbuttonip.TabIndex = 1;
            this.pnbuttonip.VerticalScrollbarBarColor = true;
            this.pnbuttonip.VerticalScrollbarHighlightOnWheel = false;
            this.pnbuttonip.VerticalScrollbarSize = 8;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(575, 14);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(121, 20);
            this.btn_encrypt.TabIndex = 8;
            this.btn_encrypt.Text = "Encrypt";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hoangbutton3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.selectUDP);
            this.panel1.Controls.Add(this.selectTCP);
            this.panel1.Location = new System.Drawing.Point(316, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 60);
            this.panel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AES",
            "RSA",
            "MD5"});
            this.comboBox1.Location = new System.Drawing.Point(112, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // selectUDP
            // 
            this.selectUDP.AutoSize = true;
            this.selectUDP.Location = new System.Drawing.Point(32, 35);
            this.selectUDP.Margin = new System.Windows.Forms.Padding(2);
            this.selectUDP.Name = "selectUDP";
            this.selectUDP.Size = new System.Drawing.Size(48, 17);
            this.selectUDP.TabIndex = 6;
            this.selectUDP.Text = "UDP";
            this.selectUDP.UseVisualStyleBackColor = true;
            // 
            // selectTCP
            // 
            this.selectTCP.AutoSize = true;
            this.selectTCP.Checked = true;
            this.selectTCP.Location = new System.Drawing.Point(32, 8);
            this.selectTCP.Margin = new System.Windows.Forms.Padding(2);
            this.selectTCP.Name = "selectTCP";
            this.selectTCP.Size = new System.Drawing.Size(46, 17);
            this.selectTCP.TabIndex = 5;
            this.selectTCP.TabStop = true;
            this.selectTCP.Text = "TCP";
            this.selectTCP.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 21);
            this.textBox1.TabIndex = 7;
            // 
            // logofb
            // 
            this.logofb.BackColor = System.Drawing.Color.White;
            this.logofb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logofb.FlatAppearance.BorderSize = 0;
            this.logofb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logofb.Image = global::Chat2TCP_UDP.Properties.Resources.Info;
            this.logofb.Location = new System.Drawing.Point(749, 12);
            this.logofb.Margin = new System.Windows.Forms.Padding(2);
            this.logofb.Name = "logofb";
            this.logofb.Size = new System.Drawing.Size(39, 42);
            this.logofb.TabIndex = 4;
            this.logofb.UseVisualStyleBackColor = false;
            this.logofb.Click += new System.EventHandler(this.logofb_Click);
            // 
            // statusSV
            // 
            this.statusSV.Image = global::Chat2TCP_UDP.Properties.Resources.Status_Repair;
            this.statusSV.Location = new System.Drawing.Point(177, 13);
            this.statusSV.Margin = new System.Windows.Forms.Padding(2);
            this.statusSV.Name = "statusSV";
            this.statusSV.Size = new System.Drawing.Size(19, 20);
            this.statusSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusSV.TabIndex = 2;
            this.statusSV.TabStop = false;
            // 
            // pnmess
            // 
            this.pnmess.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.pnmess.Controls.Add(this.panel_showmess);
            this.pnmess.Controls.Add(this.pannel_chatsv);
            this.pnmess.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnmess.HorizontalScrollbarBarColor = true;
            this.pnmess.HorizontalScrollbarHighlightOnWheel = false;
            this.pnmess.HorizontalScrollbarSize = 8;
            this.pnmess.Location = new System.Drawing.Point(15, 130);
            this.pnmess.Margin = new System.Windows.Forms.Padding(2);
            this.pnmess.Name = "pnmess";
            this.pnmess.Size = new System.Drawing.Size(568, 479);
            this.pnmess.TabIndex = 2;
            this.pnmess.VerticalScrollbarBarColor = true;
            this.pnmess.VerticalScrollbarHighlightOnWheel = false;
            this.pnmess.VerticalScrollbarSize = 8;
            // 
            // panel_showmess
            // 
            this.panel_showmess.Controls.Add(this.hoangbutton1);
            this.panel_showmess.Controls.Add(this.messchat);
            this.panel_showmess.Controls.Add(this.listmessage);
            this.panel_showmess.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_showmess.Location = new System.Drawing.Point(0, 0);
            this.panel_showmess.Name = "panel_showmess";
            this.panel_showmess.Size = new System.Drawing.Size(568, 424);
            this.panel_showmess.TabIndex = 8;
            // 
            // messchat
            // 
            this.messchat.AutoSize = true;
            this.messchat.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.messchat.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.messchat.Location = new System.Drawing.Point(18, 17);
            this.messchat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messchat.Name = "messchat";
            this.messchat.Size = new System.Drawing.Size(86, 25);
            this.messchat.TabIndex = 5;
            this.messchat.Text = "Message";
            // 
            // listmessage
            // 
            this.listmessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listmessage.HideSelection = false;
            this.listmessage.Location = new System.Drawing.Point(0, 46);
            this.listmessage.Margin = new System.Windows.Forms.Padding(2);
            this.listmessage.Name = "listmessage";
            this.listmessage.Size = new System.Drawing.Size(568, 378);
            this.listmessage.TabIndex = 4;
            this.listmessage.UseCompatibleStateImageBehavior = false;
            this.listmessage.View = System.Windows.Forms.View.List;
            // 
            // pannel_chatsv
            // 
            this.pannel_chatsv.Controls.Add(this.hoangbutton2);
            this.pannel_chatsv.Controls.Add(this.tb_sendsv);
            this.pannel_chatsv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pannel_chatsv.Location = new System.Drawing.Point(0, 423);
            this.pannel_chatsv.Name = "pannel_chatsv";
            this.pannel_chatsv.Size = new System.Drawing.Size(568, 56);
            this.pannel_chatsv.TabIndex = 7;
            // 
            // tb_sendsv
            // 
            this.tb_sendsv.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_sendsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sendsv.Location = new System.Drawing.Point(0, 0);
            this.tb_sendsv.Multiline = true;
            this.tb_sendsv.Name = "tb_sendsv";
            this.tb_sendsv.Size = new System.Drawing.Size(432, 56);
            this.tb_sendsv.TabIndex = 6;
            this.tb_sendsv.Enter += new System.EventHandler(this.tb_sendsv_Enter);
            this.tb_sendsv.Leave += new System.EventHandler(this.tb_sendsv_Leave);
            // 
            // pn_ip
            // 
            this.pn_ip.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.pn_ip.Controls.Add(this.btnResetIp);
            this.pn_ip.Controls.Add(this.listipconnect);
            this.pn_ip.Controls.Add(this.ListIP);
            this.pn_ip.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_ip.HorizontalScrollbarBarColor = true;
            this.pn_ip.HorizontalScrollbarHighlightOnWheel = false;
            this.pn_ip.HorizontalScrollbarSize = 8;
            this.pn_ip.Location = new System.Drawing.Point(585, 130);
            this.pn_ip.Margin = new System.Windows.Forms.Padding(2);
            this.pn_ip.Name = "pn_ip";
            this.pn_ip.Size = new System.Drawing.Size(230, 479);
            this.pn_ip.TabIndex = 3;
            this.pn_ip.VerticalScrollbarBarColor = true;
            this.pn_ip.VerticalScrollbarHighlightOnWheel = false;
            this.pn_ip.VerticalScrollbarSize = 8;
            // 
            // btnResetIp
            // 
            this.btnResetIp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetIp.FlatAppearance.BorderSize = 0;
            this.btnResetIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetIp.Image = global::Chat2TCP_UDP.Properties.Resources.Update_Left_Rotation;
            this.btnResetIp.Location = new System.Drawing.Point(188, 2);
            this.btnResetIp.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetIp.Name = "btnResetIp";
            this.btnResetIp.Size = new System.Drawing.Size(40, 40);
            this.btnResetIp.TabIndex = 5;
            this.btnResetIp.UseVisualStyleBackColor = true;
            this.btnResetIp.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listipconnect
            // 
            this.listipconnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listipconnect.FormattingEnabled = true;
            this.listipconnect.Location = new System.Drawing.Point(0, 46);
            this.listipconnect.Margin = new System.Windows.Forms.Padding(2);
            this.listipconnect.Name = "listipconnect";
            this.listipconnect.Size = new System.Drawing.Size(230, 433);
            this.listipconnect.TabIndex = 4;
            // 
            // ListIP
            // 
            this.ListIP.AutoSize = true;
            this.ListIP.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ListIP.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ListIP.Location = new System.Drawing.Point(2, 2);
            this.ListIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListIP.Name = "ListIP";
            this.ListIP.Size = new System.Drawing.Size(124, 25);
            this.ListIP.TabIndex = 3;
            this.ListIP.Text = "Danh Sách IP";
            // 
            // hoangbutton1
            // 
            this.hoangbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hoangbutton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hoangbutton1.BorderColor = System.Drawing.Color.Black;
            this.hoangbutton1.BorderRadius = 8;
            this.hoangbutton1.BorderSize = 2;
            this.hoangbutton1.FlatAppearance.BorderSize = 0;
            this.hoangbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoangbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoangbutton1.ForeColor = System.Drawing.Color.Black;
            this.hoangbutton1.Location = new System.Drawing.Point(429, 3);
            this.hoangbutton1.Name = "hoangbutton1";
            this.hoangbutton1.Size = new System.Drawing.Size(121, 40);
            this.hoangbutton1.TabIndex = 6;
            this.hoangbutton1.Text = "Clear";
            this.hoangbutton1.TextColor = System.Drawing.Color.Black;
            this.hoangbutton1.UseVisualStyleBackColor = false;
            // 
            // hoangbutton2
            // 
            this.hoangbutton2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.hoangbutton2.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.hoangbutton2.BorderColor = System.Drawing.Color.Purple;
            this.hoangbutton2.BorderRadius = 0;
            this.hoangbutton2.BorderSize = 2;
            this.hoangbutton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.hoangbutton2.FlatAppearance.BorderSize = 0;
            this.hoangbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoangbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoangbutton2.ForeColor = System.Drawing.Color.Black;
            this.hoangbutton2.Location = new System.Drawing.Point(429, 0);
            this.hoangbutton2.Name = "hoangbutton2";
            this.hoangbutton2.Size = new System.Drawing.Size(139, 56);
            this.hoangbutton2.TabIndex = 7;
            this.hoangbutton2.Text = "Enter";
            this.hoangbutton2.TextColor = System.Drawing.Color.Black;
            this.hoangbutton2.UseVisualStyleBackColor = false;
            // 
            // hoangbutton3
            // 
            this.hoangbutton3.BackColor = System.Drawing.Color.Transparent;
            this.hoangbutton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.hoangbutton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hoangbutton3.BorderRadius = 8;
            this.hoangbutton3.BorderSize = 1;
            this.hoangbutton3.FlatAppearance.BorderSize = 0;
            this.hoangbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoangbutton3.ForeColor = System.Drawing.Color.Black;
            this.hoangbutton3.Location = new System.Drawing.Point(112, 30);
            this.hoangbutton3.Name = "hoangbutton3";
            this.hoangbutton3.Size = new System.Drawing.Size(121, 19);
            this.hoangbutton3.TabIndex = 8;
            this.hoangbutton3.Text = "hoangbutton3";
            this.hoangbutton3.TextColor = System.Drawing.Color.Black;
            this.hoangbutton3.UseVisualStyleBackColor = false;
            // 
            // Chatserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(830, 625);
            this.Controls.Add(this.pn_ip);
            this.Controls.Add(this.pnmess);
            this.Controls.Add(this.pnbuttonip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Chatserver";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Chat - Server";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Chatserver_Load);
            this.pnbuttonip.ResumeLayout(false);
            this.pnbuttonip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusSV)).EndInit();
            this.pnmess.ResumeLayout(false);
            this.panel_showmess.ResumeLayout(false);
            this.panel_showmess.PerformLayout();
            this.pannel_chatsv.ResumeLayout(false);
            this.pannel_chatsv.PerformLayout();
            this.pn_ip.ResumeLayout(false);
            this.pn_ip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroToggle modebg;
        private MetroFramework.Controls.MetroPanel pnbuttonip;
        private MetroFramework.Controls.MetroPanel pnmess;
        private MetroFramework.Controls.MetroPanel pn_ip;
        private System.Windows.Forms.ListView listmessage;
        private MetroFramework.Controls.MetroLabel ListIP;
        private System.Windows.Forms.PictureBox statusSV;
        private System.Windows.Forms.Button logofb;
        private System.Windows.Forms.RadioButton selectUDP;
        private System.Windows.Forms.RadioButton selectTCP;
        private System.Windows.Forms.ListBox listipconnect;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroLabel messchat;
        private System.Windows.Forms.Button btnResetIp;
        private System.Windows.Forms.Panel pannel_chatsv;
        private System.Windows.Forms.TextBox tb_sendsv;
        private System.Windows.Forms.Panel panel_showmess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroButton btn_encrypt;
        private scripts.Hoangbutton hoangbutton1;
        private scripts.Hoangbutton hoangbutton2;
        private scripts.Hoangbutton hoangbutton3;
    }
}

