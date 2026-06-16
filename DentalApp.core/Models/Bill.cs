namespace DentalApp.core.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string Treatment { get; set; } = string.Empty;
        public string Doctor { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Status { get; set; } = "Unpaid";
        public DateTime BillDate { get; set; } = DateTime.Now;
    }
}