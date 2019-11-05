using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.Arquivo;
using Universidade.Entidades;

namespace Universidade.DAO
{
    class DaoProfessor
    {
        private static List<Professores> listaProfessores = new List<Professores>();
        Arquivos arquivo = new Arquivos();

        public void addProfessor(Professores professor)
        {
            listaProfessores.Add(professor);
            arquivo.SalvarProfessor(listaProfessores);
        }

        public void addProfessorLer(List<Professores> professor)
        {
            listaProfessores = professor;
            arquivo.SalvarProfessor(listaProfessores);
        }

        public List<Professores> listarProfessor()
        {
            return listaProfessores;
        }

        public void excluirProfessor(int item)
        {
            listaProfessores.RemoveAll(x => x.NR == item);
            arquivo.SalvarProfessor(listaProfessores);
        }

        public Professores procurarProfessor(int item)
        {
            Professores professsor = listaProfessores.Find(x => x.NR == item);
            return professsor;
        }

        public Professores procurarProfessorNome(string item)
        {
            Professores professsor = listaProfessores.Find(x => x.Nome == item);
            return professsor;
        }

        public List<Professores> procurarProfessoresLista(int item)
        {
            List<Professores> professsor = listaProfessores.FindAll(x => x.NR == item);
            return professsor;
        }

        public List<Professores> procurarProfessoresNome(string item)
        {
            List<Professores> professsor = listaProfessores.FindAll(x => x.Nome == item);
            return professsor;
        }
    }
}
