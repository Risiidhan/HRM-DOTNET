using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Contracts.Interfaces;

namespace HRM.Application.services
{
    public class EmployeeService: IEmployee
    {
         private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();
            return employees.Select(e => new EmployeeDto
            {
                Id = e.Id,
                Name = e.Name,
                Email = e.Email,
                Salary = e.Salary
            });
        }

        public async Task AddAsync(EmployeeDto employee)
        {
            await _employeeRepository.AddAsync(new HRM.Domain.Entities.Employee
            {
                Id = Guid.NewGuid(),
                Name = employee.Name,
                Email = employee.Email,
                Salary = employee.Salary
            });
        }
    }
}