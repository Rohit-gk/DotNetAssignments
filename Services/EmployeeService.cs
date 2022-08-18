using Microsoft.EntityFrameworkCore;
using RepoPatternProject.Models;
using RepoPatternProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPatternProject.Services
{

    public class EmployeeService : IEmployeeRepo
    {
       
        private readonly EmployeeContext employeeContext;
        public EmployeeService()
        {
            //_employeeContext = employeecontext;
            employeeContext = new EmployeeContext();
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            await employeeContext.Employee.AddAsync(employee);
            employeeContext.SaveChanges();
            return employee;
        }

        public async void DeleteEmployee(int id)
        {
            var anim = await employeeContext.Employee.Where(x => x.mobile == id).FirstOrDefaultAsync();
            if (anim != null)
            {
                employeeContext.Employee.Remove(anim);
                await employeeContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await employeeContext.Employee.FirstOrDefaultAsync(a => a.mobile == id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await employeeContext.Employee.ToListAsync();
        }
    }
}

