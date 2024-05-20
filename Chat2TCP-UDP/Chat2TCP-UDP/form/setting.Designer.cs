namespace Chat2TCP_UDP.form
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_pass_old = new System.Windows.Forms.TextBox();
            this.tb_pass_new = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_AppName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_enter = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.hoangbutton1 = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_pass_old
            // 
            this.tb_pass_old.Location = new System.Drawing.Point(261, 126);
            this.tb_pass_old.Name = "tb_pass_old";
            this.tb_pass_old.Size = new System.Drawing.Size(214, 20);
            this.tb_pass_old.TabIndex = 2;
            // 
            // tb_pass_new
            // 
            this.tb_pass_new.Location = new System.Drawing.Point(261, 172);
            this.tb_pass_new.Name = "tb_pass_new";
            this.tb_pass_new.Size = new System.Drawing.Size(214, 20);
            this.tb_pass_new.TabIndex = 3;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(261, 218);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(214, 20);
            this.tb_email.TabIndex = 4;
            // 
            // tb_AppName
            // 
            this.tb_AppName.Location = new System.Drawing.Point(48, 77);
            this.tb_AppName.Name = "tb_AppName";
            this.tb_AppName.Size = new System.Drawing.Size(150, 20);
            this.tb_AppName.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.Blue;
            this.btn_enter.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_enter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_enter.BorderRadius = 8;
            this.btn_enter.BorderSize = 2;
            this.btn_enter.FlatAppearance.BorderSize = 0;
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.White;
            this.btn_enter.Location = new System.Drawing.Point(310, 305);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(125, 40);
            this.btn_enter.TabIndex = 7;
            this.btn_enter.Text = "Xác nhận";
            this.btn_enter.TextColor = System.Drawing.Color.White;
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // hoangbutton1
            // 
            this.hoangbutton1.BackColor = System.Drawing.Color.White;
            this.hoangbutton1.BackgroundColor = System.Drawing.Color.White;
            this.hoangbutton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hoangbutton1.BorderRadius = 8;
            this.hoangbutton1.BorderSize = 2;
            this.hoangbutton1.FlatAppearance.BorderSize = 0;
            this.hoangbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoangbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoangbutton1.ForeColor = System.Drawing.Color.Black;
            this.hoangbutton1.Location = new System.Drawing.Point(60, 305);
            this.hoangbutton1.Name = "hoangbutton1";
            this.hoangbutton1.Size = new System.Drawing.Size(125, 40);
            this.hoangbutton1.TabIndex = 1;
            this.hoangbutton1.Text = "Clear";
            this.hoangbutton1.TextColor = System.Drawing.Color.Black;
            this.hoangbutton1.UseVisualStyleBackColor = false;
            this.hoangbutton1.Click += new System.EventHandler(this.hoangbutton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(257, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "mật khẩu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(257, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(257, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "email";
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_AppName);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_pass_new);
            this.Controls.Add(this.tb_pass_old);
            this.Controls.Add(this.hoangbutton1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setting";
            this.Text = "setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.setting_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private scripts.Hoangbutton hoangbutton1;
        private System.Windows.Forms.TextBox tb_pass_old;
        private System.Windows.Forms.TextBox tb_pass_new;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_AppName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private scripts.Hoangbutton btn_enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}