using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Chat2TCP_UDP.form
{
    public partial class Form_Login : MetroForm
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (username_tb.Text == "Nhập username")
            {
                username_tb.Text = "";
                username_tb.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(username_tb.Text == "")
            {
                username_tb.Text = "Nhập username";
                username_tb.ForeColor = Color.Gray;

            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (username_tb.Text == "password")
            {
                username_tb.Text = "";
                username_tb.ForeColor = Color.Black;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
           if (username_tb.Text == "")
            {
                username_tb.Text = "password";
                username_tb.ForeColor = Color.Gray;

            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            username_tb.Text = "Nhập username";
            username_tb.ForeColor = Color.Gray;
            password_tb.Text = "password";
            password_tb.ForeColor = Color.Gray;
        }
    }
}
