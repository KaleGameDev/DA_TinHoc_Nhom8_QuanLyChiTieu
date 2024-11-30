using Expense_Management.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Expense_Management.Form_Menu
{
    public partial class Add_Plan_Menu : UserControl
    {
        private Function fn = new Function();
        private int userId; // ID của người dùng hiện tại

        public Add_Plan_Menu(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Lưu lại UserID để sử dụng trong các truy vấn
            listPlans.SelectedIndexChanged += listBoxPlans_SelectedIndexChanged; // Gán sự kiện SelectedIndexChanged
            LoadPlans();
            ViewListDesign();

        }
        private void Add_Plan_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewPlan_Click_1(object sender, EventArgs e)
        {
            
        }

        public void ViewListDesign()
        {
            // Đặt ListBox sang chế độ vẽ tùy chỉnh
            listPlans.DrawMode = DrawMode.OwnerDrawFixed;
            listPlans.ItemHeight = 30; // Chiều cao của mỗi hàng (pixel)

            // Xử lý sự kiện DrawItem để tùy chỉnh việc vẽ các hàng
            listPlans.DrawItem += (s, e) =>
            {
                // Kiểm tra chỉ mục hợp lệ
                if (e.Index < 0 || e.Index >= listPlans.Items.Count)
                {
                    return;
                }

                e.DrawBackground();

                using (Font font = new Font("Arial", 16, FontStyle.Regular))
                {
                    StringFormat sf = new StringFormat
                    {
                        LineAlignment = StringAlignment.Center // Căn giữa theo chiều dọc
                    };

                    // Kiểm tra nếu là mục giả
                    if (listPlans.Items[e.Index].ToString() == "Không có kế hoạch nào.")
                    {
                        e.Graphics.DrawString(listPlans.Items[e.Index].ToString(), font, Brushes.Gray, e.Bounds, sf);
                    }
                    else
                    {
                        e.Graphics.DrawString(listPlans.Items[e.Index].ToString(), font, Brushes.Black, e.Bounds, sf);
                    }
                }

                e.DrawFocusRectangle();
            };

        }
        public void LoadPlans()
        {
            try
            {
                string query = "SELECT [PlanId], [PlanName] FROM [Plan] WHERE [UserId] = @userId";
                using (SqlConnection conn = fn.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        listPlans.Items.Clear();

                        while (reader.Read())
                        {
                            // Tạo một đối tượng kế hoạch và thêm vào ListBox
                            ListItem listItem = new ListItem
                            {
                                PlanId = reader.GetInt32(0),
                                PlanName = reader.GetString(1)
                            };
                            listPlans.Items.Add(listItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách kế hoạch: " + ex.Message);
            }
        }

        // Khi nhấn vào một kế hoạch, hiện thông tin chi tiết
        private void listBoxPlans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPlans.SelectedItem is ListItem selectedItem)
            {
                LoadPlanDetails(selectedItem.PlanId);
            }
            else
            {
                MessageBox.Show("Không thể đọc mục đã chọn.", "Lỗi");
            }
        }

        // Phương thức này để hiển thị thông tin chi tiết của kế hoạch
        private void LoadPlanDetails(int planId)
        {
            string query = "SELECT [PlanName], [Description] FROM [Plan] WHERE [PlanId] = @planId";
            try
            {
                MessageBox.Show($"Loading details for PlanId: {planId}", "Debug");

                using (SqlConnection conn = fn.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@planId", planId);
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string planName = reader.GetString(0);
                            string description = reader.GetString(1);

                            MessageBox.Show($"Tên kế hoạch: {planName}\nMô tả: {description}", "Chi tiết kế hoạch");
                            // Mở TransactionListForm với planId để hiển thị các giao dịch
                            TransactionListForm transactionListForm = new TransactionListForm(planId, this);
                            transactionListForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy chi tiết cho kế hoạch này.", "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết kế hoạch: " + ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public class ListItem
        {
            public int PlanId { get; set; }
            public string PlanName { get; set; }

            public override string ToString()
            {
                return PlanName; // Hiển thị tên kế hoạch trong ListBox
            }
        }

        private void listPlans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewPlan_Click_2(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            string planName = txtAddPlanName.Text.Trim();
            string description = txtAddDescription.Text.Trim();

            if (string.IsNullOrEmpty(planName) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin kế hoạch.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện thêm vào cơ sở dữ liệu
            string query = "INSERT INTO [Plan] (PlanName, Description, UserId) VALUES (@planName, @description, @userId)";

            try
            {
                using (SqlConnection conn = fn.getConnection()) // Kết nối tới database
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@planName", planName);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kế hoạch đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Xóa nội dung TextBox sau khi lưu
                        txtAddPlanName.Clear();
                        txtAddDescription.Clear();
                        LoadPlans();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu kế hoạch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Plan_Menu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
