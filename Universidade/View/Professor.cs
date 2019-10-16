using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universidade.DAO;
using Universidade.Arquivo;
using Universidade.Entidades;
using Universidade.Controler;

namespace Universidade.View
{
    public partial class Professor : Form
    {
        private static DaoProfessor dao = new DaoProfessor();
     
        public Professor()
        {
            InitializeComponent();
            Preencher();

            cadastrarProfessor.FlatStyle = FlatStyle.Flat;
            cadastrarProfessor.FlatAppearance.BorderColor = Color.ForestGreen;
            cadastrarProfessor.FlatAppearance.BorderSize = 1;

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;


            DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
            editar.Name = "Editar";

            editar.FlatStyle = FlatStyle.Flat;

            editar.UseColumnTextForButtonValue = true;

            editar.Text = "Editar";
            int columnIndex1 = 6;
            if (tabela.Columns["Editar"] == null)
            {
                tabela.Columns.Insert(columnIndex1, editar);
            }

            DataGridViewButtonColumn excluir = new DataGridViewButtonColumn();
            excluir.Name = "Excluir";

            excluir.FlatStyle = FlatStyle.Flat;

            excluir.UseColumnTextForButtonValue = true;

            excluir.Text = "Excluir";
            int columnIndex = 7;
            if (tabela.Columns["Excluir"] == null)
            {
                tabela.Columns.Insert(columnIndex, excluir);
            }
        }

        public void Preencher()
        {

            List<Professores > lstUsr = new ControleClass().listarProfessor();
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                NR = usuario.NR,
                Nome = usuario.Nome,
                CPF = usuario.CPF,
                Email = usuario.Email,
                Curso = usuario.Curso,
                Matérias = usuario.Materia
            }).ToList();

            tabela.DataSource = novaListUsuario;
            this.tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }

        private void tabela_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabela.Columns["Excluir"].Index)
            {
                new ControleClass().excluirProfessor(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));
                MessageBox.Show("Usuário Excluído com sucesso!","Usuário Excluído",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Preencher();
            } else if (e.ColumnIndex == tabela.Columns["Editar"].Index)
            {
                CadastroUsuario cadastroUsuario = new CadastroUsuario(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));
                Hide();
                cadastroUsuario.Show();
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            Hide();
            telaUsuario.Show();
        }

        private void CadastrarProfessor_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario(0);
            Hide();
            cadastroUsuario.Show();
        }
    }
}
