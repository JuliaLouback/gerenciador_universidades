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
    public partial class CadastroCargo : Form
    {
        ControleClass controles = new ControleClass();
        public int numCargo = 0;
        public int verificar = 0;

        public CadastroCargo(int codigo)
        {
            InitializeComponent();
            PrencheerCombo();

            btnCadastrarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuario.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCadastrarUsuario.FlatAppearance.BorderSize = 1;

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;
            
            Random numRandCargo = new Random();
            numCargo = numRandCargo.Next(8000, 8999);
            if (controles.procurarCargo(numCargo) == null)
            {
                txtCodigo.Value = numRandCargo.Next(8000, 8999);
            }
            else
            {
                Random numRandCargo2 = new Random();
                numCargo = numRandCargo2.Next(8000, 8999);
            }

            if (codigo != 0)
            {
                verificar = codigo;
                btnCadastrarUsuario.Text = "Editar";
                label3.Text = "Edição de Cargo";
                txtCodigo.Enabled = false;
                var pesquisa = controles.procurarCargo(codigo);
                PreencherCampos(pesquisa);
            }
        }

        private void PreencherCampos(Cargo item)
        {
            txtCarga.Value = item.Carga_horaria;
            txtCodigo.Value = item.Codigo;
            txtNome.Text = item.Nome;

            var pesquisa = controles.procurarSetor(item.Setor_id);
            txtSetor.Text = pesquisa.Tipo;
        }
        private void PrencheerCombo()
        {
            var listaSetor = controles.listarSetor();
            foreach (Setor setor in listaSetor)
            {
                txtSetor.Items.Add(setor.Tipo);
            }
        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo();

            var pesquisaSetor = controles.procurarSetorNome(txtSetor.Text); 

            cargo.Codigo = Convert.ToInt32(txtCodigo.Value);
            cargo.Setor_id = pesquisaSetor.Codigo;
            cargo.Nome = txtNome.Text;
            cargo.Carga_horaria = Convert.ToInt32(txtCarga.Value);

            if (verificar == 0)
            {
                controles.adicionarCargo(cargo);

                MessageBox.Show("Seu cadastro foi efetuado com sucesso!", "Cadastro efetuado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                controles.excluirCargo(verificar);
                controles.adicionarCargo(cargo);

                MessageBox.Show("Edição efetuada com sucesso!", "Edição efetuada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Cargos tela = new Cargos();
            Hide();
            tela.Show();
        }
    }
}
