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
    public partial class CadastroAluno : Form
    {
        public int verificar = 0;
        ControleClass cadAluno = new ControleClass();

        public CadastroAluno(int NR)
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
                label13.Text = "Edição de Aluno";
                var pesquisa = cadAluno.procurarAluno(NR);
                PreencherCampos(pesquisa);
                
            }
            PreencherComboCurso();
        }
       
       private void PreencherComboCurso()
        {
            var listaCurso = cadAluno.listarCurso();
            foreach (Curso curso in listaCurso)
            {
                txtCurso.Items.Add(curso.Nome);
            }
        }

        private void PreencherCampos(Aluno item)
        {
            txtNome.Text = item.Nome;
            txtIdade.Value = Convert.ToInt32(item.Idade);
            txtSexo.Text = item.Sexo;
            txtEstadoCivil.Text = item.EstadoCivil;
            txtCpf.Text = item.CPF;
            txtNR.Value = item.NR;
            txtEmail.Text = item.Email;
            txtCurso.Text = item.Curso;
            txtNumero.Value = item.Endereco.Numero;
            txtRua.Text = item.Endereco.Rua;
            txtCep.Text = item.Endereco.Cep;
            txtBairro.Text = item.Endereco.Bairro;
            txtEstado.Text = item.Endereco.Estado;
            txtPais.Text = item.Endereco.Pais;
            txtCidade.Text = item.Endereco.Cidade;
            txtTelefoneCelular.Text = item.Telefone.TelefoneCelular;
            txtTelefoneFixo.Text = item.Telefone.TelefoneFixo;
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            Endereco endereco = new Endereco();
            Telefone telefone = new Telefone();

            aluno.Nome = txtNome.Text;
            aluno.Idade = Convert.ToInt32(txtIdade.Value);
            aluno.Sexo = txtSexo.Text;
            aluno.EstadoCivil = txtEstadoCivil.Text;
            aluno.CPF = txtCpf.Text;
            aluno.NR = Convert.ToInt32(txtNR.Text);
            aluno.Email = txtEmail.Text;
            aluno.Curso = txtCurso.Text;

            endereco.Cep = txtCep.Text;
            endereco.Numero = Convert.ToInt32(txtNumero.Value);
            endereco.Rua = txtRua.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Pais = txtPais.Text;

            telefone.TelefoneFixo = txtTelefoneFixo.Text;
            telefone.TelefoneCelular = txtTelefoneCelular.Text;

            aluno.Endereco = endereco;
            aluno.Telefone = telefone;
            aluno.Curso = txtCurso.Text;
            new ControleClass().adicionarAluno(aluno);

            if (verificar == 0)
            {
                new ControleClass().adicionarAluno(aluno);
                Alunos alunos = new Alunos();
                MessageBox.Show("Seu cadastro foi efetuado com sucesso!", "Cadastro efetuado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                alunos.Show();
            }
            else
            {
                var pesquisa = new ControleClass().procurarAluno(verificar);
                if (pesquisa != null)
                {
                    pesquisa.Nome = txtNome.Text;
                    pesquisa.Idade = Convert.ToInt32(txtIdade.Value);
                    pesquisa.Sexo = txtSexo.Text;
                    pesquisa.EstadoCivil = txtEstadoCivil.Text;
                    pesquisa.CPF = txtCpf.Text;
                    pesquisa.NR = Convert.ToInt32(txtNR.Text);
                    pesquisa.Email = txtEmail.Text;
                    pesquisa.Curso = txtCurso.Text;


                    pesquisa.Endereco = endereco;
                    pesquisa.Telefone = telefone;

                    new ControleClass().excluirAluno(verificar);
                    new ControleClass().adicionarAluno(pesquisa);
                }
                new ControleClass().excluirAluno(verificar);
                new ControleClass().adicionarAluno(aluno);

                MessageBox.Show("Edição efetuada com sucesso!", "Edição efetuada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Alunos alunos = new Alunos();
            Hide();
            alunos.Show();
        }
    }
}
