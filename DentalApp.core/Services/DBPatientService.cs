using DentalApp.core.Contracts;
using DentalApp.core.Models;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DentalApp.core.Services
{
    public class DBPatientService(string conn) : IPatientService
    {
        private readonly string _connectionString = conn;

        public ValidationResult Validate(Patient p)
        {
            var result = new ValidationResult();

            if (string.IsNullOrWhiteSpace(p.Name))
                result.AddError("Name is required.");
            else if (p.Name.Trim().Length < 2)
                result.AddError("Name must be at least 2 characters.");
            else if (p.Name.Trim().Length > 100)
                result.AddError("Name cannot exceed 100 characters.");
            else if (!Regex.IsMatch(p.Name.Trim(), @"^[a-zA-Z\s]+$"))
                result.AddError("Name can only contain letters and spaces.");

            if (string.IsNullOrWhiteSpace(p.Phone))
                result.AddError("Phone number is required.");
            else if (!Regex.IsMatch(p.Phone.Trim(), @"^\d{11}$"))
                result.AddError("Phone number must be exactly 11 digits (e.g. 03001234567).");

            if (!string.IsNullOrWhiteSpace(p.Email))
            {
                if (!Regex.IsMatch(p.Email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    result.AddError("Email address is not valid.");
                else if (p.Email.Trim().Length > 100)
                    result.AddError("Email cannot exceed 100 characters.");
            }

            if (string.IsNullOrWhiteSpace(p.Address))
                result.AddError("Address is required.");
            else if (p.Address.Trim().Length > 255)
                result.AddError("Address cannot exceed 255 characters.");

            return result;
        }

        public void Add(Patient p)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"INSERT INTO Patient
                           (Name, Phone, Email, Address, CreatedAt)
                           VALUES
                           (@Name, @Phone, @Email, @Address, @CreatedAt)";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Name", p.Name);
            cmd.Parameters.AddWithValue("@Phone", p.Phone);
            cmd.Parameters.AddWithValue("@Email", p.Email ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", p.Address);
            cmd.Parameters.AddWithValue("@CreatedAt", p.CreatedAt);
            cmd.ExecuteNonQuery();
        }

        public void Update(Patient p)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"UPDATE Patient
                           SET Name=@Name,
                               Phone=@Phone,
                               Email=@Email,
                               Address=@Address
                           WHERE Id=@Id";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", p.Id);
            cmd.Parameters.AddWithValue("@Name", p.Name);
            cmd.Parameters.AddWithValue("@Phone", p.Phone);
            cmd.Parameters.AddWithValue("@Email", p.Email ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", p.Address);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string deleteSql = "DELETE FROM Patient WHERE Id=@Id";
            SqlCommand deleteCmd = new(deleteSql, connection);
            deleteCmd.Parameters.AddWithValue("@Id", id);
            deleteCmd.ExecuteNonQuery();

            
        }

        public Patient? GetById(int id)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Patient WHERE Id=@Id";
            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                return new Patient
                {
                    Id = Convert.ToInt32(r["Id"]),
                    Name = r["Name"].ToString(),
                    Phone = r["Phone"].ToString(),
                    Email = r["Email"].ToString(),
                    Address = r["Address"].ToString(),
                    CreatedAt = Convert.ToDateTime(r["CreatedAt"])
                };
            }

            return null;
        }

        public List<Patient> GetAll()
        {
            List<Patient> list = [];

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Patient ORDER BY Id";
            SqlCommand cmd = new(sql, connection);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                list.Add(MapRow(r));
            }

            return list;
        }

        public List<Patient> Search(string q)
        {
            List<Patient> list = [];

            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = @"SELECT * FROM Patient
                   WHERE Name LIKE @q
                   OR Phone LIKE @q
                   OR Email LIKE @q
                   ORDER BY Id";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@q", "%" + q + "%");
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                list.Add(MapRow(r));
            }

            return list;
        }


        public async Task<List<Patient>> GetAllAsync()
        {
            List<Patient> list = [];

            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            string sql = "SELECT * FROM Patient ORDER BY Id";
            SqlCommand cmd = new(sql, connection);
            SqlDataReader r = await cmd.ExecuteReaderAsync();

            while (await r.ReadAsync())
            {
                list.Add(MapRow(r));
            }

            return list;
        }

        public async Task<List<Patient>> SearchAsync(string q)
        {
            List<Patient> list = [];

            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            string sql = @"SELECT * FROM Patient
                   WHERE Name LIKE @q
                   OR Phone LIKE @q
                   OR Email LIKE @q
                   ORDER BY Id";

            SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@q", "%" + q + "%");
            SqlDataReader r = await cmd.ExecuteReaderAsync();

            while (await r.ReadAsync())
            {
                list.Add(MapRow(r));
            }

            return list;
        }

        private static Patient MapRow(SqlDataReader r) => new()
        {
            Id = Convert.ToInt32(r["Id"]),
            Name = r["Name"].ToString(),
            Phone = r["Phone"].ToString(),
            Email = r["Email"].ToString(),
            Address = r["Address"].ToString(),
            CreatedAt = Convert.ToDateTime(r["CreatedAt"])
        };
    }
}
