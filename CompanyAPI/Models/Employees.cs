using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyAPI.Models
{
    public class Employees
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public int Department_Id { get; set; }

        [ForeignKey("Department_Id")]
        public Departments? Departments { get; set; }
    }
}
