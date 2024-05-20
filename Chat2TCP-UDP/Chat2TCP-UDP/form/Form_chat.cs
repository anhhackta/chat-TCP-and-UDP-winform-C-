using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Chat2TCP_UDP.form
{
    public partial class Form_chat : Form
    {
        private int userID;
        private frm_cre_join formchatreg;
        public Form_chat(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadUserData();
            formchatreg = new frm_cre_join();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_lb.Text = DateTime.Today.ToString("R");
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            setting settingsForm = new setting(userID);
            settingsForm.ShowDialog();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/anhhackta.official");
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLogin_Register.Instance.Show();
        }


        private void LoadUserData()
        {
            using (SqlConnection connection = connectDB.GetqlConnession())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT AppName, Avatar FROM infoUser WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string appName = reader.GetString(0);
                                byte[] avatarData = (byte[])reader["Avatar"];

                                lb_name.Text = appName;
                                if (avatarData != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(avatarData))
                                    {
                                        pic_avatar.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pic_avatar.Image = Properties.Resources.Account; 
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối database: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form_chat_Load(object sender, EventArgs e)
        {
            showfrmcre_join();
        }

        private void showfrmcre_join()
        {

            formchatreg.TopLevel = false;
            formchatreg.FormBorderStyle = FormBorderStyle.None;
            formchatreg.Dock = DockStyle.Fill;
            formchatreg.BringToFront();

            pn_chat.Controls.Add(formchatreg);
            pn_chat.Show();
            formchatreg.Show();
        }
    }
}
