using WebApplication14.Models;

namespace WebApplication14.Services
{
    public interface IPersonsRepository
    {
        Task<IEnumerable<Person>> GetPersonsAsync();
        Task<Person?> GetPersonByIdAsync(int personId);
    }
}
