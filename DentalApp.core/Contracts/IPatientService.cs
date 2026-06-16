using DentalApp.core.Models;

namespace DentalApp.core.Contracts
{
    public interface IPatientService
    {
        ValidationResult Validate(Patient patient);
        void Add(Patient patient);
        void Update(Patient patient);
        void Delete(int id);
        Patient? GetById(int id);

        Task<List<Patient>> SearchAsync(string query);
        Task<List<Patient>> GetAllAsync(); 
    }
}