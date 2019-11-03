using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.Arquivo;
using Universidade.Entidades;

namespace Universidade.DAO
{
    class DaoSetor
    {
        private static List<Setor> listaSetor = new List<Setor>();
        Arquivos arquivo = new Arquivos();

        public void addSetor(Setor Setor)
        {
            listaSetor.Add(Setor);
            arquivo.SalvaSetores(listaSetor);
        }

        public void addSetorLer(List<Setor> Setor)
        {
            listaSetor = Setor;
            arquivo.SalvaSetores(listaSetor);
        }

        public List<Setor> listarSetor()
        {
            return listaSetor;
        }

        public List<Setor> listarSetorCodigo(int item)
        {
            List<Setor> listinha = listaSetor.FindAll(x => x.Codigo == item);
            return listinha;
        }

        public List<Setor> listarSetorNome(string item)
        {
            List<Setor> listinha = listaSetor.FindAll(x => x.Tipo == item);
            return listinha;
        }

        public void excluirSetor(int item)
        {
            listaSetor.RemoveAll(x => x.Codigo == item);
            arquivo.SalvaSetores(listaSetor);
        }

        public Setor procurarSetor(int item)
        {
            Setor Setor = listaSetor.Find(x => x.Codigo == item);
            return Setor;
        }

        public Setor procurarSetorNome(string item)
        {
            Setor Setor = listaSetor.Find(x => x.Tipo == item);
            return Setor;
        }

        public string procurarSetorNomes(int item)
        {
            Setor Setor = listaSetor.Find(x => x.Codigo == item);
            return Setor.Tipo;
        }
    }
}
