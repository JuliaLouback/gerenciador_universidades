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
        private DaoFuncionario daoFuncionario = new DaoFuncionario();
        private DaoSetor daoSetor = new DaoSetor();
        private DaoCurso daoCurso = new DaoCurso();
        private DaoAluno daoAluno = new DaoAluno();

        // ADICIONAR 
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

        public void adicionarCurso(Curso curso)
        {
            daoCurso.addCurso(curso);
        }
        public void adicionarFuncionario(Funcionario funcionario)
        {
            daoFuncionario.addFuncionario(funcionario);
        }

        public void adicionarAluno(Aluno aluno)
        {
            daoAluno.addAluno(aluno);
        }

        // EXCLUIR
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

        public void excluirMateria(int codigo, int codigo2)
        {
            new DaoCurso().excluirMateria(codigo, codigo2);
        }

        public void excluirFuncionario(int verificar)
        {
            new DaoFuncionario().excluirFuncionario(verificar);
        }

        public void excluirAluno(int codigo)
        {
            new DaoAluno().excluirAluno(codigo);
        }

        // PROCURAR

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

        public Funcionario procurarFuncionario(int codigo)
        {
            var pesquisa = new DaoFuncionario().procurarFuncionario(codigo);
            return pesquisa;
        }

        public Funcionario procurarFuncionarioNome(string codigo)
        {
            var pesquisa = new DaoFuncionario().procurarFuncionarioNome(codigo);
            return pesquisa;
        }

        public Aluno procurarAluno(int codigo)
        {
            var pesquisa = new DaoAluno().procurarAluno(codigo);
            return pesquisa; 
        }

        public Aluno procurarAlunoNome(string codigo)
        {
            var pesquisa = new DaoAluno().procurarAlunoNome(codigo);
            return pesquisa;
        }

        // LISTAR

        public List<Professores> listarProfessor()
        {
            var pesquisa = new DaoProfessor().listarProfessor();
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

        public List<Curso> listarCurso()
        {
            var pesquisa = new DaoCurso().listarCurso();
            return pesquisa;
        }

        public List<Funcionario> listarFuncionario()
        {
            var pesquisa = new DaoFuncionario().listarFuncionarios();
            return pesquisa;
        }

        public List<Aluno> listarAluno()
        {
            var pesquisa = new DaoAluno().listarAluno();
            return pesquisa;
        }
    }
}
