
using HRM.Contrasts.Interfaces;
using HRM.Contrasts.DTOs;
using HRM.Application.Interfaces;
using HRM.Domain.Models;

namespace HRM.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

       public async Task<IEnumerable<EmployeeDto>> GetAllAsync()
        {
            // Fetch domain entities from repository
            var employees = await _employeeRepository.GetAllAsync();

            // Transform domain entities into DTOs
            return employees.Select(e => new EmployeeDto
            {
                Id = e.Id,
                Name = e.Name,
                Email = e.Email,
                Salary = e.Salary
            });
        }

        public async Task AddAsync(EmployeeDto employeeDto)
        {
            // Transform DTO into domain entity
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                Name = employeeDto.Name,
                Email = employeeDto.Email,
                Salary = (decimal)employeeDto.Salary
            };

            // Add domain entity to repository
            await _employeeRepository.AddAsync(employee);
        }
    }
}