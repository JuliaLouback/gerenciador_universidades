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
        private DaoSetor daoSetor = new DaoSetor();

        public void adicionarProfessor(Professores professor)
        {
            daoProfessor.addProfessor(professor);
        }

        public void adicionarCoordenador(Coordenador coordenador)
        {
            daoCoordenador.addCoordenador(coordenador);
        }

        public void adicionarSetores(Setor setor)
        {
            daoSetor.addSetor(setor);
        }

        public void adicionarSetores(int verificar)
        {
            new DaoSetor().excluirSetor(verificar);
        }

        public void excluirProfessor(int verificar)
        {
            new DaoProfessor().excluirProfessor(verificar);
        }

        public void excluirCoordenador(int verificar)
        {
            new DaoCoodenador().excluirCoordenador(verificar);
        }

        public void excluirSetor(int verificar)
        {
            new DaoSetor().excluirSetor(verificar);
        }

        public Coordenador procurarCoordenador(int NR)
        {
            var pesquisa = new DaoCoodenador().procurarCoordenador(NR);
            return pesquisa;
        }

        public Setor procurarSetor(int codigo)
        {
            var pesquisa = new DaoSetor().procurarSetor(codigo);
            return pesquisa;
        }

        public List<Professores> listarProfessor()
        {
            var pesquisa = new  DaoProfessor().listarProfessor();
            return pesquisa;
        }

        public List<Setor> listarSetor()
        {
            var pesquisa = new DaoSetor().listarSetor();
            return pesquisa;
        }

    }
}
