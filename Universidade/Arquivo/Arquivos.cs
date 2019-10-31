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

            if (File.Exists(jsonFilePath))
            {
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

        // Setores

        public void SalvaSetores(List<Setor> listaSetor)
        {
            string json = JsonConvert.SerializeObject(listaSetor.ToArray());

            File.WriteAllText(@".\listaSetores.txt", json);
        }

        public void lerSetores()
        {
            DaoSetor daoSetor = new DaoSetor();
            string jsonFilePath = @".\listaSetores.txt";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                Setor[] listaSetor = JsonConvert.DeserializeObject<Setor[]>(json);

                daoSetor.addSetorLer(listaSetor.ToList());

            }
        }

        //Cursos

        public void SalvarCurso(List<Curso> listaCurso)
        {
            string json = JsonConvert.SerializeObject(listaCurso.ToArray());

            File.WriteAllText(@".\listaCurso.txt", json);
        }
        public void lerCurso() //Revisar
        {
            DaoCurso daoCurso = new DaoCurso();
            string jsonFilePath = @".\listaCurso.txt";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                Curso[] listaCurso = JsonConvert.DeserializeObject<Curso[]>(json);

                daoCurso.addCursoLer(listaCurso.ToList());

            }
        }


        //Funcionários

        public void SalvarFuncionario(List<Funcionario> listaFuncionario)
        {

            string json = JsonConvert.SerializeObject(listaFuncionario.ToArray());

            File.WriteAllText(@".\listaFuncionario.txt", json);

        }
        public void lerFuncionario()
        {
            DaoFuncionario daoFuncionario = new DaoFuncionario();
            string jsonFilePath = @".\listaFuncionario.txt";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                Funcionario[] listaFuncionario = JsonConvert.DeserializeObject<Funcionario[]>(json);

                daoFuncionario.lerFuncionarios(listaFuncionario.ToList());
            }
        }

        // Alunos

        public void SalvarAluno(List<Alunos> listaAluno)
        {
            string json = JsonConvert.SerializeObject(listaAluno.ToArray());

            File.WriteAllText(@".\listaAlunos.txt", json);
        }

        public void lerAluno()
        {
            DaoAluno daoAluno = new DaoAluno();
            string jsonFilePath = @".\listaAlunos.txt";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                Alunos[] listaAluno = JsonConvert.DeserializeObject<Alunos[]>(json);

                daoAluno.addAlunoLer(listaAluno.ToList());

            }
        }
    }
}
