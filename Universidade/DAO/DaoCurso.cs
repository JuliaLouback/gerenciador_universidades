using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.Arquivo;
using Universidade.Entidades;


namespace Universidade.DAO
{
    public class DaoCurso
    {
        private static List<Curso> listaCurso = new List<Curso>();
        private static List<Materias> listaMateria = new List<Materias>();
        private static List<Professores> listaProfessor = new List<Professores>();

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
        public void editarCurso(Curso cursoEditado)
        {
            excluirCurso(cursoEditado.Codigo);
            addCurso(cursoEditado);
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

        public string procurarCursoNomes(int item)
        {

            var cursoProcurarN = listaCurso.Find(x => x.Codigo == item);
            if (cursoProcurarN != null)
            {
                return cursoProcurarN.Nome;
            } else
            {
                return " ";
            }
           
        }

        public List<Materias> procurarMateria(int item, int item2)
        {
            Curso cursoProcurarN = listaCurso.Find(x => x.Codigo == item);
            List<Materias> listinha = new List<Materias>();

          
            foreach (Materias cursinho in cursoProcurarN.Materias)
            {
                if (cursinho.Periodo == item2)
                {
                    listinha.Add(cursinho);
                }
            }
            return listinha;
        }

        public Materias listarProfessorMateria(int item)
        {
            var procurar = listaMateria.Find(x => x.Codigo == item);
            return procurar;
        }

        public Materias procurarMateriaNome (int item, string item2)
        {
            Curso cursoProcurarN = listaCurso.Find(x => x.Codigo == item);
            Materias materia = new Materias();

            foreach (Materias cursinho in cursoProcurarN.Materias)
            {
                if (cursinho.Nome == item2)
                {
                    materia = cursinho;
                }
            }
            return materia;
        }

        public string  procurarMateriasNomes(int item, int item2)
        {
            Curso cursoProcurarN = listaCurso.Find(x => x.Codigo == item);
            var materia  = "";

            if (cursoProcurarN != null) {
                foreach (Materias cursinho in cursoProcurarN.Materias)
                {
                    if (cursinho.Codigo == item2)
                    {
                        materia = cursinho.Nome;
                    }
                }
                return materia;
            } else
            {
                return " ";
            }
        }


        public void excluirMateria(int item, int item2)
        {
          listaMateria.RemoveAll(x => x.Codigo == item2);
        }

        public List<Curso> procurarCursoCodigo(int item)
        {
            List<Curso> listinha = listaCurso.FindAll(x => x.Codigo == item);
            return listinha;
        }

        public List<Curso> procurarCursosNome(string item)
        {
            List<Curso> listinha = listaCurso.FindAll(x => x.Nome == item);
            return listinha;
        }
    }
}
