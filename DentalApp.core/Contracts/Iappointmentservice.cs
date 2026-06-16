using DentalApp.core.Models;

namespace DentalApp.core.Contracts
{
    public interface IAppointmentService
    {
        ValidationResult Validate(Appointment a);
        void Add(Appointment a);
        void Update(Appointment a);
        void Delete(int id);
        void UpdateStatus(int id, string status);
        Appointment? GetById(int id);
        List<Appointment> GetAll();
        List<Appointment> Search(string query);
    }
}