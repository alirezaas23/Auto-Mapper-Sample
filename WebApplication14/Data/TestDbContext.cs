using Microsoft.EntityFrameworkCore;
using WebApplication14.Models;

namespace WebApplication14.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedDataList.AddSeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
