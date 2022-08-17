﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepoPatternProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPatternProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeNewController : ControllerBase
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeNewController(EmployeeContext EmployeeContext)
        {
            _employeeContext = EmployeeContext;
        }


        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeContext.Employee;
        }

        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            _employeeContext.Employee.Add(employee);
            _employeeContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            employee.id = id;
            _employeeContext.Employee.Update(employee);
            _employeeContext.SaveChanges();
        }


        [HttpDelete]
        public void Delete(int id)
        {
            var emp = _employeeContext.Employee.FirstOrDefault(x => x.id == id);
            if (emp != null)
            {
                _employeeContext.Employee.Remove(emp);
                _employeeContext.SaveChanges();
            }
        }


    }
}

