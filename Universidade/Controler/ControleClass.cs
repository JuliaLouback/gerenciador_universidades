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
        private DaoCurso daoCurso = new DaoCurso();

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

        public void excluirCurso(int verificar)
        {
            new DaoCurso().excluirCurso(verificar);
        }


        public Coordenador procurarCoordenador(int NR)
        {
            var pesquisa = new DaoCoodenador().procurarCoordenador(NR);
            return pesquisa;
        }

        public Coordenador procurarCoordenadorNome(string Nome)
        {
            var pesquisa = new DaoCoodenador().procurarCoordenadorNome(Nome);
            return pesquisa;
        }

        public Setor procurarSetor(int codigo)
        {
            var pesquisa = new DaoSetor().procurarSetor(codigo);
            return pesquisa;
        }

        public Professores procurarProfessor(int codigo)
        {
            var pesquisa = new DaoProfessor().procurarProfessor(codigo);
            return pesquisa;
        }

        public void excluirMateria(int codigo, int codigo2)
        {
           new DaoCurso().excluirMateria(codigo, codigo2);
        }

        public Professores procurarProfessorNome(string codigo)
        {
            var pesquisa = new DaoProfessor().procurarProfessorNome(codigo);
            return pesquisa;
        }

        public List<Materias> procurarMateria(int verificar, int v)
        {
            List<Materias> listinha = new List<Materias>();
            listinha = new DaoCurso().procurarMateria(verificar, v);
            return listinha;
        }

        public Materias procurarMateriaNome(int codigo, string item)
        {
            var pesquisa = new DaoCurso().procurarMateriaNome(codigo, item);
            return pesquisa;
        }

        public Curso procurarCurso(int codigo)
        {
            var pesquisa = new DaoCurso().procurarCurso(codigo);
            return pesquisa;
        }

        public List<Professores> listarProfessor()
        {
            var pesquisa = new  DaoProfessor().listarProfessor();
            return pesquisa;
        }

        public List<Coordenador> listarCoordenador()
        {
            var pesquisa = new DaoCoodenador().listarCoordenador();
            return pesquisa;
        }

        public List<Setor> listarSetor()
        {
            var pesquisa = new DaoSetor().listarSetor();
            return pesquisa;
        }

        //Cursos 

        public void adicionarCurso(Curso curso)
        {
            daoCurso.addCurso(curso);
        }

        public List<Curso> listarCurso()
        {
            var pesquisa = new DaoCurso().listarCurso();
            return pesquisa;
        }

    }
}
