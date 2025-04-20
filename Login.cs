using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _316
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //退出键
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        //登录键
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserNameText.Text.Trim();
            string password = PasswordText.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("用户名和密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 查询用户记录（使用参数化查询防止SQL注入）
                    string query = "SELECT Password FROM Users WHERE Username = @Username";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string storedPassword = result.ToString();

                        // 直接比较明文密码（不安全！）
                        if (password == storedPassword)
                        {
                            MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // 登录成功后跳转到主窗体
                            this.Hide();
                            CoffeeInfo ci = new CoffeeInfo();
                            ci.Show();
                        }
                        else
                        {
                            MessageBox.Show("密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"登录时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //注册按钮
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
        }
    }
}
