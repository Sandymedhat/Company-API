using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompanyAPI.Data;
using CompanyAPI.DTOs;
using CompanyAPI.Models;

namespace CompanyAPI.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class SalarySumController : ControllerBase
{
    private readonly AppDbContext _context;

    public SalarySumController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DepartmentSalaryDto>>> GetSalarySum()
    {
        var departmentSalaries = await _context.Departments
            .Select(d => new DepartmentSalaryDto
            {
                Department_Id = d.ID,
                Department_Name = d.Name,
                Sum_Salary = d.Employees.Sum(e => e.Salary)
            })
            .ToListAsync();

        return Ok(departmentSalaries);
    }
}
}
