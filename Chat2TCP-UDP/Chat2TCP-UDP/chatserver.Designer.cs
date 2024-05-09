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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectUDP = new System.Windows.Forms.RadioButton();
            this.selectTCP = new System.Windows.Forms.RadioButton();
            this.pnmess = new MetroFramework.Controls.MetroPanel();
            this.messchat = new MetroFramework.Controls.MetroLabel();
            this.listmessage = new System.Windows.Forms.ListView();
            this.pn_ip = new MetroFramework.Controls.MetroPanel();
            this.listipconnect = new System.Windows.Forms.ListBox();
            this.ListIP = new MetroFramework.Controls.MetroLabel();
            this.btnResetIp = new System.Windows.Forms.Button();
            this.logofb = new System.Windows.Forms.Button();
            this.statusSV = new System.Windows.Forms.PictureBox();
            this.pnbuttonip.SuspendLayout();
            this.pnmess.SuspendLayout();
            this.pn_ip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusSV)).BeginInit();
            this.SuspendLayout();
            // 
            // modebg
            // 
            this.modebg.AutoSize = true;
            this.modebg.Location = new System.Drawing.Point(194, 17);
            this.modebg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.pnbuttonip.Controls.Add(this.textBox1);
            this.pnbuttonip.Controls.Add(this.selectUDP);
            this.pnbuttonip.Controls.Add(this.selectTCP);
            this.pnbuttonip.Controls.Add(this.logofb);
            this.pnbuttonip.Controls.Add(this.statusSV);
            this.pnbuttonip.Controls.Add(this.modebg);
            this.pnbuttonip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnbuttonip.HorizontalScrollbarBarColor = true;
            this.pnbuttonip.HorizontalScrollbarHighlightOnWheel = false;
            this.pnbuttonip.HorizontalScrollbarSize = 8;
            this.pnbuttonip.Location = new System.Drawing.Point(15, 60);
            this.pnbuttonip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnbuttonip.Name = "pnbuttonip";
            this.pnbuttonip.Size = new System.Drawing.Size(676, 49);
            this.pnbuttonip.TabIndex = 1;
            this.pnbuttonip.VerticalScrollbarBarColor = true;
            this.pnbuttonip.VerticalScrollbarHighlightOnWheel = false;
            this.pnbuttonip.VerticalScrollbarSize = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 21);
            this.textBox1.TabIndex = 7;
            // 
            // selectUDP
            // 
            this.selectUDP.AutoSize = true;
            this.selectUDP.Location = new System.Drawing.Point(380, 16);
            this.selectUDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.selectTCP.Location = new System.Drawing.Point(321, 16);
            this.selectTCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectTCP.Name = "selectTCP";
            this.selectTCP.Size = new System.Drawing.Size(46, 17);
            this.selectTCP.TabIndex = 5;
            this.selectTCP.TabStop = true;
            this.selectTCP.Text = "TCP";
            this.selectTCP.UseVisualStyleBackColor = true;
            // 
            // pnmess
            // 
            this.pnmess.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.pnmess.Controls.Add(this.messchat);
            this.pnmess.Controls.Add(this.listmessage);
            this.pnmess.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnmess.HorizontalScrollbarBarColor = true;
            this.pnmess.HorizontalScrollbarHighlightOnWheel = false;
            this.pnmess.HorizontalScrollbarSize = 8;
            this.pnmess.Location = new System.Drawing.Point(15, 109);
            this.pnmess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnmess.Name = "pnmess";
            this.pnmess.Size = new System.Drawing.Size(441, 337);
            this.pnmess.TabIndex = 2;
            this.pnmess.VerticalScrollbarBarColor = true;
            this.pnmess.VerticalScrollbarHighlightOnWheel = false;
            this.pnmess.VerticalScrollbarSize = 8;
            // 
            // messchat
            // 
            this.messchat.AutoSize = true;
            this.messchat.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.messchat.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.messchat.Location = new System.Drawing.Point(11, 2);
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
            this.listmessage.Location = new System.Drawing.Point(0, 21);
            this.listmessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listmessage.Name = "listmessage";
            this.listmessage.Size = new System.Drawing.Size(441, 316);
            this.listmessage.TabIndex = 4;
            this.listmessage.UseCompatibleStateImageBehavior = false;
            this.listmessage.View = System.Windows.Forms.View.List;
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
            this.pn_ip.Location = new System.Drawing.Point(461, 109);
            this.pn_ip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_ip.Name = "pn_ip";
            this.pn_ip.Size = new System.Drawing.Size(230, 337);
            this.pn_ip.TabIndex = 3;
            this.pn_ip.VerticalScrollbarBarColor = true;
            this.pn_ip.VerticalScrollbarHighlightOnWheel = false;
            this.pn_ip.VerticalScrollbarSize = 8;
            // 
            // listipconnect
            // 
            this.listipconnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listipconnect.FormattingEnabled = true;
            this.listipconnect.Location = new System.Drawing.Point(0, 47);
            this.listipconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listipconnect.Name = "listipconnect";
            this.listipconnect.Size = new System.Drawing.Size(230, 290);
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
            // btnResetIp
            // 
            this.btnResetIp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetIp.FlatAppearance.BorderSize = 0;
            this.btnResetIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetIp.Image = global::Chat2TCP_UDP.Properties.Resources.Update_Left_Rotation;
            this.btnResetIp.Location = new System.Drawing.Point(189, 2);
            this.btnResetIp.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetIp.Name = "btnResetIp";
            this.btnResetIp.Size = new System.Drawing.Size(38, 41);
            this.btnResetIp.TabIndex = 5;
            this.btnResetIp.UseVisualStyleBackColor = true;
            this.btnResetIp.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // logofb
            // 
            this.logofb.BackColor = System.Drawing.Color.White;
            this.logofb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logofb.FlatAppearance.BorderSize = 0;
            this.logofb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logofb.Image = global::Chat2TCP_UDP.Properties.Resources.Info;
            this.logofb.Location = new System.Drawing.Point(634, 2);
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
            this.statusSV.Location = new System.Drawing.Point(170, 14);
            this.statusSV.Margin = new System.Windows.Forms.Padding(2);
            this.statusSV.Name = "statusSV";
            this.statusSV.Size = new System.Drawing.Size(19, 20);
            this.statusSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusSV.TabIndex = 2;
            this.statusSV.TabStop = false;
            // 
            // Chatserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(706, 462);
            this.Controls.Add(this.pn_ip);
            this.Controls.Add(this.pnmess);
            this.Controls.Add(this.pnbuttonip);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Chatserver";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Chat - Server";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.pnbuttonip.ResumeLayout(false);
            this.pnbuttonip.PerformLayout();
            this.pnmess.ResumeLayout(false);
            this.pnmess.PerformLayout();
            this.pn_ip.ResumeLayout(false);
            this.pn_ip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusSV)).EndInit();
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
    }
}

