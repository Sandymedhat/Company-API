using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public decimal Cost { get; set; }
    }
}
