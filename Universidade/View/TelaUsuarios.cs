using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universidade.View
{
    public partial class TelaUsuarios : Form
    {
        public TelaUsuarios()
        {
            InitializeComponent();

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;
        }

        private void BtnCadastrarUser_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario(0);
            Hide();
            cadastroUsuario.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario(0);
            Hide();
            cadastroUsuario.Show();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            Hide();
            professor.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Coordenadores coordenador = new Coordenadores();
            Hide();
            coordenador.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            Hide();
            funcionarios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alunos aluno = new Alunos();
            Hide();
            aluno.Show();
        }
    }
}
