using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universidade.Arquivo;

namespace Universidade
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Arquivos arquivo = new Arquivos();
            arquivo.lerProfessor();
            arquivo.lerCoordenadores();
            arquivo.lerSetores();
            arquivo.lerCurso();
            arquivo.lerFuncionario();
            arquivo.lerAluno();
            arquivo.lerCargo();
            
            Application.Run(new Form1());
        }
    }
}
