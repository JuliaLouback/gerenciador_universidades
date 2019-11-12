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
        private DaoCargo daoCargo = new DaoCargo();

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
            daoSetor.excluirSetor(verificar);
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

        public void adicionarCargo(Cargo cargo)
        {
            daoCargo.addCargo(cargo);
        }

        // EXCLUIR
        public void excluirProfessor(int verificar)
        {
            daoProfessor.excluirProfessor(verificar);
        }

        public void excluirCoordenador(int verificar)
        {
            daoCoordenador.excluirCoordenador(verificar);
        }

        public void excluirSetor(int verificar)
        {
            daoSetor.excluirSetor(verificar);
        }

        public void excluirCurso(int verificar)
        {
            daoCurso.excluirCurso(verificar);
        }

        public void excluirMateria(int codigo, int codigo2)
        {
            daoCurso.excluirMateria(codigo, codigo2);
        }

        public void excluirFuncionario(int verificar)
        {
            daoFuncionario.excluirFuncionario(verificar);
        }

        public void excluirAluno(int codigo)
        {
           daoAluno.excluirAluno(codigo);
        }

        public void excluirCargo(int codigo)
        {
            daoCargo.excluirCargo(codigo);
        }

        // PROCURAR

        public Coordenador procurarCoordenador(int NR)
        {
            var pesquisa = daoCoordenador.procurarCoordenador(NR);
            return pesquisa;
        }

        public Coordenador procurarCoordenadorNome(string Nome)
        {
            var pesquisa = daoCoordenador.procurarCoordenadorNome(Nome);
            return pesquisa;
        }

        public List<Curso> procurarCursoCodigo(int item)
        {
            List<Curso> listinha = daoCurso.procurarCursoCodigo(item);
            return listinha;
        }

        public List<Curso> procurarCursosNome(string item)
        {
            List<Curso> listinha = daoCurso.procurarCursosNome(item);
            return listinha;
        }

        public Setor procurarSetor(int codigo)
        {
            var pesquisa = daoSetor.procurarSetor(codigo);
            return pesquisa;
        }

        public Professores procurarProfessor(int codigo)
        {
            var pesquisa = daoProfessor.procurarProfessor(codigo);
            return pesquisa;
        }

        public Professores procurarProfessorNome(string codigo)
        {
            var pesquisa = daoProfessor.procurarProfessorNome(codigo);
            return pesquisa;
        }

        public List<Materias> procurarMateria(int verificar, int v)
        {
            List<Materias> listinha = new List<Materias>();
            listinha = daoCurso.procurarMateria(verificar, v);
            return listinha;
        }

        public Materias procurarMateriaNome(int codigo, string item)
        {
            var pesquisa = daoCurso.procurarMateriaNome(codigo, item);
            return pesquisa;
        }


        public Curso procurarCurso(int codigo)
        {
            var pesquisa = daoCurso.procurarCurso(codigo);
            return pesquisa;
        }

        public Funcionario procurarFuncionario(int codigo)
        {
            var pesquisa = daoFuncionario.procurarFuncionario(codigo);
            return pesquisa;
        }

        public Funcionario procurarFuncionarioNome(string codigo)
        {
            var pesquisa = daoFuncionario.procurarFuncionarioNome(codigo);
            return pesquisa;
        }

        public Aluno procurarAluno(int codigo)
        {
            var pesquisa = daoAluno.procurarAluno(codigo);
            return pesquisa; 
        }


        public Aluno procurarAlunoNome(string codigo)
        {
            var pesquisa = daoAluno.procurarAlunoNome(codigo);
            return pesquisa;
        }

        public Curso procurarCursoNome(string codigo)
        {
            var pesquisa = daoCurso.procurarCursoNome(codigo);
            return pesquisa;
        }

        public string procurarCursoNomes(int codigo)
        {
            var pesquisa = daoCurso.procurarCursoNomes(codigo);
            return pesquisa;
        }


        public Setor procurarSetorNome(string codigo)
        {
            var pesquisa = daoSetor.procurarSetorNome(codigo);
            return pesquisa;
        }

        public string procurarSetorNomes(int codigo)
        {
            var pesquisa = daoSetor.procurarSetorNomes(codigo);
            return pesquisa;
        }

        internal List<Aluno> listarAlunoNome(object text)
        {
            throw new NotImplementedException();
        }

        public string procurarMateriasNomes(int codigo, int codigo2)
        {
            var pesquisa = daoCurso.procurarMateriasNomes(codigo, codigo2);
            return pesquisa;
        }

        public Cargo procurarCargo(int codigo)
        {
            var pesquisa = daoCargo.procurarCargo(codigo);
            return pesquisa;
        }

        public Cargo procurarCargoNome(int item, string codigo)
        {
            var pesquisa = daoCargo.procurarCargoNome(item, codigo);
            return pesquisa;
        }

        public string procurarCargoNomes(int item)
        {
            var pesquisa = daoCargo.procurarCargoNomes(item);
            return pesquisa;
        }


        // LISTAR

        public List<Professores> listarProfessor()
        {
            var pesquisa = daoProfessor.listarProfessor();
            return pesquisa;
        }

        public List<Coordenador> listarCoordenador()
        {
            var pesquisa = daoCoordenador.listarCoordenador();
            return pesquisa;
        }

        public List<Coordenador> listarCoordenadorCodigo(int item)
        {
            var pesquisa = daoCoordenador.listarCoordenadorCodigo(item);
            return pesquisa;
        }

        public List<Coordenador> listarCoordenadorNome(string item)
        {
            var pesquisa = daoCoordenador.listarCoordenadorNome(item);
            return pesquisa;
        }

        public List<Setor> listarSetor()
        {
            var pesquisa = daoSetor.listarSetor();
            return pesquisa;
        }

        public List<Setor> listarSetorCodigo(int item)
        {
            var pesquisa = daoSetor.listarSetorCodigo(item);
            return pesquisa;
        }

        public List<Setor> listarSetorNome(string item)
        {
            var pesquisa = daoSetor.listarSetorNome(item);
            return pesquisa;
        }

        public List<Curso> listarCurso()
        {
            var pesquisa = daoCurso.listarCurso();
            return pesquisa;
        }

        public List<Funcionario> listarFuncionario()
        {
            var pesquisa = daoFuncionario.listarFuncionarios();
            return pesquisa;
        }

        public List<Aluno> listarAluno()
        {
            var pesquisa = daoAluno.listarAluno();
            return pesquisa;
        }

        public List<Aluno> listarAlunoCodigo(int item)
        {
            var pesquisa = daoAluno.listarAlunoCodigo(item);
            return pesquisa;
        }

        public List<Aluno> listarAlunoNome(string item)
        {
            var pesquisa = daoAluno.listarAlunoNome(item);
            return pesquisa;
        }

        public List<Aluno> listarAlunoCurso(int item)
        {
            var pesquisa = daoAluno.listarAlunoCurso(item);
            return pesquisa;
        }

        public List<Cargo> listarCargo()
        {
            var pesquisa = daoCargo.listarCargo();
            return pesquisa;
        }

        public List<Cargo> listarCargoCodigo(int item)
        {
            var pesquisa = daoCargo.listarCargoCodigo(item);
            return pesquisa;
        }

        public List<Cargo> listarCargoSetor(string item)
        {
            var pesquisa = daoCargo.listarCargoSetor(item);
            return pesquisa;
        }

        public List<Funcionario> listarFuncionarioSetor(string item)
        {
            var pesquisa = daoFuncionario.listarFuncionarioSetor(item);
            return pesquisa;
        }

        public List<Cargo> procurarCargoLista(int codigo)
        {
            var pesquisa = daoCargo.procurarCargoLista(codigo);
            return pesquisa;
        }
        public List<Professores> procurarProfessoresLista(int codigo)
        {
            var pesquisa = daoProfessor.procurarProfessoresLista(codigo);
            return pesquisa;
        }

        public List<Professores> procurarProfessoresNome(string codigo)
        {
            var pesquisa = daoProfessor.procurarProfessoresNome(codigo);
            return pesquisa;
        }

        public List<Funcionario> procurarFuncionarioLista(int codigo)
        {
            List<Funcionario> pesquisa = daoFuncionario.procurarFuncionarioLista(codigo);
            return pesquisa;
        }

        public List<Funcionario> procurarFuncionariosNome(string codigo)
        {
            List<Funcionario> pesquisa = daoFuncionario.procurarFuncionariosNome(codigo);
            return pesquisa;
        }

        public List<Professores> listarProfessorMateria()
        {
            List<Professores> pesquisa = daoProfessor.listarProfessorMateria();
            return pesquisa;
        }
    }
}
