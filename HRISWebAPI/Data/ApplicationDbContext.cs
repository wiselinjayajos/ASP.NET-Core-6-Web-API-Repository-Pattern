using HRISWebAPI.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HRISWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; } 

    }
}
