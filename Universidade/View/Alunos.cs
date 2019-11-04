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
    public partial class Alunos : Form
    {
        ControleClass controle = new ControleClass();

        public Alunos()
        {
            InitializeComponent();

            cadastrarFuncionario.FlatStyle = FlatStyle.Flat;
            cadastrarFuncionario.FlatAppearance.BorderColor = Color.ForestGreen;
            cadastrarFuncionario.FlatAppearance.BorderSize = 1;

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

            Preencher();

            DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
            editar.Name = "Editar";

            editar.FlatStyle = FlatStyle.Flat;

            editar.UseColumnTextForButtonValue = true;

            editar.Text = "Editar";
            int columnIndex1 = 5;
            if (tabela.Columns["Editar"] == null)
            {
                tabela.Columns.Insert(columnIndex1, editar);
            }

            DataGridViewButtonColumn excluir = new DataGridViewButtonColumn();
            excluir.Name = "Excluir";

            excluir.FlatStyle = FlatStyle.Flat;

            excluir.UseColumnTextForButtonValue = true;

            excluir.Text = "Excluir";
            int columnIndex = 6;
            if (tabela.Columns["Excluir"] == null)
            {
                tabela.Columns.Insert(columnIndex, excluir);
            }
        }

        public void Preencher()
        {

            List<Aluno> lstUsr = controle.listarAluno();
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                NR = usuario.NR,
                Nome = usuario.Nome,
                CPF = usuario.CPF,
                Email = usuario.Email,
                Curso = controle.procurarCursoNomes(usuario.Curso_id)
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
                controle.excluirAluno(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));
                MessageBox.Show("Usuário Excluído com sucesso!", "Usuário Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Preencher();
            }
            else if (e.ColumnIndex == tabela.Columns["Editar"].Index)
            {
                CadastroAluno cadastroUsuario = new CadastroAluno(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));
                Hide();
                cadastroUsuario.Show();
            }
        }

        private void cadastrarAlunos_Click(object sender, EventArgs e)
        {
            CadastroAluno curso = new CadastroAluno(0);
            Hide();
            curso.Show();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            Hide();
            telaUsuario.Show();
        }

        private void CadastrarAluno_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastroAluno = new CadastroAluno(0);
            Hide();
            cadastroAluno.Show();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            List<Aluno> lstUsr = controle.listarAlunoCodigo(Convert.ToInt32(txtPesquisaCod.Value));
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                NR = usuario.NR,
                Nome = usuario.Nome,
                CPF = usuario.CPF,
                Email = usuario.Email,
                Curso = controle.procurarCursoNomes(usuario.Curso_id)
            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }

        private void BtnPesquisaNome_Click(object sender, EventArgs e)
        {
            List<Aluno> lstUsr = new ControleClass().listarAlunoNome(txtPesquisaCurso.Text);
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                NR = usuario.NR,
                Nome = usuario.Nome,
                CPF = usuario.CPF,
                Email = usuario.Email,
                Curso = controle.procurarCursoNomes(usuario.Curso_id)
            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Aluno> lstUsr = new ControleClass().listarAlunoNome(txtPesquisaCurso.Text);
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                NR = usuario.NR,
                Nome = usuario.Nome,
                CPF = usuario.CPF,
                Email = usuario.Email,
                Curso = controle.procurarCursoNomes(usuario.Curso_id)
            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }
    }
}
