using DentalApp.core.Contracts;
using Microsoft.Data.SqlClient;

namespace DentalApp.core.Services
{
    public class DBDashboardService(string conn) : IDashboardService
    {
        private readonly string _connectionString = conn;

        // ================= TOTAL COUNT =================
        public int GetTotalCount()
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT COUNT(*) FROM Patient";
            SqlCommand cmd = new(sql, connection);
            return (int)cmd.ExecuteScalar();
        }

        // ================= THIS MONTH =================
        public int GetCountThisMonth()
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"SELECT COUNT(*) FROM Patient
                           WHERE MONTH(CreatedAt) = MONTH(GETDATE())
                           AND YEAR(CreatedAt) = YEAR(GETDATE())";
            SqlCommand cmd = new(sql, connection);
            return (int)cmd.ExecuteScalar();
        }

        // ================= THIS WEEK =================
        public int GetCountThisWeek()
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"SELECT COUNT(*) FROM Patient
                           WHERE CreatedAt >= DATEADD(DAY, -7, GETDATE())";
            SqlCommand cmd = new(sql, connection);
            return (int)cmd.ExecuteScalar();
        }

        // ================= TODAY =================
        public int GetCountToday()
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"SELECT COUNT(*) FROM Patient
                           WHERE CAST(CreatedAt AS DATE) = CAST(GETDATE() AS DATE)";
            SqlCommand cmd = new(sql, connection);
            return (int)cmd.ExecuteScalar();
        }

        // ================= MONTHLY COUNT =================
        public Dictionary<string, int> GetMonthlyCount(int months)
        {
            var result = new Dictionary<string, int>();

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"SELECT FORMAT(CreatedAt, 'MMM yyyy') AS Month,
                                  COUNT(*) AS Total
                           FROM Patient
                           WHERE CreatedAt >= DATEADD(MONTH, @months, GETDATE())
                           GROUP BY FORMAT(CreatedAt, 'MMM yyyy'),
                                    YEAR(CreatedAt),
                                    MONTH(CreatedAt)
                           ORDER BY YEAR(CreatedAt),
                                    MONTH(CreatedAt)";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@months", -months);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                result[r["Month"].ToString()!] = Convert.ToInt32(r["Total"]);
            }

            return result;
        }
    }
}