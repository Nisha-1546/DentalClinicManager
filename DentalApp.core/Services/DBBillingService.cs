using DentalApp.core.Contracts;
using DentalApp.core.Models;
using Microsoft.Data.SqlClient;

namespace DentalApp.core.Services
{
    public class DBBillingService(string conn) : IBillingService
    {
        private readonly string _connectionString = conn;

        // ================= ADD =================
        public void Add(Bill b)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"INSERT INTO Bills
                           (AppointmentId, PatientId, PatientName, Treatment, Doctor, Amount, Status, BillDate)
                           VALUES
                           (@AppointmentId, @PatientId, @PatientName, @Treatment, @Doctor, @Amount, @Status, @BillDate)";

            SqlCommand cmd = new(sql, connection);
            BindParams(cmd, b);
            cmd.ExecuteNonQuery();
        }

        // ================= UPDATE =================
        public void Update(Bill b)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"UPDATE Bills
                           SET AppointmentId=@AppointmentId,
                               PatientId=@PatientId,
                               PatientName=@PatientName,
                               Treatment=@Treatment,
                               Doctor=@Doctor,
                               Amount=@Amount,
                               Status=@Status,
                               BillDate=@BillDate
                           WHERE Id=@Id";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", b.Id);
            BindParams(cmd, b);
            cmd.ExecuteNonQuery();
        }

        // ================= DELETE =================
        public void Delete(int id)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string deleteSql = "DELETE FROM Bills WHERE Id=@Id";
            SqlCommand cmd = new(deleteSql, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();

            string reseedSql = @"
                IF (SELECT COUNT(*) FROM Bills) = 0
                    DBCC CHECKIDENT ('Bills', RESEED, 0);
                ELSE
                BEGIN
                    DECLARE @maxId INT = ISNULL((SELECT MAX(Id) FROM Bills), 0);
                    DBCC CHECKIDENT ('Bills', RESEED, @maxId);
                END";
            SqlCommand reseedCmd = new(reseedSql, connection);
            reseedCmd.ExecuteNonQuery();
        }

        // ================= UPDATE STATUS =================
        public void UpdateStatus(int id, string status)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "UPDATE Bills SET Status=@Status WHERE Id=@Id";
            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.ExecuteNonQuery();
        }

        // ================= GET BY ID =================
        public Bill? GetById(int id)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Bills WHERE Id=@Id";
            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read()) return MapRow(r);
            return null;
        }

        // ================= GET BY APPOINTMENT =================
        public Bill? GetByAppointmentId(int appointmentId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Bills WHERE AppointmentId=@AppointmentId";
            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read()) return MapRow(r);
            return null;
        }

        // ================= GET ALL =================
        public List<Bill> GetAll()
        {
            List<Bill> list = [];

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Bills ORDER BY BillDate DESC";
            SqlCommand cmd = new(sql, connection);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read()) list.Add(MapRow(r));
            return list;
        }

        // ================= SEARCH =================
        public List<Bill> Search(string q)
        {
            List<Bill> list = [];

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"SELECT * FROM Bills
                           WHERE PatientName LIKE @q
                           OR Treatment LIKE @q
                           OR Doctor LIKE @q
                           OR Status LIKE @q
                           ORDER BY BillDate DESC";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@q", "%" + q + "%");
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read()) list.Add(MapRow(r));
            return list;
        }

        // ================= BIND PARAMS =================
        private static void BindParams(SqlCommand cmd, Bill b)
        {
            cmd.Parameters.AddWithValue("@AppointmentId", b.AppointmentId);
            cmd.Parameters.AddWithValue("@PatientId", b.PatientId);
            cmd.Parameters.AddWithValue("@PatientName", b.PatientName);
            cmd.Parameters.AddWithValue("@Treatment", b.Treatment);
            cmd.Parameters.AddWithValue("@Doctor", b.Doctor);
            cmd.Parameters.AddWithValue("@Amount", b.Amount);
            cmd.Parameters.AddWithValue("@Status", b.Status);
            cmd.Parameters.AddWithValue("@BillDate", b.BillDate);
        }

        // ================= MAP ROW =================
        private static Bill MapRow(SqlDataReader r) => new()
        {
            Id = Convert.ToInt32(r["Id"]),
            AppointmentId = Convert.ToInt32(r["AppointmentId"]),
            PatientId = Convert.ToInt32(r["PatientId"]),
            PatientName = r["PatientName"].ToString()!,
            Treatment = r["Treatment"].ToString()!,
            Doctor = r["Doctor"].ToString()!,
            Amount = Convert.ToDecimal(r["Amount"]),
            Status = r["Status"].ToString()!,
            BillDate = Convert.ToDateTime(r["BillDate"])
        };
    }
}