using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Domain.Models;

namespace HRM.Contrasts.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task AddAsync(Employee employee);
    }
}