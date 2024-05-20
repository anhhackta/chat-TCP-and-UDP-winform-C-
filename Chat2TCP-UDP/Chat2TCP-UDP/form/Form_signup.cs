using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chat2TCP_UDP.form
{
    public partial class Form_signup : Form
    {
        
        public Form_signup()
        {
            InitializeComponent();
            
        }

        

        public event EventHandler LoginRequested;
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(!CheckInput())
                return;
            if(!CheckInfoDB())
                return;

            SaveinfotoDB();
        }

        private bool CheckInput()
        {
            if (tb_name_reg.Text.Length < 5)
            {
                MessageBox.Show("Tên App phải dài hơn 5 kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(tb_email_reg.Text, @"^[^@\s]+@gmail\.com$"))
            {
                MessageBox.Show("Email không hợp lệ  * Email phải có định dạng ***@gmail.com", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_username_reg.Text) || string.IsNullOrWhiteSpace(tb_pass1.Text))
            {
                MessageBox.Show("Tên Đăng Nhập và Mật Khẩu không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckInfoDB()
        {
            using (SqlConnection connection = connectDB.GetqlConnession())
            {
                try
                {

                            connection.Open();
                            string checkQuery = " SELECT COUNT(*) FROM infoUser WHERE AppName = @AppName OR Username = @Username ";
                            using (SqlCommand command = new SqlCommand(checkQuery, connection))
                            {
                                command.Parameters.AddWithValue("@AppName", tb_name_reg.Text);
                                command.Parameters.AddWithValue("@Username", tb_username_reg.Text);

                                int count = (int)command.ExecuteScalar();
                                if (count > 0)
                                {
                                    MessageBox.Show("Name App hoặc Tên Đăng Nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                }
                catch (Exception ex)
                {
                            MessageBox.Show("Lỗi kết nối database", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                            connection.Close();
                }
            }
                
            return true;
        }

        private void SaveinfotoDB()
        {
            using (SqlConnection connection = connectDB.GetqlConnession())
            {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO infoUser (Username, Password, Email, AppName, Avatar, IsVerified) VALUES (@Username,  @Password, @Email, @AppName, @Avatar, @IsVerified)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@Username", tb_username_reg.Text);
                            command.Parameters.AddWithValue("@Password", tb_pass1.Text);
                            command.Parameters.AddWithValue("@Email", tb_email_reg.Text);
                            command.Parameters.AddWithValue("@AppName", tb_name_reg.Text);
                            command.Parameters.AddWithValue("@Avatar", GetDefaultAvatar());
                            command.Parameters.AddWithValue("@IsVerified", false);

                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối database: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            
            
        }
        private byte[] GetDefaultAvatar()
        {
            
            using (MemoryStream ms = new MemoryStream())
            {
                Properties.Resources.Account.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked = false)
            {
                tb_pass1.PasswordChar = '*';

            }
            else
            {
                tb_pass1.PasswordChar = '\0';
            }

        }

        private void Form_signup_Load(object sender, EventArgs e)
        {
            tb_pass1.PasswordChar = '*';
        }
    }
}
