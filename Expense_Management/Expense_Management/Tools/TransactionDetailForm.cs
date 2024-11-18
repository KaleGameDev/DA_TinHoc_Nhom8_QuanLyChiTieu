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

namespace Expense_Management.Tools
{
    public partial class TransactionDetailForm : Form
    {
        public TransactionDetailForm()
        {
            InitializeComponent();
        }
        private Function fn = new Function();
        private int transactionId;

        public TransactionDetailForm(int transactionId)
        {
            InitializeComponent();
            this.transactionId = transactionId;
            LoadTransactionDetails();

            this.BackColor = Color.LightGray;  // Màu nền xám nhạt cho Form

            DesignDetail();

        }

        private void LoadTransactionDetails()
        {
            string query = "SELECT Date, Amount, TransactionType, Notes, TransactionName FROM [Transaction] WHERE TransactionId = @transactionId";

            using (SqlConnection conn = fn.getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@transactionId", transactionId);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        decimal amount = reader.GetDecimal(1);
                        bool transactionType = reader.GetBoolean(2);
                        string notes = reader.GetString(3);
                        string transactionName = reader.GetString(4);  // Lấy tên giao dịch

                        // Cập nhật thông tin trên form
                        lbDate.Text = $"Ngày: {date.ToShortDateString()}";
                        lbAmount.Text = $"Số tiền: {amount.ToString("#,0")} đ"; // Định dạng tiền với dấu phân cách nghìn và đơn vị "đ"
                        lbType.Text = transactionType ? "Loại: Thu" : "Loại: Chi";
                        lbNote.Text = $"Ghi chú: {notes}";
                        lbNameTrans.Text = $"Tên giao dịch: {transactionName}"; // Hiển thị tên giao dịch
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chi tiết giao dịch.", "Thông báo");
                    }
                }
            }
        }

        private void DesignDetail()
        {
            // Cập nhật màu cho Label
            lbDate.ForeColor = Color.DarkBlue;
            lbAmount.ForeColor = Color.Black;
            lbType.ForeColor = Color.Black;
            lbNote.ForeColor = Color.Black;

            // Tiêu đề
            lbDate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lbDate.ForeColor = Color.Crimson;

            // Ví dụ tạo hiệu ứng mờ khi mở form
            this.Opacity = 0;
            Timer fadeIn = new Timer();
            fadeIn.Interval = 10;
            fadeIn.Tick += (sender, e) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    fadeIn.Stop();
                }
            };
            fadeIn.Start();

        }
        private void TransactionDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void btnXoaTrans_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Kiểm tra nếu người dùng nhấn "Yes" (Đồng ý)
            if (result == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM [Transaction] WHERE TransactionId = @transactionId";

                using (SqlConnection conn = fn.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        conn.Open();

                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh xóa

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa giao dịch thành công.", "Thông báo");
                            this.DialogResult = DialogResult.OK;
                            this.Close(); // Đóng form sau khi xóa thành công
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa giao dịch. Vui lòng thử lại.", "Thông báo");
                        }
                    }
                }
            }
        }
    }
}
