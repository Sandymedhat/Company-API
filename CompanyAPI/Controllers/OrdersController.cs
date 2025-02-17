using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompanyAPI.Data;
using CompanyAPI.DTOs;
using CompanyAPI.Models;


namespace CompanyAPI.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly AppDbContext _context;

    public OrdersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders()
    {
        var orders = await _context.Orders
            .Include(o => o.Products)
            .OrderByDescending(o => o.ID)
            .Select(o => new OrderDto
            {
                Order_Id = o.ID,
                Product_Id = o.Product_Id,
                Product_Name = o.Products.Name
            })
            .ToListAsync();

        return Ok(orders);
    }
}
}
