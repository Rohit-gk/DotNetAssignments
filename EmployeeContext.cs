using Microsoft.EntityFrameworkCore;
using RepoPatternProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPatternProject
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public  DbSet<Employee> Employee { get; set; }
    }
   
}
