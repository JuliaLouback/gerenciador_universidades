using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universidade.View;

namespace Universidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCadastrarUser.FlatStyle = FlatStyle.Flat;
            btnCadastrarUser.FlatAppearance.BorderColor = Color.LightGray;
            btnCadastrarUser.FlatAppearance.BorderSize = 1;

            btnCadastrarSetores.FlatStyle = FlatStyle.Flat;
            btnCadastrarSetores.FlatAppearance.BorderColor = Color.LightGray;
            btnCadastrarSetores.FlatAppearance.BorderSize = 1;


            btnCadastrarCurso.FlatStyle = FlatStyle.Flat;
            btnCadastrarCurso.FlatAppearance.BorderColor = Color.LightGray;
            btnCadastrarCurso.FlatAppearance.BorderSize = 1;
        }

        private void BtnCadastrarUser_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            Hide();
            telaUsuario.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            Hide();
            telaUsuario.Show();
        }

        private void BtnCadastrarCurso_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            Hide();
            curso.Show();
        }

        private void btnCadastrarSetores_Click(object sender, EventArgs e)
        {
            Setores setor = new Setores();
            Hide();
            setor.Show();
        }
    }
}
