using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Universidade.DAO;

namespace Universidade.Arquivo
{
    class Arquivos
    {
      
        public void SalvarPessoa(List<Pessoa> listaPessoa)
        {
            string json = JsonConvert.SerializeObject(listaPessoa.ToArray());

            System.IO.File.WriteAllText(@"C:\Projetos\listaPessoa.txt", json);
        }

        public void lerPessoa()
        {
            DaoPessoa daoPessoa = new DaoPessoa();
            string jsonFilePath = @"C:\Projetos\listaPessoa.txt";

            if (File.Exists(jsonFilePath)) { 
                string json = File.ReadAllText(jsonFilePath);

                Pessoa[] listaPessoas = JsonConvert.DeserializeObject<Pessoa[]>(json);
              
                daoPessoa.addPessoaLer(listaPessoas.ToList());

            }
        }
    }
}
