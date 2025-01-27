using HRM.Application.Interfaces;
using HRM.Contrasts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HRM.API.controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _employeeService.GetAllAsync();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeDto employee)
        {
            await _employeeService.AddAsync(employee);
            return Ok();
        }
    }
}