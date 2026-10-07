using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data
{
    internal static class Database
    {
        internal static int Execute(string sql, Action<SqlParameterCollection> setParameters)
        {
            using (var connection = OpenConnection())
            using (var command = new SqlCommand(sql, connection))
            {
                setParameters(command.Parameters);
                return command.ExecuteNonQuery();
            }
        }

        internal static DataTable Query(string sql)
        {
            using (var connection = OpenConnection())
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                var result = new DataTable();
                adapter.Fill(result);
                return result;
            }
        }

        internal static void LoadGrid(DataGridView grid, string sql)
        {
            DataTable data = Query(sql);
            if (data.Columns.Count != grid.Columns.Count)
            {
                throw new InvalidOperationException("Số cột dữ liệu không khớp với danh sách hiển thị.");
            }

            grid.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                var values = new object[data.Columns.Count];
                for (int index = 0; index < values.Length; index++)
                {
                    values[index] = row.IsNull(index) ? null : row[index];
                }

                grid.Rows.Add(values);
            }

            grid.ClearSelection();
        }

        internal static string SaveError(Exception error, string item)
        {
            var sqlError = error as SqlException;
            if (sqlError != null)
            {
                if (sqlError.Number == 2627 || sqlError.Number == 2601)
                    return "Mã " + item + " đã tồn tại. Hãy nhập mã khác.";

                if (sqlError.Number == 547)
                    return "Dữ liệu liên kết không tồn tại hoặc có giá trị không hợp lệ. Hãy kiểm tra lại thông tin.";
            }

            return "Không thể lưu " + item + ": " + error.Message;
        }

        internal static SqlConnection OpenConnection()
        {
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["QuanLyBanMayTinh"];

            if (setting == null || string.IsNullOrWhiteSpace(setting.ConnectionString))
            {
                throw new InvalidOperationException("Chưa cấu hình kết nối QuanLyBanMayTinh trong App.config.");
            }

            var connection = new SqlConnection(setting.ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
