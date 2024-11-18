using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Management
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }
        Function fn = new Function();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUserNameRegister.Text;
            string password = txtPasswordRegister.Text;
            string email = txtGmailRegister.Text;

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
                this.Close();  // Đóng form đăng ký sau khi đăng ký thành công
            }
        }

        private void txtUserNameRegister_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
