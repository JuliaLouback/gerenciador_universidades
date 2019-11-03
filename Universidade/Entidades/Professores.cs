using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade.Entidades
{
    class Professores : Pessoa
    { 

        public int Materia_id { get; set; }

        public int Curso_id { get; set; }
    }
}
