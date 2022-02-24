using System.Collections.Generic;

namespace smartSchool.Models
{
    public class Professor
    {
        public Professor()
        {

        }
        public Professor(int id, string nome, IEnumerable<Disciplina> disciplinas)
        {
            Id = id;
            Nome = nome;    
            Disciplinas = disciplinas;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }

    }
}
