using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.Arquivo;
using Universidade.Entidades;

namespace Universidade.DAO
{
    class DaoCoodenador
    {
        private static List<Coordenador> listaCoordenador = new List<Coordenador>();
        Arquivos arquivo = new Arquivos();

        public void addCoordenador(Coordenador coordenador)
        {
            listaCoordenador.Add(coordenador);
            arquivo.SalvarCoordenadores(listaCoordenador);
        }

        public void addCoordenadorLer(List<Coordenador> coordenador)
        {
            listaCoordenador = coordenador;
            arquivo.SalvarCoordenadores(listaCoordenador);
        }

        public List<Coordenador> listarCoordenador()
        {
            return listaCoordenador;
        }

        public void excluirCoordenador(int item)
        {
            listaCoordenador.RemoveAll(x => x.NR == item);
            arquivo.SalvarCoordenadores(listaCoordenador);
        }

        public Coordenador procurarCoordenador(int item)
        {
            Coordenador coordenador = listaCoordenador.Find(x => x.NR == item);
            return coordenador;
        }
    }
}
