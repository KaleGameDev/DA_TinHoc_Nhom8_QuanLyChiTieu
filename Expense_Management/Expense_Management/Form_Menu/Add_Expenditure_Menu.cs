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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Expense_Management.Form_Menu;

namespace Expense_Management.Form_Menu
{
    public partial class Add_Expenditure_Menu : UserControl
    {

        private int userId; // ID của người dùng hiện tại
        public Add_Expenditure_Menu(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Lưu lại UserID để sử dụng trong các truy vấn
            LoadCategories();
            LoadPlans();
        }

        private void Add_Expenditure_Menu_Load(object sender, EventArgs e)
        {

        }
        private void LoadCategories()
        {
            Function function = new Function();
            string query = "SELECT CategoryId, CategoryName FROM [Category] WHERE UserId = " + userId;

            // Gọi phương thức getForCombo và truyền chuỗi câu lệnh SQL
            SqlDataReader reader = function.getForCombo(query);

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            cbAddTradeCategory.DataSource = dataTable;
            cbAddTradeCategory.DisplayMember = "CategoryName";
            cbAddTradeCategory.ValueMember = "CategoryId";
        }

        private void LoadPlans()
        {
            Function function = new Function();
            string query = "SELECT PlanId, PlanName FROM [Plan] WHERE UserId = " + userId;  // Truyền userId trực tiếp vào câu lệnh SQL

            // Gọi phương thức getForCombo và truyền câu lệnh SQL
            SqlDataReader reader = function.getForCombo(query);

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            cbAddTradePlan.DataSource = dataTable;
            cbAddTradePlan.DisplayMember = "PlanName";
            cbAddTradePlan.ValueMember = "PlanId";
        }

        private void btnSaveTrade_Click(object sender, EventArgs e)
        {
            try
            {
                Function fn = new Function();
                // Lấy thông tin từ các điều khiển
                string txtTransactionName = txtAddTradeName.Text;
                decimal txtTransactionAmount = decimal.Parse(txtAddTradeAmount.Text);
                int txtCategory = (int)cbAddTradeCategory.SelectedValue; // Chuyển đổi SelectedValue sang int
                int txtPlan = (int)cbAddTradePlan.SelectedValue; // Lấy giá trị của PlanID
                DateTime txtDate = dpTime.Value; // Lấy giá trị từ DateTimePicker
                string txtNote = txtAddTradeNote.Text;
                bool txtTransactionType = rdAddTradeThu.Checked; // Kiểm tra nếu là giao dịch thu

                // Tạo câu truy vấn SQL để lưu giao dịch
                string query = "INSERT INTO [Transaction] (TransactionName, Amount, CategoryId, PlanId, UserId, Date, Notes, TransactionType) VALUES (@TransactionName, @Amount, @CategoryId, @PlanId, @UserId, @Date, @Notes, @TransactionType)";

                // Tạo SqlCommand và thêm các tham số
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@TransactionName", txtTransactionName);
                cmd.Parameters.AddWithValue("@Amount", txtTransactionAmount);
                cmd.Parameters.AddWithValue("@CategoryId", txtCategory);
                cmd.Parameters.AddWithValue("@PlanId", txtPlan);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Date", txtDate);
                cmd.Parameters.AddWithValue("@Notes", txtNote);
                cmd.Parameters.AddWithValue("@TransactionType", txtTransactionType ? 1 : 0); // 1 = Thu, 0 = Chi

                // Gọi phương thức lưu dữ liệu
                fn.setData(cmd, "Giao dịch đã được lưu thành công.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho số tiền: " + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lưu vào cơ sở dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }
        }

        private void btnAddTradeCategory_Click(object sender, EventArgs e)
        {
            // Lấy tham chiếu đến Form chính
            var mainForm = (Main_Form)this.TopLevelControl;
            // Tạo một instance của Add_Plan_Menu và hiển thị nó
            var addCategoryMenu = new Add_Transaction_Menu(userId);
            mainForm.ShowUserControl(addCategoryMenu);
        }

        private void btnAddTradePlan_Click(object sender, EventArgs e)
        {
            // Lấy tham chiếu đến Form chính
            var mainForm = (Main_Form)this.TopLevelControl;
            var addPlanMenu = new Add_Plan_Menu(userId);
            mainForm.ShowUserControl(addPlanMenu);
        }

    }
}
