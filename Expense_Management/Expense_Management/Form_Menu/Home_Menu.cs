using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Expense_Management.Class;

namespace Expense_Management.Form_Menu
{
    public partial class Home_Menu : UserControl
    {
        private Function fn = new Function(); // Khởi tạo hàm để kết nối CSDL
        private int userId; // ID của người dùng hiện tại
        public Home_Menu(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Lưu lại UserID để sử dụng trong các truy vấn
            LoadPlans();
            if (cbChoosePlan.SelectedValue is int initialPlanId)
            {
                UpdateChart(initialPlanId);
            }
        }

        private void Home_Menu_Load(object sender, EventArgs e)
        {

        }
        private void LoadPlans()
        {
            // Giả sử bạn có một phương thức để lấy dữ liệu kế hoạch từ cơ sở dữ liệu
            List<Plan> plans = GetPlansFromDatabase(); // Lấy danh sách kế hoạch từ database

            cbChoosePlan.DataSource = plans;
            cbChoosePlan.DisplayMember = "PlanName"; // Hiển thị tên kế hoạch
            cbChoosePlan.ValueMember = "PlanID"; // Lưu giá trị là ID kế hoạch
        }

        private List<Plan> GetPlansFromDatabase()
        {
            List<Plan> plans = new List<Plan>();

            using (SqlConnection conn = fn.getConnection())
            {
                conn.Open();
                string query = "SELECT PlanID, PlanName FROM [Plan] WHERE UserId = " + userId;
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        plans.Add(new Plan
                        {
                            PlanID = reader.GetInt32(0),
                            PlanName = reader.GetString(1)
                        });
                    }
                }
            }
            return plans;
        }
        private List<Transaction> GetTransactionsByPlanId(int planId)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection conn = fn.getConnection())
            {
                conn.Open();
                string query = "SELECT Date, Amount, TransactionType FROM [Transaction] WHERE PlanId = @PlanId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlanId", planId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactions.Add(new Transaction
                            {
                                Date = reader.GetDateTime(0),
                                Amount = reader.GetDecimal(1),
                                TransactionType = reader.GetBoolean(2)
                            });
                        }
                    }
                }
            }

            // Hiển thị số lượng giao dịch lấy được
            //MessageBox.Show($"Số lượng giao dịch: {transactions.Count}");

            return transactions;
        }
        private void UpdateChart(int planId)
        {
            // Lấy dữ liệu thu chi từ database dựa trên planId
            List<Transaction> transactions = GetTransactionsByPlanId(planId);

            // Xóa dữ liệu cũ khỏi biểu đồ
            chartHomeMenu.Series.Clear();

            // Tạo hai series cho Thu và Chi
            Series incomeSeries = new Series("Thu");
            incomeSeries.ChartType = SeriesChartType.Column;
            Series expenseSeries = new Series("Chi");
            expenseSeries.ChartType = SeriesChartType.Column;

            // Biến để lưu tổng thu và tổng chi
            decimal totalIncome = 0;
            decimal totalExpense = 0;

            // Phân loại dữ liệu vào Thu và Chi
            foreach (var transaction in transactions)
            {
                if (transaction.TransactionType) // Nếu là thu
                {
                    incomeSeries.Points.AddXY(transaction.Date, transaction.Amount);
                    totalIncome += transaction.Amount; // Tính tổng thu
                }
                else // Nếu là chi
                {
                    expenseSeries.Points.AddXY(transaction.Date, transaction.Amount);
                    totalExpense += transaction.Amount; // Tính tổng chi
                }
            }

            // Kiểm tra và thêm ChartArea nếu chưa có
            if (chartHomeMenu.ChartAreas.Count == 0)
            {
                chartHomeMenu.ChartAreas.Add(new ChartArea("MainArea"));
            }

            // Thêm series vào biểu đồ
            chartHomeMenu.Series.Add(incomeSeries);
            chartHomeMenu.Series.Add(expenseSeries);

            // Thiết lập hiển thị biểu đồ
            chartHomeMenu.ChartAreas[0].AxisX.Title = "Thời gian";
            chartHomeMenu.ChartAreas[0].AxisY.Title = "Số tiền";

            // Tạo một đối tượng `CultureInfo` cho định dạng tiền tệ là đồng Việt Nam
            CultureInfo vietnamCulture = new CultureInfo("vi-VN");
            vietnamCulture.NumberFormat.CurrencySymbol = "₫";

            // Cập nhật tổng thu và tổng chi vào các Label với định dạng tiền tệ là đồng
            lblTotalIncome.AutoSize = false; // Tắt AutoSize để tránh thay đổi kích thước tự động
            lblTotalIncome.Text = $"Tổng Thu: {totalIncome.ToString("C0", vietnamCulture)}"; // Định dạng tiền tệ

            lblTotalExpense.AutoSize = false;
            lblTotalExpense.Text = $"Tổng Chi: {totalExpense.ToString("C0", vietnamCulture)}";

            if (totalIncome > 0) // Đảm bảo không chia cho 0
            {
                decimal spendingPercentage = (totalExpense / totalIncome) * 100;

                if (spendingPercentage < 50)
                {
                    lbNhanXet.Text = "Bạn đang chi tiêu khá tiết kiệm.";
                    lbNhanXet.ForeColor = Color.Green;
                    lbNhanXet.Font = new Font(lbNhanXet.Font, FontStyle.Bold);
                }
                else if (spendingPercentage >= 50 && spendingPercentage < 80)
                {
                    lbNhanXet.Text = "Bạn chi tiêu khá ổn đấy!";
                    lbNhanXet.ForeColor = Color.Orange;
                    lbNhanXet.Font = new Font(lbNhanXet.Font, FontStyle.Regular);
                }
                else if (spendingPercentage >= 80 && spendingPercentage < 100)
                {
                    lbNhanXet.Text = "Bạn chi tiêu sắp vượt mức rồi!";
                    lbNhanXet.ForeColor = Color.OrangeRed;
                    lbNhanXet.Font = new Font(lbNhanXet.Font, FontStyle.Bold);
                }
                else
                {
                    lbNhanXet.Text = "Bạn đã vượt mức chi tiêu!";
                    lbNhanXet.ForeColor = Color.Red;
                    lbNhanXet.Font = new Font(lbNhanXet.Font, FontStyle.Bold);
                }
            }
            else
            {
                lbNhanXet.Text = "Không có thu nhập để so sánh chi tiêu.";
                lbNhanXet.ForeColor = Color.Gray;
                lbNhanXet.Font = new Font(lbNhanXet.Font, FontStyle.Italic);
            }
        }

        private void cbChoosePlan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbChoosePlan.SelectedValue is int selectedPlanId)
            {
                UpdateChart(selectedPlanId);
            }
        }
    }
}
