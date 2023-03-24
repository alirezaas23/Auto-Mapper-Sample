using Microsoft.EntityFrameworkCore;
using WebApplication14.Models;

namespace WebApplication14.Data
{
    public static class SeedDataList
    {
        public static void AddSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1,
                FirstName = "Alireza",
                LastName = "Asgari",
                PhoneNumber = "09910226763"
            });

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 2,
                FirstName = "Habib",
                LastName = "Asgari",
                PhoneNumber = "09999999999"
            });
        }
    }
}
