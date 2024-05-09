namespace Chatclient
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.entersend = new System.Windows.Forms.Button();
            this.boxmess = new System.Windows.Forms.TextBox();
            this.listmess = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.boxipport = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.entername = new System.Windows.Forms.TextBox();
            this.statussv = new System.Windows.Forms.PictureBox();
            this.btndis = new System.Windows.Forms.Button();
            this.btnconnect = new System.Windows.Forms.Button();
            this.ipconnect = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statussv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listmess);
            this.panel1.Location = new System.Drawing.Point(187, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 398);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.entersend);
            this.panel2.Controls.Add(this.boxmess);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 310);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 84);
            this.panel2.TabIndex = 3;
            // 
            // entersend
            // 
            this.entersend.BackColor = System.Drawing.Color.MintCream;
            this.entersend.Dock = System.Windows.Forms.DockStyle.Right;
            this.entersend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entersend.Location = new System.Drawing.Point(516, 0);
            this.entersend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entersend.Name = "entersend";
            this.entersend.Size = new System.Drawing.Size(163, 82);
            this.entersend.TabIndex = 0;
            this.entersend.Text = "Enter";
            this.entersend.UseVisualStyleBackColor = false;
            this.entersend.Click += new System.EventHandler(this.entersend_Click);
            this.entersend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entersend_KeyPress);
            // 
            // boxmess
            // 
            this.boxmess.BackColor = System.Drawing.Color.White;
            this.boxmess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxmess.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxmess.Location = new System.Drawing.Point(0, 0);
            this.boxmess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxmess.Multiline = true;
            this.boxmess.Name = "boxmess";
            this.boxmess.Size = new System.Drawing.Size(517, 82);
            this.boxmess.TabIndex = 1;
            // 
            // listmess
            // 
            this.listmess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listmess.Dock = System.Windows.Forms.DockStyle.Top;
            this.listmess.HideSelection = false;
            this.listmess.Location = new System.Drawing.Point(0, 0);
            this.listmess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listmess.Name = "listmess";
            this.listmess.Size = new System.Drawing.Size(681, 307);
            this.listmess.TabIndex = 2;
            this.listmess.UseCompatibleStateImageBehavior = false;
            this.listmess.View = System.Windows.Forms.View.List;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Location = new System.Drawing.Point(23, 33);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 498);
            this.panel3.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 494);
            this.listBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.boxipport);
            this.panel4.Controls.Add(this.name);
            this.panel4.Controls.Add(this.avatar);
            this.panel4.Controls.Add(this.entername);
            this.panel4.Controls.Add(this.statussv);
            this.panel4.Controls.Add(this.btndis);
            this.panel4.Controls.Add(this.btnconnect);
            this.panel4.Controls.Add(this.ipconnect);
            this.panel4.Location = new System.Drawing.Point(187, 33);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 100);
            this.panel4.TabIndex = 2;
            // 
            // boxipport
            // 
            this.boxipport.Location = new System.Drawing.Point(324, 52);
            this.boxipport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxipport.Multiline = true;
            this.boxipport.Name = "boxipport";
            this.boxipport.Size = new System.Drawing.Size(193, 32);
            this.boxipport.TabIndex = 7;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(171, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 29);
            this.name.TabIndex = 6;
            this.name.Text = "Tên";
            // 
            // avatar
            // 
            this.avatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.avatar.Image = global::Chatclient.Properties.Resources.Customer;
            this.avatar.Location = new System.Drawing.Point(0, 0);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(100, 96);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 5;
            this.avatar.TabStop = false;
            // 
            // entername
            // 
            this.entername.Location = new System.Drawing.Point(135, 52);
            this.entername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entername.Multiline = true;
            this.entername.Name = "entername";
            this.entername.Size = new System.Drawing.Size(143, 32);
            this.entername.TabIndex = 4;
            // 
            // statussv
            // 
            this.statussv.Image = global::Chatclient.Properties.Resources.Status_Repair;
            this.statussv.Location = new System.Drawing.Point(475, 2);
            this.statussv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statussv.Name = "statussv";
            this.statussv.Size = new System.Drawing.Size(43, 46);
            this.statussv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statussv.TabIndex = 3;
            this.statussv.TabStop = false;
            // 
            // btndis
            // 
            this.btndis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndis.Location = new System.Drawing.Point(523, 52);
            this.btndis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(159, 46);
            this.btndis.TabIndex = 2;
            this.btndis.Text = "Disconnect";
            this.btndis.UseVisualStyleBackColor = true;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // btnconnect
            // 
            this.btnconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnect.Location = new System.Drawing.Point(523, 2);
            this.btnconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(159, 42);
            this.btnconnect.TabIndex = 1;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // ipconnect
            // 
            this.ipconnect.AutoSize = true;
            this.ipconnect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ipconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipconnect.Location = new System.Drawing.Point(324, 15);
            this.ipconnect.Name = "ipconnect";
            this.ipconnect.Size = new System.Drawing.Size(116, 27);
            this.ipconnect.TabIndex = 0;
            this.ipconnect.Text = "IP connect";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Padding = new System.Windows.Forms.Padding(20, 37, 20, 20);
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statussv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button entersend;
        private System.Windows.Forms.TextBox boxmess;
        private System.Windows.Forms.ListView listmess;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox statussv;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Label ipconnect;
        private System.Windows.Forms.TextBox entername;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox boxipport;
        private System.Windows.Forms.ListBox listBox1;
    }
}

