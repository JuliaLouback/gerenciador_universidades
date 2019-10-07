using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Universidade.Controler;
using Universidade.View;

namespace Universidade
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            btnCadastrarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuario.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCadastrarUsuario.FlatAppearance.BorderSize = 1;


            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Pessoa pessoa       = new Pessoa();
            Endereco endereco   = new Endereco();
            Telefone telefone   = new Telefone();

            pessoa.Nome     = txtNome.Text;
            pessoa.Idade    = Convert.ToInt32(txtIdade.Value);
            pessoa.Sexo     = txtSexo.Text;
            pessoa.EstadoCivil = txtEstadoCivil.Text;
            pessoa.TipoUsuario = txtTipoUsuario.Text;
            pessoa.RA       = Convert.ToInt32(txtRa.Text);

            endereco.Cep    = txtCep.Text;
            endereco.Numero = Convert.ToInt32(txtNumero.Value);
            endereco.Rua    = txtRua.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Pais   = txtPais.Text;

            telefone.TelefoneFixo    = txtTelefoneFixo.Text;
            telefone.TelefoneCelular = txtTelefoneCelular.Text;

            pessoa.Endereco = endereco;
            pessoa.Telefone = telefone;

            new ControleClass().adicionar(pessoa);

            MessageBox.Show("Seu cadastro foi efetuado com sucesso!","Cadastro efetuado com sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            Hide();
            telaUsuario.Show();
        }
    }
}
