using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat2TCP_UDP.form;
using MetroFramework.Forms;

namespace Chat2TCP_UDP
{
    

    public partial class MainLogin_Register : Form
    {
        private Form_Login formLogin;
        private Form_signup formSignup;
        private static MainLogin_Register instance;


        public static MainLogin_Register Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new MainLogin_Register();
                }
                return instance;
            }
        }

        public MainLogin_Register()
        {
            InitializeComponent();
            formLogin = new Form_Login();
            formSignup = new Form_signup();


            formLogin.SignUpRequested += FormLogin_SignUpRequested;
            formSignup.LoginRequested += FormSignup_LoginRequested;

        }

        private void MainLogin_Register_Load(object sender, EventArgs e)
        {
            ShowLoginForm();
        }
        private void FormLogin_SignUpRequested(object sender, EventArgs e)
        {
            ShowSignupForm();
        }

        private void FormSignup_LoginRequested(object sender, EventArgs e)
        {
            ShowLoginForm();
        }
        public void ShowLoginForm()
        {


            panel_signup.Controls.Clear();
            panel_signup.Hide();

            formLogin.TopLevel = false;
            formLogin.FormBorderStyle = FormBorderStyle.None;
            formLogin.Dock = DockStyle.Fill;
            formLogin.BringToFront();
            panel_signup.Controls.Clear();


            panel_login.Controls.Add(formLogin);
            panel_login.Show();
            formLogin.Show();
        }

        public void ShowSignupForm()
        {
            panel_login.Controls.Clear();
            panel_login.Hide();

            formSignup.TopLevel = false;
            formSignup.FormBorderStyle = FormBorderStyle.None;
            formSignup.Dock = DockStyle.Fill;
            formSignup.BringToFront();

            panel_signup.Controls.Add(formSignup);
            panel_signup.Show();
            formSignup.Show();
        }


      
    }
}
