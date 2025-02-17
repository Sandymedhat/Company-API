using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompanyAPI.Data;
using CompanyAPI.DTOs;
using CompanyAPI.Models;


namespace CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeesDto>>> GetEmployees()
        {
            var employees = await _context.Employees
                .Include(e => e.Departments) 
                .Select(static e => new EmployeesDto
                {
                    Id = e.ID,
                    Name = e.Name,
                    DepartmentName = e.Departments.Name 
                })
                .ToListAsync();

            return Ok(employees);
        }
    }
}
