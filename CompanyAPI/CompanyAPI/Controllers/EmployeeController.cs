using AutoMapper;
using CompanyAPI.DTOs;
using CompanyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly CompanyContext _context;
        private readonly IMapper _mapper;

        public EmployeeController(CompanyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _context.Employees.Include(e => e.Department).ToListAsync();
            var employeeDTOs = _mapper.Map<List<EmployeeDTO>>(employees);
            return Ok(employeeDTOs);
        }
    }
}
