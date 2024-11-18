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
using System.Windows.Forms.DataVisualization.Charting;
using Expense_Management.Class;

namespace Expense_Management.Form_Menu
{
    public partial class Chart_Menu : UserControl
    {
        private Function fn = new Function(); // Giả sử đây là class để kết nối CSDL
        private int userId; // ID của người dùng hiện tại

        public Chart_Menu(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadChartData();
        }

        private void Chart_Menu_Load(object sender, EventArgs e)
        {

        }
        private void LoadChartData()
        {
            // Xóa các series cũ
            summaryChart.Series.Clear();

            // Tạo series cho tổng thu và tổng chi
            Series incomeSeries = new Series("Tổng Thu")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Green
            };

            Series expenseSeries = new Series("Tổng Chi")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Red
            };

            // Lấy dữ liệu kế hoạch từ cơ sở dữ liệu
            List<PlanStatistics> plans = GetPlanStatistics();

            // Thêm dữ liệu cho từng kế hoạch vào biểu đồ
            foreach (var plan in plans)
            {
                incomeSeries.Points.AddXY(plan.PlanName, plan.TotalIncome);
                expenseSeries.Points.AddXY(plan.PlanName, plan.TotalExpense);
            }

            // Thêm series vào biểu đồ
            summaryChart.Series.Add(incomeSeries);
            summaryChart.Series.Add(expenseSeries);

            // Thiết lập trục và tiêu đề biểu đồ
            summaryChart.ChartAreas[0].AxisX.Title = "Kế hoạch";
            summaryChart.ChartAreas[0].AxisY.Title = "Số tiền (₫)";
            summaryChart.Titles.Add("Thống kê tổng thu và tổng chi theo kế hoạch");
        }

        private List<PlanStatistics> GetPlanStatistics()
        {
            List<PlanStatistics> plans = new List<PlanStatistics>();

            using (SqlConnection conn = fn.getConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        P.PlanName,
                        SUM(CASE WHEN T.TransactionType = 1 THEN T.Amount ELSE 0 END) AS TotalIncome,
                        SUM(CASE WHEN T.TransactionType = 0 THEN T.Amount ELSE 0 END) AS TotalExpense
                    FROM [Plan] P
                    LEFT JOIN [Transaction] T ON P.PlanID = T.PlanID
                    WHERE P.UserId = @UserId
                    GROUP BY P.PlanName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            plans.Add(new PlanStatistics
                            {
                                PlanName = reader.GetString(0),
                                TotalIncome = reader.GetDecimal(1),
                                TotalExpense = reader.GetDecimal(2)
                            });
                        }
                    }
                }
            }
            return plans;
        }
    }
}
