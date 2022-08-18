using ApiCrudUsingGeneric.IService;
using ApiCrudUsingGeneric.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudUsingGeneric.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : GenericController<Patient>
    {
        public PatientsController(IGenericService<Patient> genericService) : base(genericService)
        {

        }
    }
}
