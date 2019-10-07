using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.Arquivo;

namespace Universidade.DAO
{
    class DaoPessoa
    {
        private static List<Pessoa> listaPessoa = new List<Pessoa>();
        Arquivos arquivo = new Arquivos();

        public void addPessoa(Pessoa pessoa)
        {
            listaPessoa.Add(pessoa);
            arquivo.SalvarPessoa(listaPessoa);
        }

        public void addPessoaLer(List<Pessoa> pessoa)
        {
            listaPessoa = pessoa;
            arquivo.SalvarPessoa(listaPessoa);
        }

        public List<Pessoa> listarPessoa()
        {
            return listaPessoa;
        }

        public void excluirPessoa(int item)
        {
            listaPessoa.RemoveAll(x => x.RA == item);
            arquivo.SalvarPessoa(listaPessoa);
        }
    }
}
