using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Contrasts.DTOs;

namespace HRM.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllAsync();
        Task AddAsync(EmployeeDto employee);
    }
}