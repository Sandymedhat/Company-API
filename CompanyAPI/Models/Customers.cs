using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.Models
{
    public class Customers
    {
        [Key]
        public required string ID { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Address { get; set; }
        public required List<Orders> Orders { get; set; }
    }

}
