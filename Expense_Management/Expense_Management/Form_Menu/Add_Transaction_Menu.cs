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
using Expense_Management.Class;

namespace Expense_Management.Form_Menu
{
    public partial class Add_Transaction_Menu : UserControl
    {
        private Function fn = new Function(); // Khởi tạo hàm để kết nối CSDL
        private int userId; // ID của người dùng hiện tại
        public Add_Transaction_Menu(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Lưu lại UserID để sử dụng trong các truy vấn
            LoadCategories();
            ViewListDesign();
        }

        private void btnAddTransation_Click(object sender, EventArgs e)
        {
            string categoryName = txtTransationName.Text.Trim();
            bool isIncome = rdThu.Checked; // Nếu rbtnIncome được chọn thì giá trị sẽ là true

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục.", "Thông báo");
                return;
            }

            try
            {
                string query = "INSERT INTO [Category] (CategoryName, IsIncome, UserId) VALUES (@categoryName, @isIncome, @userId)";
                using (SqlConnection conn = fn.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@categoryName", categoryName);
                        cmd.Parameters.AddWithValue("@isIncome", isIncome);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm danh mục thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm danh mục. Vui lòng thử lại.", "Thông báo");
                        }
                    }
                }
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm danh mục: " + ex.Message);
            }
        }

        private void Add_Transaction_Menu_Load(object sender, EventArgs e)
        {

        }

        public void ViewListDesign()
        {
            // Đặt ListBox sang chế độ vẽ tùy chỉnh
            listChi.DrawMode = DrawMode.OwnerDrawFixed;
            listChi.ItemHeight = 30; // Chiều cao của mỗi hàng (pixel)

            listThu.DrawMode = DrawMode.OwnerDrawFixed;
            listThu.ItemHeight = 30; // Chiều cao của mỗi hàng (pixel)

            // Xử lý sự kiện DrawItem để tùy chỉnh việc vẽ các hàng
            listChi.DrawItem += (s, e) =>
            {
                e.DrawBackground();

                // Tạo font với kích thước lớn hơn cho chữ trong dòng
                using (Font font = new Font("Arial", 16, FontStyle.Regular))
                {
                    // Sử dụng StringFormat để căn giữa
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center; // Căn giữa theo chiều dọc

                    // Vẽ chuỗi với font, màu và căn giữa
                    e.Graphics.DrawString(listChi.Items[e.Index].ToString(), font, Brushes.Black, e.Bounds, sf);
                }

                e.DrawFocusRectangle();
            };
            listThu.DrawItem += (s, e) =>
            {
                e.DrawBackground();

                // Tạo font với kích thước lớn hơn cho chữ trong dòng
                using (Font font = new Font("Arial", 16, FontStyle.Regular))
                {
                    // Sử dụng StringFormat để căn giữa
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center; // Căn giữa theo chiều dọc

                    // Vẽ chuỗi với font, màu và căn giữa
                    e.Graphics.DrawString(listThu.Items[e.Index].ToString(), font, Brushes.Black, e.Bounds, sf);
                }

                e.DrawFocusRectangle();
            };
        }

        private void LoadCategories()
        {
            try
            {
                string query = "SELECT [CategoryId], [CategoryName], [IsIncome] FROM [Category] WHERE UserId = @UserId";
                using (SqlConnection conn = fn.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add UserId as a parameter
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Clear old data in ListBox
                        listChi.Items.Clear();
                        listThu.Items.Clear();

                        while (reader.Read())
                        {
                            int categoryId = reader.GetInt32(0);
                            string categoryName = reader.GetString(1);
                            bool isIncome = reader.GetBoolean(2);

                            if (isIncome)
                            {
                                // Add to income list if it's an income category
                                listThu.Items.Add(new ListItem { CategoryId = categoryId, CategoryName = categoryName });
                            }
                            else
                            {
                                // Add to expense list if it's an expense category
                                listChi.Items.Add(new ListItem { CategoryId = categoryId, CategoryName = categoryName });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }
    }
}
