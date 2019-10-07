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

namespace Universidade.View
{
    public partial class Professor : Form
    {
        private static DaoPessoa dao = new DaoPessoa();
        private static Arquivos arquivo = new Arquivos();

        public Professor()
        {
            InitializeComponent();
            Preencher();

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;
        }

        public void Preencher()
        {

            List<Pessoa > lstUsr = dao.listarPessoa();
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                RA = usuario.RA,
                Nome = usuario.Nome,
                Celular = usuario.Telefone.TelefoneCelular,
                Fixo = usuario.Telefone.TelefoneFixo,
                Rua = usuario.Endereco.Rua,
                Número = usuario.Endereco.Numero,
                Cep = usuario.Endereco.Cep,
                Bairro = usuario.Endereco.Bairro
            }).ToList();

            tabela.DataSource = novaListUsuario;
            this.tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;

            DataGridViewButtonColumn excluir = new DataGridViewButtonColumn();
            excluir.Name = "Excluir";
        
            excluir.FlatStyle = FlatStyle.Flat;
      
            excluir.UseColumnTextForButtonValue = true;

            excluir.Text = "Excluir";
            int columnIndex = 8;
            if (tabela.Columns["Excluir"] == null)
            {
                tabela.Columns.Insert(columnIndex, excluir);
            }
        }

        private void tabela_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabela.Columns["Excluir"].Index)
            {
                dao.excluirPessoa(Convert.ToInt32(tabela.CurrentRow.Cells[1].Value.ToString()));
                MessageBox.Show("Usuário Excluído com sucesso!","Usuário Excluído",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Preencher();
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            Hide();
            telaUsuario.Show();
        }
    }
}
