using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chat2TCP_UDP.form
{
    public partial class Form_Login : Form
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
        public event EventHandler SignUpRequested;
        private void hoangbutton2_Click(object sender, EventArgs e)
        {
            SignUpRequested?.Invoke(this, EventArgs.Empty);
        }

        private bool checkInput()
        {
            if(string.IsNullOrWhiteSpace(username_tb.Text) || string.IsNullOrWhiteSpace(password_tb.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu", "Điền sót kìa", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang hoàn thiện", "Bảo trì", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }

            using (SqlConnection connection = connectDB.GetqlConnession())
            {
                try
                {
                    connection.Open();
                    string Query = "SELECT UserID, Password FROM infoUser WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username_tb.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            int userID = Convert.ToInt32(reader["UserID"]);
                            string storedPassword = reader["Password"].ToString();
                            if (storedPassword == password_tb.Text)
                            {
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                LoginSuccessfully(userID);
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập không tồn tại.", "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoginSuccessfully(int userID)
        {
            LoggedInUserID = userID;
            MainLogin_Register.Instance.Hide();
            Form_chat chatserver = new Form_chat(LoggedInUserID);
            chatserver.Show();
        }
        private int LoggedInUserID;
    }
}
