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
using Universidade.DAO;
using Universidade.Entidades;

namespace Universidade.View
{
    public partial class CadastroFuncionario : Form
    {
        public int verificar = 0;
        ControleClass controleClasse = new ControleClass();


        public CadastroFuncionario(int NR)
        {
            InitializeComponent();

            if (NR != 0)
            {
                verificar = NR;
                btnCadastrarUsuario.Text = "Editar";
                label3.Text = "Edição de Funcionario";
                var pesquisa = controleClasse.procurarFuncionario(NR);
                PreencherCampos(pesquisa);

            }
            PrencheerCombo();


        }
        public void PrencheerCombo()
        {
            var listaSetor = controleClasse.listarSetor();
            foreach (Setor setor in listaSetor)
            {
                cbxSetor.Items.Add(setor.Tipo);
            }
        }

        private void PreencherCampos(Funcionario item)
        {
            txtNome.Text         = item.Nome;
            nudIdade.Value       = Convert.ToInt32(item.Idade);
            cbxSexo.Text         = item.Sexo;
            cbxEstadoCivil.Text  = item.EstadoCivil;
            maskCPF.Text         = item.CPF;
            nudNR.Value          = item.NR;
            txtEmail.Text        = item.Email;
            nudNumero.Value      = Convert.ToInt32(item.Endereco.Numero);
            txtRua.Text          = item.Endereco.Rua;
            maskCEP.Text         = item.Endereco.Cep;
            txtBairro.Text       = item.Endereco.Bairro;
            txtEstado.Text       = item.Endereco.Estado;
            txtPais.Text         = item.Endereco.Pais;
            txtCidade.Text       = item.Endereco.Cidade;
            maskCelular.Text     = item.Telefone.TelefoneCelular;
            maskTelefone.Text    = item.Telefone.TelefoneFixo;
            cbxCargo.Text        = item.Cargo;
            cbxSetor.Text        = item.Setor;
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            Endereco endereco = new Endereco();
            Telefone telefone = new Telefone();

            funcionario.Nome    = txtNome.Text;
            funcionario.Idade  = Convert.ToInt32(nudIdade.Value);
            funcionario.Sexo = cbxSexo.Text;
            funcionario.EstadoCivil = cbxEstadoCivil.Text;
            funcionario.CPF = maskCPF.Text;
            funcionario.NR = Convert.ToInt32(nudNR.Text);
            funcionario.Email = txtEmail.Text;

            telefone.TelefoneCelular = Convert.ToString(maskCelular.Text);
            telefone.TelefoneFixo = Convert.ToString(maskTelefone.Text);

            endereco.Cep = maskCEP.Text;
            endereco.Numero = Convert.ToInt32(nudNumero.Value);
            endereco.Rua = txtRua.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Pais = txtPais.Text;

            funcionario.Endereco = endereco;
            funcionario.Telefone = telefone;
            funcionario.Setor = cbxSetor.Text;
            funcionario.Cargo = cbxCargo.Text;




            if (verificar == 0)
            {
                new ControleClass().adicionarFuncionario(funcionario);
                Funcionarios funcionarios = new Funcionarios();
                MessageBox.Show("seu cadastro foi realizado com sucesso");
                Hide();
                funcionarios.Show();
            }
            else
            {
                var pesquisa = new ControleClass().procurarFuncionario(verificar);
                if (pesquisa != null)
                {
                    pesquisa.Nome = txtNome.Text;
                    pesquisa.Idade = Convert.ToInt32(nudIdade.Value);
                    pesquisa.Sexo = cbxSexo.Text;
                    pesquisa.EstadoCivil = cbxEstadoCivil.Text;
                    pesquisa.CPF = maskCPF.Text;
                    pesquisa.NR = Convert.ToInt32(nudNR.Text);
                    pesquisa.Email = txtEmail.Text;


                    pesquisa.Endereco = endereco;
                    pesquisa.Telefone = telefone;

                    controleClasse.excluirFuncionario(verificar);
                    controleClasse.adicionarFuncionario(pesquisa);

                }
                controleClasse.excluirFuncionario(verificar);
                controleClasse.adicionarFuncionario(funcionario);

                MessageBox.Show("Edição efetuada com sucesso!", "Edição efetuada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            Hide();
            funcionarios.Show();
        }
    }
}
