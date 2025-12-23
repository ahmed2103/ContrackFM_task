using AutoMapper;
using CompanyAPI.DTOs;
using CompanyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly CompanyContext _context;
        private readonly IMapper _mapper;
        public CustomerController(CompanyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _context.Customers.Include(c => c.Orders).ThenInclude(o=> o.Product).ToListAsync();
            var customersDTOs = _mapper.Map<List<CustomerDTO>>(customers);

            return Ok(customersDTOs);
        }
    }
}
