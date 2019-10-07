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
            btnCadastrarUser.FlatStyle = FlatStyle.Flat;
            btnCadastrarUser.FlatAppearance.BorderColor = Color.LightGray;
            btnCadastrarUser.FlatAppearance.BorderSize = 1;

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;
        }

        private void BtnCadastrarUser_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            Hide();
            cadastroUsuario.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
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
    }
}
