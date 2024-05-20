namespace Chat2TCP_UDP.form
{
    partial class Form_signup
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
            this.tb_name_reg = new System.Windows.Forms.TextBox();
            this.tb_email_reg = new System.Windows.Forms.TextBox();
            this.tb_username_reg = new System.Windows.Forms.TextBox();
            this.tb_pass1 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.pass1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.nameapp = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.btn_register = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.SuspendLayout();
            // 
            // tb_name_reg
            // 
            this.tb_name_reg.Location = new System.Drawing.Point(66, 154);
            this.tb_name_reg.Multiline = true;
            this.tb_name_reg.Name = "tb_name_reg";
            this.tb_name_reg.Size = new System.Drawing.Size(220, 30);
            this.tb_name_reg.TabIndex = 0;
            // 
            // tb_email_reg
            // 
            this.tb_email_reg.Location = new System.Drawing.Point(65, 210);
            this.tb_email_reg.Multiline = true;
            this.tb_email_reg.Name = "tb_email_reg";
            this.tb_email_reg.Size = new System.Drawing.Size(220, 30);
            this.tb_email_reg.TabIndex = 1;
            // 
            // tb_username_reg
            // 
            this.tb_username_reg.Location = new System.Drawing.Point(66, 266);
            this.tb_username_reg.Multiline = true;
            this.tb_username_reg.Name = "tb_username_reg";
            this.tb_username_reg.Size = new System.Drawing.Size(220, 30);
            this.tb_username_reg.TabIndex = 2;
            // 
            // tb_pass1
            // 
            this.tb_pass1.Location = new System.Drawing.Point(65, 322);
            this.tb_pass1.Multiline = true;
            this.tb_pass1.Name = "tb_pass1";
            this.tb_pass1.Size = new System.Drawing.Size(220, 30);
            this.tb_pass1.TabIndex = 3;
            this.tb_pass1.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.username.Location = new System.Drawing.Point(61, 243);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(116, 20);
            this.username.TabIndex = 5;
            this.username.Text = "Tên đăng nhập";
            // 
            // pass1
            // 
            this.pass1.AutoSize = true;
            this.pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pass1.Location = new System.Drawing.Point(62, 299);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(75, 20);
            this.pass1.TabIndex = 6;
            this.pass1.Text = "mật khẩu";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.email.Location = new System.Drawing.Point(62, 187);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 20);
            this.email.TabIndex = 8;
            this.email.Text = "Email";
            // 
            // nameapp
            // 
            this.nameapp.AutoSize = true;
            this.nameapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameapp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameapp.Location = new System.Drawing.Point(61, 131);
            this.nameapp.Name = "nameapp";
            this.nameapp.Size = new System.Drawing.Size(117, 20);
            this.nameapp.TabIndex = 9;
            this.nameapp.Text = "Tên tronng app";
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(157, 367);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(129, 24);
            this.showpass.TabIndex = 11;
            this.showpass.Text = "show pasword";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quay lại đăng nhập";
            this.label1.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Get Started";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.BackgroundColor = System.Drawing.Color.White;
            this.btn_clear.BorderColor = System.Drawing.Color.Purple;
            this.btn_clear.BorderRadius = 7;
            this.btn_clear.BorderSize = 2;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(77, 491);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(195, 46);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextColor = System.Drawing.Color.Black;
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_register.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_register.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_register.BorderRadius = 7;
            this.btn_register.BorderSize = 0;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(77, 410);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(195, 55);
            this.btn_register.TabIndex = 10;
            this.btn_register.Text = "Register";
            this.btn_register.TextColor = System.Drawing.Color.White;
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // Form_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.nameapp);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.tb_pass1);
            this.Controls.Add(this.tb_username_reg);
            this.Controls.Add(this.tb_email_reg);
            this.Controls.Add(this.tb_name_reg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_signup";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Đăng Ký";
            this.Load += new System.EventHandler(this.Form_signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name_reg;
        private System.Windows.Forms.TextBox tb_email_reg;
        private System.Windows.Forms.TextBox tb_username_reg;
        private System.Windows.Forms.TextBox tb_pass1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label pass1;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label nameapp;
        private scripts.Hoangbutton btn_register;
        private System.Windows.Forms.CheckBox showpass;
        private scripts.Hoangbutton btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}