using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyAPI.Models
{
    public class Orders
    {
        [Key]
        public required string ID { get; set; }

        public required string Customer_Id { get; set; }
        public int Product_Id { get; set; }
        public int Amount { get; set; }

        [ForeignKey("Customer_Id")]
        public Customers? Customers { get; set; }

        [ForeignKey("Product_Id")]
        public Products? Products { get; set; }
    }
}
