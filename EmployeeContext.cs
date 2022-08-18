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
        public EmployeeContext()
        {

        }
        //internal static object employee;

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        //public static object employes { get; internal set; }
        public  DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ROHITK;Database=EmployeeDB;Trusted_Connection=True;");
            }
        }
    }
   
}
