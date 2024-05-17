namespace Chat2TCP_UDP.form
{
    partial class Form_Login
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
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.hoangbutton1 = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hoangbutton2 = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(66, 216);
            this.username_tb.Multiline = true;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(219, 30);
            this.username_tb.TabIndex = 0;
            this.username_tb.Enter += new System.EventHandler(this.textBox1_Enter);
            this.username_tb.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(66, 297);
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(219, 30);
            this.password_tb.TabIndex = 1;
            this.password_tb.Enter += new System.EventHandler(this.pass_Enter);
            this.password_tb.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // hoangbutton1
            // 
            this.hoangbutton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.hoangbutton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.hoangbutton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hoangbutton1.BorderRadius = 7;
            this.hoangbutton1.BorderSize = 0;
            this.hoangbutton1.FlatAppearance.BorderSize = 0;
            this.hoangbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoangbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoangbutton1.ForeColor = System.Drawing.Color.White;
            this.hoangbutton1.Location = new System.Drawing.Point(66, 400);
            this.hoangbutton1.Name = "hoangbutton1";
            this.hoangbutton1.Size = new System.Drawing.Size(105, 52);
            this.hoangbutton1.TabIndex = 2;
            this.hoangbutton1.Text = "Đăng nhập";
            this.hoangbutton1.TextColor = System.Drawing.Color.White;
            this.hoangbutton1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(191, 333);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "show pasword";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "quên mật khẩu";
            // 
            // hoangbutton2
            // 
            this.hoangbutton2.BackColor = System.Drawing.Color.LightSalmon;
            this.hoangbutton2.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.hoangbutton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hoangbutton2.BorderRadius = 7;
            this.hoangbutton2.BorderSize = 0;
            this.hoangbutton2.FlatAppearance.BorderSize = 0;
            this.hoangbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoangbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoangbutton2.ForeColor = System.Drawing.Color.Black;
            this.hoangbutton2.Location = new System.Drawing.Point(180, 400);
            this.hoangbutton2.Name = "hoangbutton2";
            this.hoangbutton2.Size = new System.Drawing.Size(105, 52);
            this.hoangbutton2.TabIndex = 5;
            this.hoangbutton2.Text = "Đăng ký";
            this.hoangbutton2.TextColor = System.Drawing.Color.Black;
            this.hoangbutton2.UseVisualStyleBackColor = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 614);
            this.Controls.Add(this.hoangbutton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.hoangbutton1);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private scripts.Hoangbutton hoangbutton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private scripts.Hoangbutton hoangbutton2;
    }
}