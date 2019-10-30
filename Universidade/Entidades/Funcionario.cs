using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade.Entidades
{
    class Funcionario : Pessoa
    {
        public string Setor { get; set; }
        public string Cargo { get; set; }
        public int CargaHoraria { get; set; }
    }
}
