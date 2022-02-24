using Microsoft.AspNetCore.Mvc;
using smartSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartSchool.Controllers
{
    [ApiController]
    [Route("api/Aluno")]    
    public class AlunoConstroller : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>() {
          new Aluno() {
              Id = 1,
              Nome = "Fulano marricota",
              Sobrenome = "Das couves",
              Telefone = "70707070",              
           },
          new Aluno() {
              Id = 2,
              Nome = "maria",
              Sobrenome = "lane",
              Telefone = "70707070",
           },
          new Aluno() {
              Id = 3,
              Nome = "jubileu",
              Sobrenome = "cleito",
              Telefone = "70707070",
           }
        };

        public AlunoConstroller () { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }        

        //api/aluno/1
        [HttpGet("ById/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            return Ok(aluno);
        }

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(
                a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome)
            );
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
           return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
