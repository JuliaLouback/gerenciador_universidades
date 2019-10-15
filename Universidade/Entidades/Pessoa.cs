using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    class Pessoa
    {
        public int NR { get; set; }
        public string CPF { get; set; }

        public string Email { get; set; }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public string EstadoCivil { get; set; }

        public string TipoUsuario { get; set; }

        public Telefone Telefone { get; set; }

        public Endereco Endereco { get; set; }
    }
}
