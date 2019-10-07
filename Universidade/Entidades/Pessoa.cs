using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    class Pessoa
    {
        public int RA { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public string EstadoCivil { get; set; }

        public string TipoUsuario { get; set; }

        public Telefone Telefone { get; set; }

        public Endereco Endereco { get; set; }
    }
}
