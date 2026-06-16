using DentalApp.core.Models;

namespace DentalApp.core.Contracts
{
    public interface IBillingService
    {
        void Add(Bill bill);
        void Update(Bill bill);
        void Delete(int id);
        void UpdateStatus(int id, string status);
        Bill? GetById(int id);
        Bill? GetByAppointmentId(int appointmentId);
        List<Bill> GetAll();
        List<Bill> Search(string query);
    }
}