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
        private DaoCoodenador daoCoordenador = new DaoCoodenador();
        public void adicionarProfessor(Professores professor)
        {
            daoProfessor.addProfessor(professor);
        }

        public void adicionarCoordenador(Coordenador coordenador)
        {
            daoCoordenador.addCoordenador(coordenador);
        }

        public void excluirProfessor(int verificar)
        {
            new DaoProfessor().excluirProfessor(verificar);
        }

        public void excluirCoordenador(int verificar)
        {
            new DaoCoodenador().excluirCoordenador(verificar);
        }

        public Coordenador procurarCoordenador(int NR)
        {
            var pesquisa = new DaoCoodenador().procurarCoordenador(NR);
            return pesquisa;
        }

        public List<Professores> listarProfessor()
        {
            var pesquisa = new  DaoProfessor().listarProfessor();
            return pesquisa;
        }


    }
}
