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
    public partial class Cargos : Form
    {
        ControleClass controle = new ControleClass();

        public Cargos()
        {
            InitializeComponent();
            cadastrarSetor.FlatStyle = FlatStyle.Flat;
            cadastrarSetor.FlatAppearance.BorderColor = Color.ForestGreen;
            cadastrarSetor.FlatAppearance.BorderSize = 1;

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

            btnPesquisa.FlatStyle = FlatStyle.Flat;
            btnPesquisa.FlatAppearance.BorderColor = Color.DarkCyan;
            btnPesquisa.FlatAppearance.BorderSize = 1;

            btnPesquisaSetor.FlatStyle = FlatStyle.Flat;
            btnPesquisaSetor.FlatAppearance.BorderColor = Color.DarkCyan;
            btnPesquisaSetor.FlatAppearance.BorderSize = 1;

            Preencher();
            PrencheerCombo();

            DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
            editar.Name = "Editar";

            editar.FlatStyle = FlatStyle.Flat;

            editar.UseColumnTextForButtonValue = true;

            editar.Text = "Editar";
            int columnIndex1 = 4;
            if (tabela.Columns["Editar"] == null)
            {
                tabela.Columns.Insert(columnIndex1, editar);
            }

            DataGridViewButtonColumn excluir = new DataGridViewButtonColumn();
            excluir.Name = "Excluir";

            excluir.FlatStyle = FlatStyle.Flat;

            excluir.UseColumnTextForButtonValue = true;

            excluir.Text = "Excluir";
            int columnIndex = 5;
            if (tabela.Columns["Excluir"] == null)
            {
                tabela.Columns.Insert(columnIndex, excluir);
            }
        }

        public void PrencheerCombo()
        {
            var listaSetor = controle.listarSetor();
            foreach (Setor setor in listaSetor)
            {
                txtPesquisaSetor.Items.Add(setor.Tipo);
            }
        }

        public void Preencher()
        {

            List<Cargo> lstUsr = controle.listarCargo();
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                Codigo = usuario.Codigo,
                Nome = usuario.Nome,
                Carga = usuario.Carga_horaria,
                Setor = controle.procurarSetorNomes(usuario.Setor_id)

            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }

        private void tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabela.Columns["Excluir"].Index)
            {
                controle.excluirCargo(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));
                MessageBox.Show("Cargo Excluído com sucesso!", "Cargo Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Preencher();
            }
            else if (e.ColumnIndex == tabela.Columns["Editar"].Index)
            {
                CadastroCargo cadastroCargo = new CadastroCargo(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));
                Hide();
                cadastroCargo.Show();
            }
        }

        private void CadastrarSetor_Click(object sender, EventArgs e)
        {
            CadastroCargo cargo = new CadastroCargo(0);
            Hide();
            cargo.Show();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaSetores tela = new TelaSetores();
            Hide();
            tela.Show();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            List<Cargo> lstUsr = controle.listarCargoCodigo(Convert.ToInt32(txtPesquisaCod.Value));
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                Codigo = usuario.Codigo,
                Nome = usuario.Nome,
                Carga = usuario.Carga_horaria,
                Setor = controle.procurarSetorNomes(usuario.Setor_id)

            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }

        private void BtnPesquisaSetor_Click(object sender, EventArgs e)
        {
            List<Cargo> lstUsr = controle.listarCargoSetor(txtPesquisaSetor.Text);
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                Codigo = usuario.Codigo,
                Nome = usuario.Nome,
                Carga = usuario.Carga_horaria,
                Setor = controle.procurarSetorNomes(usuario.Setor_id)

            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }
    }
}
