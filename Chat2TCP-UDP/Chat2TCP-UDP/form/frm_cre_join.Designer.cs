namespace Chat2TCP_UDP.form
{
    partial class frm_cre_join
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
            this.hoangbutton2 = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.hoangbutton1 = new Chat2TCP_UDP.scripts.Hoangbutton();
            this.panel_chat_creareg = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // hoangbutton2
            // 
            this.hoangbutton2.BackColor = System.Drawing.Color.Pink;
            this.hoangbutton2.BackgroundColor = System.Drawing.Color.Pink;
            this.hoangbutton2.BorderColor = System.Drawing.Color.DarkMagenta;
            this.hoangbutton2.BorderRadius = 9;
            this.hoangbutton2.BorderSize = 2;
            this.hoangbutton2.FlatAppearance.BorderSize = 0;
            this.hoangbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoangbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoangbutton2.ForeColor = System.Drawing.Color.Black;
            this.hoangbutton2.Location = new System.Drawing.Point(412, 249);
            this.hoangbutton2.Name = "hoangbutton2";
            this.hoangbutton2.Size = new System.Drawing.Size(199, 74);
            this.hoangbutton2.TabIndex = 1;
            this.hoangbutton2.Text = "vào phòng";
            this.hoangbutton2.TextColor = System.Drawing.Color.Black;
            this.hoangbutton2.UseVisualStyleBackColor = false;
            // 
            // hoangbutton1
            // 
            this.hoangbutton1.BackColor = System.Drawing.Color.BlueViolet;
            this.hoangbutton1.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.hoangbutton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hoangbutton1.BorderRadius = 9;
            this.hoangbutton1.BorderSize = 0;
            this.hoangbutton1.FlatAppearance.BorderSize = 0;
            this.hoangbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoangbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoangbutton1.ForeColor = System.Drawing.Color.White;
            this.hoangbutton1.Location = new System.Drawing.Point(146, 249);
            this.hoangbutton1.Name = "hoangbutton1";
            this.hoangbutton1.Size = new System.Drawing.Size(199, 74);
            this.hoangbutton1.TabIndex = 0;
            this.hoangbutton1.Text = "tạo phòng";
            this.hoangbutton1.TextColor = System.Drawing.Color.White;
            this.hoangbutton1.UseVisualStyleBackColor = false;
            this.hoangbutton1.Click += new System.EventHandler(this.hoangbutton1_Click);
            // 
            // panel_chat_creareg
            // 
            this.panel_chat_creareg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_chat_creareg.Location = new System.Drawing.Point(0, 0);
            this.panel_chat_creareg.Name = "panel_chat_creareg";
            this.panel_chat_creareg.Size = new System.Drawing.Size(766, 557);
            this.panel_chat_creareg.TabIndex = 2;
            // 
            // frm_cre_join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 557);
            this.Controls.Add(this.hoangbutton2);
            this.Controls.Add(this.hoangbutton1);
            this.Controls.Add(this.panel_chat_creareg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cre_join";
            this.Text = "frm_cre_join";
            this.ResumeLayout(false);

        }

        #endregion

        private scripts.Hoangbutton hoangbutton1;
        private scripts.Hoangbutton hoangbutton2;
        private System.Windows.Forms.Panel panel_chat_creareg;
    }
}