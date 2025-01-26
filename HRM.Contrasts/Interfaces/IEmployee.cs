using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Contrasts.Interfaces
{
    public interface IEmployee
    {
        Task<IEnumerable<EmployeeDto>> GetAllAsync();
        Task<EmployeeDto> GetByIdAsync(Guid id);
        Task AddAsync(EmployeeDto employee);
        Task UpdateAsync(EmployeeDto employee);
        Task DeleteAsync(Guid id);
    }
}