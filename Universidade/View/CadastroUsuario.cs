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
        public int curso_id = 0;
        public int materia_id = 0;

        ControleClass controleClasse = new ControleClass();
     
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
                label3.Text = "Edição de Professor";
                var pesquisa = controleClasse.procurarProfessor(NR);
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
            txtNumero.Value     = item.Endereco.Numero;
            txtRua.Text         = item.Endereco.Rua;
            txtCep.Text         = item.Endereco.Cep;
            txtBairro.Text      = item.Endereco.Bairro;
            txtEstado.Text      = item.Endereco.Estado;
            txtPais.Text        = item.Endereco.Pais;
            txtCidade.Text      = item.Endereco.Cidade;
            txtTelefoneCelular.Text = item.Telefone.TelefoneCelular;
            txtTelefoneFixo.Text    = item.Telefone.TelefoneFixo;

            curso_id            = item.Curso_id;
            var pesquisaCurso   = controleClasse.procurarCurso(item.Curso_id);
            txtCurso.Text       = pesquisaCurso.Nome;

            materia_id          = item.Materia_id;
            var pesquisaMat     = controleClasse.procurarMateriasNomes(item.Curso_id, item.Materia_id);
            txtMateria.Text     = pesquisaMat;
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

            endereco.Cep    = txtCep.Text;
            endereco.Numero = Convert.ToInt32(txtNumero.Value);
            endereco.Rua    = txtRua.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Pais   = txtPais.Text;

            telefone.TelefoneFixo    = txtTelefoneFixo.Text;
            telefone.TelefoneCelular = txtTelefoneCelular.Text;

            professor.Endereco  = endereco;
            professor.Telefone  = telefone;

            professor.Materia_id    = materia_id;
            professor.Curso_id      = curso_id;
         

            if (verificar == 0)
            {

                if (txtCheck.Checked == true) {
                    controleClasse.adicionarProfessor(professor);

                    Coordenador coodenador = new Coordenador();

                    coodenador.Nome = txtNome.Text;
                    coodenador.Idade = Convert.ToInt32(txtIdade.Value);
                    coodenador.Sexo = txtSexo.Text;
                    coodenador.EstadoCivil = txtEstadoCivil.Text;
                    coodenador.CPF = txtCpf.Text;
                    coodenador.NR = Convert.ToInt32(txtNR.Text);
                    coodenador.Email = txtEmail.Text;

                    coodenador.Endereco = endereco;
                    coodenador.Telefone = telefone;

                    controleClasse.adicionarCoordenador(coodenador);

                    MessageBox.Show("Seu cadastro foi efetuado com sucesso!", "Cadastro efetuado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    controleClasse.adicionarProfessor(professor);

                    MessageBox.Show("Seu cadastro foi editado com sucesso!", "Cadastro editado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var pesquisa = new ControleClass().procurarCoordenador(verificar);
                if (pesquisa != null)
                {
                    pesquisa.Nome = txtNome.Text;
                    pesquisa.Idade = Convert.ToInt32(txtIdade.Value);
                    pesquisa.Sexo = txtSexo.Text;
                    pesquisa.EstadoCivil = txtEstadoCivil.Text;
                    pesquisa.CPF = txtCpf.Text;
                    pesquisa.NR = Convert.ToInt32(txtNR.Text);
                    pesquisa.Email = txtEmail.Text;


                    pesquisa.Endereco = endereco;
                    pesquisa.Telefone = telefone;

                    controleClasse.excluirCoordenador(verificar);
                    controleClasse.adicionarCoordenador(pesquisa);

                }
                controleClasse.excluirProfessor(verificar);
                controleClasse.adicionarProfessor(professor);

                MessageBox.Show("Edição efetuada com sucesso!", "Edição efetuada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Professor telaUsuario = new Professor();
            Hide();
            telaUsuario.Show();
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
