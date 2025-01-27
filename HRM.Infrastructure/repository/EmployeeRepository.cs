using HRM.Contrasts.Interfaces;
using HRM.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly ApplicationDBContext _context;

        public EmployeeRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task AddAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
    }
}