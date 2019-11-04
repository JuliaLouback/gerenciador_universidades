using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.Arquivo;
using Universidade.Entidades;

namespace Universidade.DAO
{
    class DaoAluno
    {
        private static List<Aluno> listaAluno = new List<Aluno>();
        Arquivos arquivo = new Arquivos();

        public void addAluno(Aluno aluno)
        {
            listaAluno.Add(aluno);
            arquivo.SalvarAluno(listaAluno);
        }

        public void addAlunoLer(List<Aluno> aluno)
        {
            listaAluno = aluno;
            arquivo.SalvarAluno(listaAluno);
        }

        public List<Aluno> listarAluno()
        {
            return listaAluno;
        }

        public List<Aluno> listarAlunoCodigo(int codigo)
        {
            List<Aluno> aluninho = listaAluno.FindAll(x => x.NR == codigo);
            return aluninho;
        }

        public List<Aluno> listarAlunoNome(string codigo)
        {
            List<Aluno> aluninho = listaAluno.FindAll(x => x.Nome == codigo);
            return aluninho;
        }

        public List<Aluno> listarAlunoCurso(string codigo)
        {
            List<Aluno> aluninho = listaAluno.FindAll(x => x.Nome == codigo);
            return aluninho;
        }

        public void excluirAluno(int item)
        {
            listaAluno.RemoveAll(x => x.NR == item);
            arquivo.SalvarAluno(listaAluno);
        }

        public Aluno procurarAluno(int item)
        {
            Aluno aluno = listaAluno.Find(x => x.NR == item);
            return aluno;
        }

        public Aluno procurarAlunoNome(string item)
        {
            Aluno aluno = listaAluno.Find(x => x.Nome == item);
            return aluno;
        }
    }
}
