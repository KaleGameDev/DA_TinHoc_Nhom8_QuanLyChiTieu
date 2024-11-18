using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Expense_Management
{
    internal class Function
    {
        public SqlConnection getConnection()
        {
            // Kết nối với chuỗi SQL đã được chỉ định
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\ExpenseManagementSQL\ExpenseManagement.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"
            };
            return conn;
        }
        // Phương thức này nhận một truy vấn SQL dưới dạng chuỗi
        // Tạo một kết nối tới cơ sở dữ liệu và thực hiện truy vấn để lấy dữ liệu
        public DataSet getData(String query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection =conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        // Phương thức này được sử dụng để thực hiện các truy vấn SQL không trả về dữ liệu (như INSERT, UPDATE, DELETE)
        public void setData(String query, String message)
        { 
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(message,"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void setData(SqlCommand cmd, String message)
        {
            using (SqlConnection conn = getConnection())
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery(); // Thực hiện câu lệnh
            }

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Phương thức này được sử dụng để thực hiện truy vấn SQL và trả về một SqlDataReader, cho phép đọc dữ liệu tuần tự từ cơ sở dữ liệu
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

    }
}
