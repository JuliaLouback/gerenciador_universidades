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
        private static List<Alunos> listaAluno = new List<Alunos>();
        Arquivos arquivo = new Arquivos();

        public void addAluno(Alunos aluno)
        {
            listaAluno.Add(aluno);
            arquivo.SalvarAluno(listaAluno);
        }

        public void addAlunoLer(List<Alunos> aluno)
        {
            listaAluno = aluno;
            arquivo.SalvarAluno(listaAluno);
        }

        public List<Alunos> listarAluno()
        {
            return listaAluno;
        }

        public void excluirAluno(int item)
        {
            listaAluno.RemoveAll(x => x.NR == item);
            arquivo.SalvarAluno(listaAluno);
        }

        public Alunos procurarAluno(int item)
        {
            Alunos aluno = listaAluno.Find(x => x.NR == item);
            return aluno;
        }

        public Alunos procurarAlunoNome(string item)
        {
            Alunos aluno = listaAluno.Find(x => x.Nome == item);
            return aluno;
        }
    }
}
