namespace DentalApp.core.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string Doctor { get; set; } = string.Empty;
        public DateTime AppDate { get; set; } = DateTime.Today;
        public TimeSpan AppTime { get; set; } = TimeSpan.FromHours(9);
        public string Treatment { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public string Status { get; set; } = "Scheduled";
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}