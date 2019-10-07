using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade.DAO;

namespace Universidade.Controler
{
    class ControleClass
    {
        private DaoPessoa dao = new DaoPessoa();
        public void adicionar(Pessoa pessoa)
        {
            dao.addPessoa(pessoa);
        }
    }
}
