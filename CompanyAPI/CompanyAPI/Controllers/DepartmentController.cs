using AutoMapper;
using CompanyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CompanyAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    public class DepartmentController : Controller
    {
        private readonly CompanyContext _context;

        public DepartmentController(CompanyContext context, IMapper mapper)
        {
            _context = context;
        }
        [HttpGet("salary-sum")]
        public async Task<IActionResult> GetSalarySumByDepartment()
        {
            var result = await _context.Departments
                .Select(d => new
                {
                    DepartmentId = d.Id,
                    DepartmentName = d.Name,
                    SalarySum = d.Employees.Sum(e => e.Salary)
                }).ToListAsync();
            return Ok(result);
        }
    }
}
