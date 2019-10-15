using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.DAO;
using Universidade.Entidades;

namespace Universidade.Controler
{
    class ControleClass
    {
        private DaoProfessor daoProfessor = new DaoProfessor();
        public void adicionarProfessor(Professores professor)
        {
            daoProfessor.addProfessor(professor);
        }
    }
}
