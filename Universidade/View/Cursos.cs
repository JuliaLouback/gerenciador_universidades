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
using Universidade.Entidades;
using Universidade.Controler;

namespace Universidade.View
{
    public partial class Cursos : Form
    {
        ControleClass controleClasse = new ControleClass();
        public Cursos()
        {
            InitializeComponent();
            Preencher();

            cadastrarCurso.FlatStyle = FlatStyle.Flat;
            cadastrarCurso.FlatAppearance.BorderColor = Color.ForestGreen;
            cadastrarCurso.FlatAppearance.BorderSize = 1;

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

            btnPesquisa.FlatStyle = FlatStyle.Flat;
            btnPesquisa.FlatAppearance.BorderColor = Color.DarkCyan;
            btnPesquisa.FlatAppearance.BorderSize = 1;

            btnPesquisaNome.FlatStyle = FlatStyle.Flat;
            btnPesquisaNome.FlatAppearance.BorderColor = Color.DarkCyan;
            btnPesquisaNome.FlatAppearance.BorderSize = 1;

            DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
            editar.Name = "Editar";

            editar.FlatStyle = FlatStyle.Flat;

            editar.UseColumnTextForButtonValue = true;

            editar.Text = "Editar";
            int columnIndex1 = 3;
            if (tabela.Columns["Editar"] == null)
            {
                tabela.Columns.Insert(columnIndex1, editar);
            }

            /*DataGridViewButtonColumn excluir = new DataGridViewButtonColumn();
            excluir.Name = "Excluir";

            excluir.FlatStyle = FlatStyle.Flat;

            excluir.UseColumnTextForButtonValue = true;

            excluir.Text = "Excluir";
            int columnIndex = 4;
            if (tabela.Columns["Excluir"] == null)
            {
                tabela.Columns.Insert(columnIndex, excluir);
            }*/
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.Show();
        }

        private void CadastrarCurso_Click(object sender, EventArgs e)
        {
            CadastroCurso cadastroCurso = new CadastroCurso();
            Hide();
            cadastroCurso.Show();
        }

        public void Preencher()
        {

            List<Curso> lstUsr = controleClasse.listarCurso();
            var novaListUsuario = lstUsr.Select(usuario => new
            {
               Código = usuario.Codigo,
               Nome = usuario.Nome,
               Período = usuario.QuantidadePeriodo
        }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }

        private void tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.ColumnIndex == tabela.Columns["Excluir"].Index)
            {
                controleClasse.excluirCurso(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));

                MessageBox.Show("Curso Excluído com sucesso!", "Curso Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Preencher();
            }*/
            //else if (e.ColumnIndex == tabela.Columns["Editar"].Index)
            //{
                EdicaoCurso cadastroCurso = new EdicaoCurso(Convert.ToInt32(tabela.CurrentRow.Cells[1].Value.ToString()));
                Hide();
                cadastroCurso.Show();
            //}
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }


        private void btn_ProcurarCodigo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ProcurarNome_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            List<Curso> lstUsr = controleClasse.procurarCursoCodigo(Convert.ToInt32(txtPesquisaCod.Value));
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                Código = usuario.Codigo,
                Nome = usuario.Nome,
                Período = usuario.QuantidadePeriodo
            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }

        private void BtnPesquisaNome_Click(object sender, EventArgs e)
        {
            List<Curso> lstUsr = controleClasse.procurarCursosNome(txtPesquisaNome.Text);
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                Código = usuario.Codigo,
                Nome = usuario.Nome,
                Período = usuario.QuantidadePeriodo
            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }
    }
}
