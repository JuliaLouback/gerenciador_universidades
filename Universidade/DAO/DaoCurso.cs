using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.Arquivo;
using Universidade.Entidades;


namespace Universidade.DAO
{
    class DaoCurso
    {
        private static List<Curso> listaCurso = new List<Curso>();
        Arquivos arquivo = new Arquivos();

        public void addCurso(Curso curso)
        {
            listaCurso.Add(curso);
            arquivo.SalvarCurso(listaCurso);
        }

        public void addCursoLer(List<Curso> curso)
        {
            listaCurso = curso;
            arquivo.SalvarCurso(listaCurso);
        }

        public List<Curso> listarCurso()
        {
            return listaCurso;
        }

        public void excluirCurso(int item)
        {
            listaCurso.RemoveAll(x => x.Codigo == item);
            arquivo.SalvarCurso(listaCurso);
        }

        public Curso procurarCurso(int item)
        {
            Curso cursoProcurarC = listaCurso.Find(x => x.Codigo == item);
            return cursoProcurarC;
        }

        public Curso procurarCursoNome(string item)
        {
            Curso cursoProcurarN = listaCurso.Find(x => x.Nome == item);
            return cursoProcurarN;
        }
    }
}
