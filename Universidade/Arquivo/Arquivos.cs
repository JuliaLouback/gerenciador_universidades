using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Universidade.DAO;
using Universidade.Entidades;

namespace Universidade.Arquivo
{
    class Arquivos
    {
      
        public void SalvarProfessor(List<Professores> listaProfessor)
        {
            string json = JsonConvert.SerializeObject(listaProfessor.ToArray());

            File.WriteAllText(@".\listaProfessor.txt", json);
        }

        public void lerProfessor()
        {
            DaoProfessor daoProfessor = new DaoProfessor();
            string jsonFilePath = @".\listaProfessor.txt";

            if (File.Exists(jsonFilePath)) { 
                string json = File.ReadAllText(jsonFilePath);

                Professores[] listaProfessor = JsonConvert.DeserializeObject<Professores[]>(json);
              
                daoProfessor.addProfessorLer(listaProfessor.ToList());

            }
        }

        //  Coordenadores

        public void SalvarCoordenadores(List<Coordenador> listaCoordenador)
        {
            string json = JsonConvert.SerializeObject(listaCoordenador.ToArray());

            File.WriteAllText(@".\listaCoordenares.txt", json);
        }

        public void lerCoordenadores()
        {
            DaoCoodenador daoCoodenador = new DaoCoodenador();
            string jsonFilePath = @".\listaCoordenares.txt";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                Coordenador[] listaCoordenador = JsonConvert.DeserializeObject<Coordenador[]>(json);

                daoCoodenador.addCoordenadorLer(listaCoordenador.ToList());

            }
        }

    }
}
