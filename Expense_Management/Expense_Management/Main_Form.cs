using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Expense_Management.Form_Menu;  // Namespace của thư mục chứa UserControl1


namespace Expense_Management
{
    public partial class Main_Form : Form
    {
        private int currentUserId;

        public string Username { get; set; }  // Thuộc tính để lưu tên người dùng
        public int CurrentUserId { get; set; } // Dùng để lưu UserID sau khi đăng nhập

        public Main_Form()
        {
            InitializeComponent();
            this.Load += MainForm_Load; // Gán sự kiện Load cho MainForm_Load
            CenterMenuItems();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbUserName.ImageAlign = ContentAlignment.MiddleLeft; // Căn chỉnh hình ảnh ở giữa bên trái
            lbUserName.TextAlign = ContentAlignment.MiddleRight; // Căn chỉnh văn bản ở giữa bên phải
            lbUserName.Text = "Xin chào, " + Username; // Hiển thị tên người dùng

            // Dịch vị trí của Label sang trái bằng cách thay đổi tọa độ X
            lbUserName.Location = new Point(-100, lbUserName.Location.Y); // 10 là tọa độ X mới

            // Thêm padding bên trái để tạo khoảng cách giữa ảnh và văn bản
            lbUserName.Padding = new Padding(lbUserName.Image.Width + 70, 0, 0, 0); // 10 là khoảng cách giữa ảnh và text

            int currentUserId = GetCurrentUserId(); // Giả sử đây là phương thức trả về ID người dùng hiện tại
            ShowUserControl(new Home_Menu(currentUserId));
        }

        private void userNamelb_Click(object sender, EventArgs e)
        {

        }
        public void ShowUserControl(System.Windows.Forms.UserControl userControl)
        {
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl);
        }
        private int GetCurrentUserId()
        {
            // Giả sử bạn đã lưu userId sau khi người dùng đăng nhập
            return this.CurrentUserId;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Hiển thị lại LoginForm
            Login_Form loginForm = new Login_Form();
            loginForm.Show();

            // Đóng MainForm hiện tại
            this.Close();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void tsAddPlan_Click(object sender, EventArgs e)
        {
            int currentUserId = GetCurrentUserId(); // Giả sử đây là phương thức trả về ID người dùng hiện tại
            ShowUserControl(new Add_Plan_Menu(currentUserId));
            Console.WriteLine(currentUserId);
        }

        private void tsAddTransation_Click(object sender, EventArgs e)
        {
            int currentUserId = GetCurrentUserId(); // Giả sử đây là phương thức trả về ID người dùng hiện tại
            ShowUserControl(new Add_Transaction_Menu(currentUserId));
        }

        private void tsAddExpenditure_Click(object sender, EventArgs e)
        {
            int currentUserId = GetCurrentUserId(); // Giả sử đây là phương thức trả về ID người dùng hiện tại
            ShowUserControl(new Add_Expenditure_Menu(currentUserId));
        }

        private void tsChart_Click(object sender, EventArgs e)
        {
            int currentUserId = GetCurrentUserId(); // Giả sử đây là phương thức trả về ID người dùng hiện tại
            ShowUserControl(new Chart_Menu(currentUserId));
        }

        private void tsHome_Click(object sender, EventArgs e)
        {
            int currentUserId = GetCurrentUserId(); // Giả sử đây là phương thức trả về ID người dùng hiện tại
            ShowUserControl(new Home_Menu(currentUserId));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CenterMenuItems()
        {
            // Đặt `AutoSize` của `MenuStrip` thành `false`
            menuStrip1.AutoSize = false;

            // Đặt chiều rộng cho từng `ToolStripMenuItem` và căn giữa
            int itemWidth = menuStrip1.Width / menuStrip1.Items.Count;
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.Width = itemWidth;
                item.TextAlign = ContentAlignment.MiddleCenter; // Căn giữa chữ trong mỗi item
            }

            // Điều chỉnh Padding để tạo không gian cân bằng
            menuStrip1.Padding = new Padding(10, 2, 10, 2); // Cân đối Padding
        }
    }
}
