using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartSchool.Controllers
{
    [Route("api/Professor")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController()
        {

        }

        [HttpGet]
        public  IActionResult Get()
        {
            return Ok("Professores: lane, bertrano, leide");
        }

    }
}
