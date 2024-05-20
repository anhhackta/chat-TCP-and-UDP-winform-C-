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
    public partial class setting : MetroForm
    {
        private int userID;

        public setting(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoaduserData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Image image = Image.FromFile(imagePath);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void LoaduserData()
        {
            using (SqlConnection connection = connectDB.GetqlConnession())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Email,AppName, Avatar FROM infoUser WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tb_email.Text = reader.GetString(0);
                                tb_AppName.Text = reader.GetString(1);
                                byte[] avatarData = (byte[])reader["Avatar"];
                                
                                

                                if (avatarData != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(avatarData))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pictureBox1.Image = Properties.Resources.Account;
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối database: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_AppName.Text) || string.IsNullOrEmpty(tb_email.Text))
            {
                MessageBox.Show("App Name và Email không được để trống.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = connectDB.GetqlConnession())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Password FROM infoUser WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        string storedPassword = (string)command.ExecuteScalar();

                        if (storedPassword != tb_pass_old.Text)
                        {
                            MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string updateQuery =
                        "UPDATE infoUser SET Password = @Password, Email = @Email,AppName = @AppName,  Avatar = @Avatar WHERE UserID = @UserID";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@UserID", userID);
                        updateCommand.Parameters.AddWithValue("@Email", tb_email.Text);
                        updateCommand.Parameters.AddWithValue("@AppName", tb_AppName.Text);
                        updateCommand.Parameters.AddWithValue("@Password",
                            string.IsNullOrEmpty(tb_pass_new.Text) ? tb_pass_old.Text : tb_pass_new.Text);

                        if (pictureBox1.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                updateCommand.Parameters.AddWithValue("@Avatar", ms.ToArray());
                            }
                        }
                        else
                        {
                            updateCommand.Parameters.AddWithValue("@Avatar", DBNull.Value);
                        }



                        updateCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thông tin đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối database: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void hoangbutton1_Click(object sender, EventArgs e)
        {
            tb_AppName.Clear();
            tb_email.Clear();
            tb_pass_new.Clear();
            tb_pass_old.Clear();
        }

        private void setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
