using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.Arquivo;
using Universidade.Entidades;

namespace Universidade.DAO
{
    class DaoCargo
    {
        private static List<Cargo> listaCargo = new List<Cargo>();
        Arquivos arquivo = new Arquivos();

        public void addCargo(Cargo cargo)
        {
            listaCargo.Add(cargo);
            arquivo.SalvarCargo(listaCargo);
        }

        public void addCargoLer(List<Cargo> cargo)
        {
            listaCargo = cargo;
            arquivo.SalvarCargo(listaCargo);
        }

        public List<Cargo> listarCargo()
        {
            return listaCargo;
        }

        public void excluirCargo(int item)
        {
            listaCargo.RemoveAll(x => x.Codigo == item);
            arquivo.SalvarCargo(listaCargo);
        }

        public Cargo procurarCargo(int item)
        {
            Cargo Cargo = listaCargo.Find(x => x.Codigo == item);
            return Cargo;
        }

        public Cargo procurarCargoNome(int item1, string item)
        {
            List<Cargo> cargoLista = listaCargo.FindAll(x => x.Setor_id == item1);
           
            var pesquisa = cargoLista.Find(x => x.Nome == item);
            return pesquisa;
        }

        public string procurarCargoNomes(int item)
        {
            var pesquisa = listaCargo.Find(x => x.Codigo == item);
            return pesquisa.Nome;
        }

        public List<Cargo> procurarCargoLista(int item)
        {
         
            List<Cargo> listinha = new List<Cargo>();

            foreach (Cargo cursinho in listaCargo)
            {
                if (cursinho.Setor_id == item)
                {
                    listinha.Add(cursinho);
                }
            }
            return listinha;
        }

        public List<Cargo> listarCargoCodigo(int item)
        {
            List<Cargo> listinha = listaCargo.FindAll(x => x.Codigo == item);
            return listinha;
        }

        public List<Cargo> listarCargoSetor(string item)
        {
            var tipo = new DaoSetor().procurarSetorNome(item);
            List<Cargo> listinha = listaCargo.FindAll(x => x.Setor_id == tipo.Codigo);
            return listinha;
        }
    }
}
