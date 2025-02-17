using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompanyAPI.Data;
using CompanyAPI.DTOs;
using CompanyAPI.Models;


namespace CompanyAPI.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly AppDbContext _context;

    public CustomersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<object>>> GetCustomers()
    {
        var customers = await _context.Customers
            .Include(c => c.Orders)
            .ThenInclude(o => o.Products)
            .ToListAsync();

        var result = customers.SelectMany<Customers, object>(c => c.Orders.Any() 
            ? c.Orders.Select<Orders, object>(o => new 
            {
                Customer_Id = c.ID,
                Customer_Name = c.Name,
                Order_Id = o.ID,
                Amount = o.Amount,
                Product_Name = o.Products.Name,
                Total_Cost = o.Amount * o.Products.Cost
            }) 
            : new List<object> 
            {
                new
                {
                    Customer_Id = c.ID,
                    Customer_Name = c.Name,
                    Order_Id = (string)null,
                    Amount = (int?)null,
                    Product_Name = (string)null,
                    Total_Cost = (decimal?)null
                }
            }).ToList();

        return Ok(result);
    }
}
}