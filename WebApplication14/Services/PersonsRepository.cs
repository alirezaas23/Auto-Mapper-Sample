using Microsoft.EntityFrameworkCore;
using WebApplication14.Data;
using WebApplication14.Models;

namespace WebApplication14.Services
{
    public class PersonsRepository : IPersonsRepository
    {
        private readonly TestDbContext _context;

        public PersonsRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Person>> GetPersonsAsync()
        {
            return await _context.Persons
                .OrderBy(p => p.FirstName)
                .ToListAsync();
        }

        public async Task<Person?> GetPersonByIdAsync(int personId)
        {
            return await _context
                .Persons
                .FirstOrDefaultAsync(p => p.Id == personId);
        }
    }
}
