public class CustomerOrderDto
{
    public required string Customer_Id { get; set; }
    public required string Customer_Name { get; set; }
    public required string Order_Id { get; set; }
    public decimal? Amount { get; set; }
    public required string Product_Name { get; set; }
    public decimal? Total_Cost { get; set; }
}
