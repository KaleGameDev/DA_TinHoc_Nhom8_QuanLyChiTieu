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

namespace Expense_Management
{
    public partial class Login_Form : Form
    {
        // Tạo đối tượng Function
        Function fn = new Function();
        public Login_Form()
        {
            InitializeComponent();

            // Ẩn các điều khiển liên quan đến đăng ký
            lbUserNameRegister.Visible = false;
            txtUserNameRegister.Visible = false;
            lbPasswordRegister.Visible = false;
            txtPasswordRegister.Visible = false;
            lbGmailRegister.Visible = false;
            txtGmailRegister.Visible = false;
            btnRegister.Visible = false;
            lbLinkLogin.Visible = false;
            lbDangKy.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserNameLogin.Text;
            string password = txtPasswordLogin.Text;

            // Truy vấn để lấy UserId nếu tên đăng nhập và mật khẩu đúng
            string query = "SELECT UserId FROM [User] WHERE Username=@username AND Password=@password";

            try
            {
                // Kết nối và kiểm tra thông tin đăng nhập
                using (SqlConnection conn = fn.getConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null) // Nếu UserId hợp lệ
                    {
                        int userId = Convert.ToInt32(result);

                        // Hiển thị thông báo đăng nhập thành công
                        MessageBox.Show("Đăng nhập thành công!");

                        // Khởi tạo Main_Form và truyền UserId và Username
                        Main_Form mainForm = new Main_Form();
                        mainForm.Username = username;
                        mainForm.CurrentUserId = userId;

                        this.Hide();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void lbLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideRegister();
        }
        public void hideRegister()
        {
            // Hiển thị lại các điều khiển liên quan đến đăng nhập
            lbUserNameLogin.Visible = true;
            txtUserNameLogin.Visible = true;
            lbPasswordLogin.Visible = true;
            txtPasswordLogin.Visible = true;
            btnLogin.Visible = true;
            lbLinkRegister.Visible = true;
            lbDangNhap.Visible = true;

            // Ẩn các điều khiển liên quan đến đăng ký
            lbUserNameRegister.Visible = false;
            txtUserNameRegister.Visible = false;
            lbPasswordRegister.Visible = false;
            txtPasswordRegister.Visible = false;
            lbGmailRegister.Visible = false;
            txtGmailRegister.Visible = false;
            btnRegister.Visible = false;
            lbLinkLogin.Visible = false;
            lbDangKy.Visible = false;
        }

        private void lbLinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideLogin();
        }

        public void hideLogin()
        {
            // Hiển thị lại các điều khiển liên quan đến đăng ký
            lbUserNameLogin.Visible = false;
            txtUserNameLogin.Visible = false;
            lbPasswordLogin.Visible = false;
            txtPasswordLogin.Visible = false;
            btnLogin.Visible = false;
            lbLinkRegister.Visible = false;
            lbDangNhap.Visible = false;

            // Ẩn các điều khiển liên quan đến đăng nhập
            lbUserNameRegister.Visible = true;
            txtUserNameRegister.Visible = true;
            lbPasswordRegister.Visible = true;
            txtPasswordRegister.Visible = true;
            lbGmailRegister.Visible = true;
            txtGmailRegister.Visible = true;
            btnRegister.Visible = true;
            lbLinkLogin.Visible = true;
            lbDangKy.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUserNameRegister.Text;  // TextBox đăng ký
            string password = txtPasswordRegister.Text;  // TextBox đăng ký
            string email = txtGmailRegister.Text;  // TextBox đăng ký

            // Kiểm tra nếu tên đăng nhập, mật khẩu hoặc email trống
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu tên đăng nhập đã tồn tại
            string checkQuery = "SELECT COUNT(1) FROM [User] WHERE UserName='" + username + "'";
            DataSet ds = fn.getData(checkQuery);

            if (ds.Tables[0].Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Nếu tên đăng nhập chưa tồn tại, thêm vào database
                string insertQuery = "INSERT INTO [User] (UserName, Password, Email) VALUES ('" + username + "', '" + password + "', '" + email + "')";
                fn.setData(insertQuery, "Đăng ký thành công!");

                // Chuyển về giao diện đăng nhập sau khi đăng ký thành công
                hideRegister();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
