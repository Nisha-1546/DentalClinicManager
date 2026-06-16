using DentalApp.core.Contracts;
using DentalApp.core.Models;
using Microsoft.Data.SqlClient;

namespace DentalApp.core.Services
{
    public class DBAppointmentService(string conn) : IAppointmentService
    {
        private readonly string _connectionString = conn;

       
        public ValidationResult Validate(Appointment a)
        {
            var result = new ValidationResult();

            if (a.PatientId <= 0)
                result.AddError("Please select a patient.");

            if (string.IsNullOrWhiteSpace(a.Doctor))
                result.AddError("Doctor name is required.");
            else if (a.Doctor.Trim().Length < 2)
                result.AddError("Doctor name must be at least 2 characters.");
            else if (a.Doctor.Trim().Length > 100)
                result.AddError("Doctor name cannot exceed 100 characters.");

            if (a.AppDate == default)
                result.AddError("Appointment date is required.");

            if (a.AppTime == default)
                result.AddError("Appointment time is required.");

            if (string.IsNullOrWhiteSpace(a.Treatment))
                result.AddError("Treatment is required.");
            else if (a.Treatment.Trim().Length > 200)
                result.AddError("Treatment cannot exceed 200 characters.");

            if (a.Cost < 0)
                result.AddError("Cost cannot be negative.");

            if (!string.IsNullOrWhiteSpace(a.Notes) && a.Notes.Trim().Length > 500)
                result.AddError("Notes cannot exceed 500 characters.");

            return result;
        }

     
        public void Add(Appointment a)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"INSERT INTO Appointment
                           (PatientId, PatientName, Doctor, AppDate, AppTime,
                            Treatment, Cost, Status, Notes, CreatedAt)
                           VALUES
                           (@PatientId, @PatientName, @Doctor, @AppDate, @AppTime,
                            @Treatment, @Cost, @Status, @Notes, @CreatedAt)";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@PatientId", a.PatientId);
            cmd.Parameters.AddWithValue("@PatientName", a.PatientName);
            cmd.Parameters.AddWithValue("@Doctor", a.Doctor);
            cmd.Parameters.AddWithValue("@AppDate", a.AppDate);
            cmd.Parameters.AddWithValue("@AppTime", a.AppTime);
            cmd.Parameters.AddWithValue("@Treatment", a.Treatment);
            cmd.Parameters.AddWithValue("@Cost", a.Cost);
            cmd.Parameters.AddWithValue("@Status", a.Status);
            cmd.Parameters.AddWithValue("@Notes", a.Notes ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@CreatedAt", a.CreatedAt);
            cmd.ExecuteNonQuery();
        }

        
        public void Update(Appointment a)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"UPDATE Appointment
                           SET PatientId=@PatientId,
                               PatientName=@PatientName,
                               Doctor=@Doctor,
                               AppDate=@AppDate,
                               AppTime=@AppTime,
                               Treatment=@Treatment,
                               Cost=@Cost,
                               Status=@Status,
                               Notes=@Notes
                           WHERE Id=@Id";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", a.Id);
            cmd.Parameters.AddWithValue("@PatientId", a.PatientId);
            cmd.Parameters.AddWithValue("@PatientName", a.PatientName);
            cmd.Parameters.AddWithValue("@Doctor", a.Doctor);
            cmd.Parameters.AddWithValue("@AppDate", a.AppDate);
            cmd.Parameters.AddWithValue("@AppTime", a.AppTime);
            cmd.Parameters.AddWithValue("@Treatment", a.Treatment);
            cmd.Parameters.AddWithValue("@Cost", a.Cost);
            cmd.Parameters.AddWithValue("@Status", a.Status);
            cmd.Parameters.AddWithValue("@Notes", a.Notes ?? (object)DBNull.Value);
            cmd.ExecuteNonQuery();
        }

        
        public void Delete(int id)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string deleteSql = "DELETE FROM Appointment WHERE Id=@Id";
            SqlCommand cmd = new(deleteSql, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();

           
            string reseedSql = @"
                IF (SELECT COUNT(*) FROM Appointment) = 0
                    DBCC CHECKIDENT ('Appointment', RESEED, 0);
                ELSE
                BEGIN
                    DECLARE @maxId INT = ISNULL((SELECT MAX(Id) FROM Appointment), 0);
                    DBCC CHECKIDENT ('Appointment', RESEED, @maxId);
                END";
            SqlCommand reseedCmd = new(reseedSql, connection);
            reseedCmd.ExecuteNonQuery();
        }

        
        public void UpdateStatus(int id, string status)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "UPDATE Appointment SET Status=@Status WHERE Id=@Id";
            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.ExecuteNonQuery();
        }

      
        public Appointment? GetById(int id)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Appointment WHERE Id=@Id";
            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read()) return MapRow(r);
            return null;
        }

     
        public List<Appointment> GetAll()
        {
            List<Appointment> list = [];

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Appointment ORDER BY AppDate DESC, AppTime DESC";
            SqlCommand cmd = new(sql, connection);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read()) list.Add(MapRow(r));
            return list;
        }

       
        public List<Appointment> Search(string q)
        {
            List<Appointment> list = [];

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"SELECT * FROM Appointment
                           WHERE PatientName LIKE @q
                           OR Doctor LIKE @q
                           OR Treatment LIKE @q
                           OR Status LIKE @q
                           ORDER BY AppDate DESC, AppTime DESC";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@q", "%" + q + "%");
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read()) list.Add(MapRow(r));
            return list;
        }

     
        private static Appointment MapRow(SqlDataReader r) => new()
        {
            Id = Convert.ToInt32(r["Id"]),
            PatientId = Convert.ToInt32(r["PatientId"]),
            PatientName = r["PatientName"].ToString()!,
            Doctor = r["Doctor"].ToString()!,
            AppDate = Convert.ToDateTime(r["AppDate"]),
            AppTime = (TimeSpan)r["AppTime"],
            Treatment = r["Treatment"].ToString()!,
            Cost = Convert.ToDecimal(r["Cost"]),
            Status = r["Status"].ToString()!,
            Notes = r["Notes"] == DBNull.Value ? null : r["Notes"].ToString(),
            CreatedAt = Convert.ToDateTime(r["CreatedAt"])
        };
    }
}