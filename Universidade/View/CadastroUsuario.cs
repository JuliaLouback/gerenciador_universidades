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
using Universidade.DAO;
using Universidade.Entidades;
using Universidade.View;

namespace Universidade
{
    public partial class CadastroUsuario : Form
    {
        public int verificar = 0;
     
        public CadastroUsuario(int NR)
        {
            InitializeComponent();
            btnCadastrarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuario.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCadastrarUsuario.FlatAppearance.BorderSize = 1;
            

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

            if (NR != 0)
            {
                verificar = NR;
                btnCadastrarUsuario.Text = "Editar";
                var pesquisa = new DaoProfessor().procurarProfessor(NR);
                PreencherCampos(pesquisa);
            }
        }

        private void PreencherCampos(Professores item)
        {
            txtNome.Text        = item.Nome;
            txtIdade.Value      = Convert.ToInt32(item.Idade);
            txtSexo.Text        = item.Sexo;
            txtEstadoCivil.Text = item.EstadoCivil;
            txtCpf.Text         = item.CPF;
            txtNR.Value         = item.NR;
            txtEmail.Text       = item.Email;
            txtCurso.Text       = item.Curso;
            txtMateria.Text     = item.Materia;
            txtNumero.Value     = item.Endereco.Numero;
            txtRua.Text         = item.Endereco.Rua;
            txtCep.Text         = item.Endereco.Cep;
            txtBairro.Text      = item.Endereco.Bairro;
            txtEstado.Text      = item.Endereco.Estado;
            txtPais.Text        = item.Endereco.Pais;
            txtCidade.Text      = item.Endereco.Cidade;
            txtTelefoneCelular.Text = item.Telefone.TelefoneCelular;
            txtTelefoneFixo.Text    = item.Telefone.TelefoneFixo;
        }
        private void BtnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Professores professor  = new  Professores();
            Endereco  endereco   = new Endereco();
            Telefone  telefone   = new Telefone();

            professor.Nome     = txtNome.Text;
            professor.Idade    = Convert.ToInt32(txtIdade.Value);
            professor.Sexo     = txtSexo.Text;
            professor.EstadoCivil = txtEstadoCivil.Text;
            professor.CPF      = txtCpf.Text;
            professor.NR       = Convert.ToInt32(txtNR.Text);
            professor.Email     = txtEmail.Text;

            professor.Curso = txtCurso.Text;
            professor.Materia = txtMateria.Text;

            endereco.Cep    = txtCep.Text;
            endereco.Numero = Convert.ToInt32(txtNumero.Value);
            endereco.Rua    = txtRua.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Pais   = txtPais.Text;

            telefone.TelefoneFixo    = txtTelefoneFixo.Text;
            telefone.TelefoneCelular = txtTelefoneCelular.Text;

            professor.Endereco = endereco;
            professor.Telefone = telefone;

            if (verificar == 0)
            {
                new ControleClass().adicionarProfessor(professor);
                MessageBox.Show("Seu cadastro foi efetuado com sucesso!", "Cadastro efetuado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                new DaoProfessor().excluirProfessor(verificar);
                new ControleClass().adicionarProfessor(professor);
                MessageBox.Show("Edição efetuada com sucesso!", "Edição efetuada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            Hide();
            telaUsuario.Show();
        }
    }
}
