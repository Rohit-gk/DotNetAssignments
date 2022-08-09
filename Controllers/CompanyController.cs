using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyCrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private List<Company> company = new List<Company>()
            {

                new Company()
                {
                    Id = 1,
                    Name = "IncubXperts",
                    EmpCount = 115,
                    Address = "Nanded city",
                },

                new Company()
                {
                    Id = 2,
                    Name = "Infosys",
                    EmpCount = 1008,
                    Address = "Mumbai",
                }
            };


        [HttpGet]
        [Route("getCompany")]
        public async Task<ActionResult<Company>> GetCompany()
        {
            return Ok(company);
        }



        [HttpGet]
        [Route("getCompanyById")]
        public async Task<ActionResult<Company>> GetCompanyById(int id)
        {
            var companys = company.Find(x => x.Id == id);
            if (companys == null)
                return BadRequest("Company Not Found!");
            return Ok(companys);
        }



        [HttpPost]
        [Route("addCompany")]
        public async Task<ActionResult<Company>> AddCompany(Company request)
        {
            company.Add(request);
            return Ok(company);
        }


        [HttpPut]
        [Route("updateCompany")]
        public async Task<ActionResult<Company>> UpdateCompany(Company request)
        {
            var companys = company.Find(x => x.Id == request.Id);
            if (companys == null)
                return BadRequest("Company Not Found!");
            companys.Name = request.Name;
            companys.EmpCount = request.EmpCount;
            companys.Address = request.Address;
            return Ok(companys);
        }


        [HttpDelete]
        [Route("deleteCompany")]
        public async Task<ActionResult<Company>> DeleteCompany(int id)
        {
            var companys = company.Find(x => x.Id == id);
            if (companys == null)
                return BadRequest("Company Not Found!");

            company.Remove(companys);
            return Ok(companys);
        }
    }
}
