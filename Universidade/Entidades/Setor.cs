using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade.Entidades
{
    class Setor
    {
        public int Codigo { get; set; }

        public string Tipo { get; set; }

        public string Localizacao { get; set; }

        public List<Pessoa> Responsavel { get; set; }
    }
}
