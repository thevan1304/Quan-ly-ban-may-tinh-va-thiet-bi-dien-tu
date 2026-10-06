using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Quản_lý_bán_máy_tính_và_thiết_bị_điện_tử.Data
{
    internal static class Database
    {
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
