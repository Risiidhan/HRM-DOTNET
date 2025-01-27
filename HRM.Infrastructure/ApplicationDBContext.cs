using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}