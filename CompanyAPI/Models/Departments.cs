using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.Models
{
    public class Departments
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public required string Name { get; set; }
        public required List<Employees> Employees { get; set; }
    }
}
