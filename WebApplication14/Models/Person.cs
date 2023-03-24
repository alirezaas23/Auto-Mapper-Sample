using System.ComponentModel.DataAnnotations;

namespace WebApplication14.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(11)]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
