using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universidade.Controler;
using Universidade.Entidades;

namespace Universidade.View
{
    public partial class CadastroSetor : Form
    {
        public int verificar = 0;

        public CadastroSetor(int codigo)
        {
            InitializeComponent();
            btnCadastrarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuario.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCadastrarUsuario.FlatAppearance.BorderSize = 1;


            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

            if (codigo != 0)
            {
                verificar = codigo;
                btnCadastrarUsuario.Text = "Editar";
                label3.Text = "Edição de Setor";
                var pesquisa = new ControleClass().procurarSetor(codigo);
                PreencherCampos(pesquisa);
            }
        }

        private void PreencherCampos(Setor item)
        {
            txtNome.Text = item.Responsavel.Nome;
            txtIdade.Value = Convert.ToInt32(item.Responsavel.Idade);
            txtSexo.Text = item.Responsavel.Sexo;
            txtEstadoCivil.Text = item.Responsavel.EstadoCivil;
            txtCpf.Text = item.Responsavel.CPF;
            txtNR.Value = item.Responsavel.NR;
            txtEmail.Text = item.Responsavel.Email;
            txtNumero.Value = item.Responsavel.Endereco.Numero;
            txtRua.Text = item.Responsavel.Endereco.Rua;
            txtCep.Text = item.Responsavel.Endereco.Cep;
            txtBairro.Text = item.Responsavel.Endereco.Bairro;
            txtEstado.Text = item.Responsavel.Endereco.Estado;
            txtPais.Text = item.Responsavel.Endereco.Pais;
            txtCidade.Text = item.Responsavel.Endereco.Cidade;
            txtTelefoneCelular.Text = item.Responsavel.Telefone.TelefoneCelular;
            txtTelefoneFixo.Text = item.Responsavel.Telefone.TelefoneFixo;
            txtTipo.Text = item.Tipo;
            txtCodigo.Value = item.Codigo;
            txtLocalizacao.Text = item.Localizacao;
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            Endereco endereco = new Endereco();
            Telefone telefone = new Telefone();
            Setor setor = new Setor();


            pessoa.Nome = txtNome.Text;
            pessoa.Idade = Convert.ToInt32(txtIdade.Value);
            pessoa.Sexo = txtSexo.Text;
            pessoa.EstadoCivil = txtEstadoCivil.Text;
            pessoa.CPF = txtCpf.Text;
            pessoa.NR = Convert.ToInt32(txtNR.Text);
            pessoa.Email = txtEmail.Text;

            endereco.Cep = txtCep.Text;
            endereco.Numero = Convert.ToInt32(txtNumero.Value);
            endereco.Rua = txtRua.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Pais = txtPais.Text;

            telefone.TelefoneFixo = txtTelefoneFixo.Text;
            telefone.TelefoneCelular = txtTelefoneCelular.Text;

            pessoa.Endereco = endereco;
            pessoa.Telefone = telefone;

            setor.Codigo = Convert.ToInt32(txtCodigo.Value);
            setor.Localizacao = txtLocalizacao.Text;
            setor.Tipo = txtTipo.Text;
            setor.Responsavel = pessoa;

            if (verificar == 0)
            {
                new ControleClass().adicionarSetores(setor);

                MessageBox.Show("Seu cadastro foi efetuado com sucesso!", "Cadastro efetuado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                new ControleClass().excluirSetor(verificar);
                new ControleClass().adicionarSetores(setor);
                MessageBox.Show("Edição foi efetuado com sucesso!", "Edição efetuada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Setores setor = new Setores();
            Hide();
            setor.Show();
        }
    }
}
