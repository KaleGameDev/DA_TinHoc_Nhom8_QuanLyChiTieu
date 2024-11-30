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
using Expense_Management.Form_Menu;

namespace Expense_Management.Tools
{
    public partial class TransactionListForm : Form
    {
        private Add_Plan_Menu addPlanForm;
        private Function fn = new Function(); // Đối tượng để kết nối CSDL
        private int planId;

        public TransactionListForm(int planId, Add_Plan_Menu form)
        {
            InitializeComponent();
            this.planId = planId;
            LoadTransactions(); // Tải danh sách giao dịch khi form khởi động
            LoadPlanDescription(planId);
            addPlanForm = form; // Gán tham chiếu của Add_Plan
        }

        public void LoadTransactions()
        {
            string query = "SELECT TransactionId, Date, Amount, TransactionType FROM [Transaction] WHERE PlanId = @planId";

            using (SqlConnection conn = fn.getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@planId", planId);
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Thêm cột mới để hiển thị "Thu" hoặc "Chi"
                    dataTable.Columns.Add("TransactionTypeDisplay", typeof(string));

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["TransactionType"] != DBNull.Value)
                        {
                            int transactionType = Convert.ToInt32(row["TransactionType"]); // Lấy giá trị bit từ CSDL
                            row["TransactionTypeDisplay"] = transactionType == 1 ? "Thu" : "Chi"; // Gán giá trị "Thu" hoặc "Chi"
                        }
                    }
                    // Thay đổi DataGridView để hiển thị cột "TransactionTypeDisplay"
                    dataGridViewTransactions.DataSource = dataTable;
                    dataGridViewTransactions.Columns["TransactionTypeDisplay"].HeaderText = "Loại giao dịch";

                    // Ẩn cột gốc "TransactionType" nếu không cần thiết
                    dataGridViewTransactions.Columns["TransactionType"].Visible = false;


                    // Hiển thị dữ liệu trong DataGridView
                    dataGridViewTransactions.DataSource = dataTable;
                }
            }

            // Tùy chỉnh giao diện DataGridView
            CustomizeDataGridView();
        }

        private void LoadPlanDescription(int planId)
        {
            string query = "SELECT Description FROM [Plan] WHERE PlanId = @planId";

            using (SqlConnection conn = fn.getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@planId", planId);
                    conn.Open();

                    // Đọc mô tả kế hoạch
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string description = reader.GetString(0);

                        // Hiển thị mô tả vào label
                        lbNotePlan.Text = $"Mô tả kế hoạch: {description}";
                    }
                    else
                    {
                        lbNotePlan.Text = "Không tìm thấy mô tả kế hoạch.";
                    }
                }
            }
        }


        private void CustomizeDataGridView()
        {
            // Cập nhật tất cả các hàng thành chữ đậm và màu đen
            dataGridViewTransactions.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewTransactions.DefaultCellStyle.ForeColor = Color.Black;

            // Căn giữa tiêu đề của tất cả các cột
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Thay đổi font chữ cho tiêu đề cột (đậm và to hơn)
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Đặt chiều cao hàng tiêu đề
            dataGridViewTransactions.ColumnHeadersHeight = 40;

            // Đặt chiều rộng cho từng cột
            dataGridViewTransactions.Columns["TransactionId"].Width = 150;
            dataGridViewTransactions.Columns["Date"].Width = 150;
            dataGridViewTransactions.Columns["Amount"].Width = 120;

            // Đặt chiều rộng cho cột TransactionTypeDisplay
            dataGridViewTransactions.Columns["TransactionTypeDisplay"].Width = 150;

            // Đặt tiêu đề cho các cột
            dataGridViewTransactions.Columns["TransactionId"].HeaderText = "ID Giao dịch";
            dataGridViewTransactions.Columns["Date"].HeaderText = "Ngày";
            dataGridViewTransactions.Columns["Amount"].HeaderText = "Số tiền";
            dataGridViewTransactions.Columns["TransactionTypeDisplay"].HeaderText = "Loại giao dịch";

            // Ẩn cột gốc TransactionType
            dataGridViewTransactions.Columns["TransactionType"].Visible = false;

            // Định dạng cột "Số tiền" thành dạng tiền tệ với ký hiệu "đ"
            dataGridViewTransactions.Columns["Amount"].DefaultCellStyle.Format = "₫#,0"; // Thay "$" bằng "₫"
            dataGridViewTransactions.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Căn giữa cho cột "ID Giao dịch" và "Loại giao dịch"
            dataGridViewTransactions.Columns["TransactionId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTransactions.Columns["TransactionTypeDisplay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tăng kích thước hàng
            dataGridViewTransactions.RowTemplate.Height = 30;

            // Thêm đường viền và hiệu ứng khi chọn hàng
            dataGridViewTransactions.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTransactions.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewTransactions.DefaultCellStyle.SelectionForeColor = Color.White;

            // Thực hiện thay đổi màu sắc khi dữ liệu đã được tải hoàn toàn
            dataGridViewTransactions.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewRow row in dataGridViewTransactions.Rows)
                {
                    // Kiểm tra nếu giá trị trong cột "TransactionType" là bool (True hoặc False)
                    bool transactionType = (bool)row.Cells["TransactionType"].Value;

                    // Kiểm tra giá trị "TransactionType" và thay đổi màu sắc
                    if (transactionType) // "Thu" sẽ là True
                    {
                        row.Cells["TransactionTypeDisplay"].Style.ForeColor = Color.Green;  // Màu xanh cho "Thu"
                    }
                    else // "Chi" sẽ là False
                    {
                        row.Cells["TransactionTypeDisplay"].Style.ForeColor = Color.Red;  // Màu đỏ cho "Chi"
                    }
                }
            };
        }


        private void TransactionListForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewTransactions_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int transactionId = Convert.ToInt32(dataGridViewTransactions.Rows[e.RowIndex].Cells["TransactionId"].Value);

                // Mở form chi tiết giao dịch với transactionId đã chọn
                TransactionDetailForm detailForm = new TransactionDetailForm(transactionId);
                detailForm.ShowDialog();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void lbNotePlan_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaPlan_Click(object sender, EventArgs e)
        {

            // Hiển thị hộp thoại xác nhận
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa kế hoạch này và toàn bộ giao dịch liên quan không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Thực hiện xóa
                    DeletePlanAndTransactions(planId);
                    MessageBox.Show("Kế hoạch và các giao dịch liên quan đã được xóa thành công.", "Thông báo");

                    // Cập nhật danh sách sau khi xóa
                    addPlanForm.LoadPlans();

                    // Đóng form sau khi xóa thành công
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa kế hoạch: " + ex.Message, "Lỗi");
                }
            }
        }

        private void DeletePlanAndTransactions(int planId)
        {
            string queryTransactions = "DELETE FROM [Transaction] WHERE PlanId = @planId";
            string queryPlan = "DELETE FROM [Plan] WHERE PlanId = @planId";

            using (SqlConnection conn = fn.getConnection())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Xóa các giao dịch liên quan
                        using (SqlCommand cmdDeleteTransactions = new SqlCommand(queryTransactions, conn, transaction))
                        {
                            cmdDeleteTransactions.Parameters.AddWithValue("@planId", planId);
                            cmdDeleteTransactions.ExecuteNonQuery();
                        }

                        // Xóa kế hoạch
                        using (SqlCommand cmdDeletePlan = new SqlCommand(queryPlan, conn, transaction))
                        {
                            cmdDeletePlan.Parameters.AddWithValue("@planId", planId);
                            cmdDeletePlan.ExecuteNonQuery();
                        }

                        // Commit transaction nếu xóa thành công
                        transaction.Commit();
                    }
                    catch
                    {
                        // Rollback transaction nếu có lỗi
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
