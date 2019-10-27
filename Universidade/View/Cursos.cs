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
        DaoCurso daoCurso = new DaoCurso();
        public Cursos()
        {
            InitializeComponent();

            cadastrarCurso.FlatStyle = FlatStyle.Flat;
            cadastrarCurso.FlatAppearance.BorderColor = Color.ForestGreen;
            cadastrarCurso.FlatAppearance.BorderSize = 1;

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

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

        private void btnListarCurso_Click(object sender, EventArgs e)
        { 
          //Não sei se esse botão é necessário. Eu fiz sem pensar no design. Talvez uma tabela seja necessária como nos outros cadastros (manter um padrão)
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int filtro;
            int.TryParse(txtFiltro.Text, out filtro);
            if (filtro != 0)
            {
                daoCurso.excluirCurso(filtro);
                //Precisa adicionar um MessageBox perguntando se deseja realmente excluir o cadastro e atribuir as devidas condições (esqueci como faz)
                //Está funcionando :D
            }
            else
            {
                MessageBox.Show("Código não encontrado!", "Atenção");
            }
            
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int filtro;
            int.TryParse(txtFiltro.Text, out filtro);
            if (filtro != 0)
            {
              //Chamar a tela de cadastro CadastroCurso passando o filtro (Código). Ao carregar a tela com o parâmetro, 
              //carregar as textbox com o conteúdo da classe. Utilizar o método procurarCurso
            }
            else
            {
                MessageBox.Show("Código inválido!", "Atenção"); //Colocar o ícone de informação 
            }
        }

        private void btn_ProcurarCodigo_Click(object sender, EventArgs e)
        {
            //Vai precisar desse botão? 
        }

        private void btn_ProcurarNome_Click(object sender, EventArgs e)
        {
            daoCurso.procurarCursoNome(txtFiltro.Text); //terminar
        }
    }
}
