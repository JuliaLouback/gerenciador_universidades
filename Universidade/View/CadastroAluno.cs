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
                label3.Text = "Edição de Aluno";
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

            var pesquisa = cadAluno.procurarCurso(item.Curso_id);
            txtCurso.Text = pesquisa.Nome;

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

            var pesquisaCurso = cadAluno.procurarCursoNome(txtCurso.Text);
            aluno.Curso_id = pesquisaCurso.Codigo;

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

            var pesquisaCursinho = cadAluno.procurarCursoNome(txtCurso.Text);
            aluno.Curso_id = pesquisaCursinho.Codigo;

            if (verificar == 0)
            {
                new ControleClass().adicionarAluno(aluno);
               
                MessageBox.Show("Seu cadastro foi efetuado com sucesso!", "Cadastro efetuado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
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

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())

                    try
                    {
                        var endereco = ws.consultaCEP(txtCep.Text.Trim());

                        txtEstado.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtBairro.Text = endereco.bairro;
                        txtRua.Text = endereco.end;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cep não localizado...");
                    }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido");
            }
        }
    }
}
