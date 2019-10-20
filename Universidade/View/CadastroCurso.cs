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

namespace Universidade.View
{
    public partial class CadastroCurso : Form
    {
        DaoCoodenador dao = new DaoCoodenador();
        DaoProfessor daoProf = new DaoProfessor();
        private Curso curso = new Curso();
        private static List<Materias> listaMaterias = new List<Materias>();

        public CadastroCurso()
        {
            InitializeComponent();

            btnCadastrarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuario.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCadastrarUsuario.FlatAppearance.BorderSize = 1;


            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

            addItem.FlatStyle = FlatStyle.Flat;
            addItem.FlatAppearance.BorderColor = Color.ForestGreen;
            addItem.FlatAppearance.BorderSize = 1;

            PrencheerCombo();
            PrencheerComboProfessor();
        }

        public void PrencheerCombo()
        {
            var listaCoordenador = dao.listarCoordenador();
            foreach (Coordenador coord in listaCoordenador)
            {
                txtCoordenador.Items.Add(coord.Nome);
            }
        }

        public void PrencheerComboProfessor()
        {
            var listaProfessor = daoProf.listarProfessor();
            foreach (Professores professores in listaProfessor)
            {
                txtProfessor.Items.Add(professores.Nome);
            }
        }

        public void AddItem_Click(object sender, EventArgs e)
        {
            Materias materia = new Materias();

            materia.Nome = txtNomeM.Text;
            materia.Codigo = Convert.ToInt32(txtCod.Value);
            materia.Carga_horaria = Convert.ToInt32(txtCarga.Value);

            var pesquisa = new DaoProfessor().procurarProfessorNome(txtProfessor.Text);
            materia.Professor_id = pesquisa.NR;

            listaMaterias.Add(materia);
           
            txtNomeM.Text = "";
            txtCod.Value = 0;
            txtCarga.Value = 0;
            txtProfessor.Text = "";
            listar();
        }

        public void listar()
        {
            richTextBox1.Clear();
            foreach (Materias materias in listaMaterias)
            {
                var pesquisa = new DaoProfessor().procurarProfessor(materias.Professor_id);
                richTextBox1.AppendText("Máteria: "+materias.Nome+"\nCódigo: "+materias.Codigo+"\nCarga Horária: "+materias.Carga_horaria+"\nProfessor: "+pesquisa.Nome+"\n\n");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {            
            Form1 form1 = new Form1();
            Hide();
            form1.Show();            
        }
    }
}
