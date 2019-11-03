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
    public partial class Funcionarios : Form
    {
        ControleClass controle = new ControleClass();

        public Funcionarios()
        {
            InitializeComponent();
            Preencher();

            cadastrarFuncionario.FlatStyle = FlatStyle.Flat;
            cadastrarFuncionario.FlatAppearance.BorderColor = Color.ForestGreen;
            cadastrarFuncionario.FlatAppearance.BorderSize = 1;

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

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
        public void Preencher()
        {

            List<Funcionario> lstFun = new ControleClass().listarFuncionario();
            var novaListFuncionario= lstFun.Select(funcionario => new
            {
                NR = funcionario.NR,
                Nome = funcionario.Nome,
                Setor = controle.procurarSetorNomes(funcionario.Setor_id),
                Cargo = controle.procurarCargoNomes(funcionario.Cargo_id)
            }).ToList();

            tabela.DataSource = novaListFuncionario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }
        private void tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabela.Columns["Excluir"].Index)
            {
                new ControleClass().excluirFuncionario(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));
                MessageBox.Show("Funcionário excluído com sucesso!", "Funcionário Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Preencher();
            }
            else if (e.ColumnIndex == tabela.Columns["Editar"].Index)
            {
                CadastroFuncionario cadastroFuncionario= new CadastroFuncionario(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));
                Hide();
                cadastroFuncionario.Show();
            }
        }

        private void cadastrarFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario(0);
            Hide();
            cadastroFuncionario.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuarios = new TelaUsuarios();
            Hide();
            telaUsuarios.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
