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
    public partial class EdicaoCurso : Form
    {
        public int verificar = 0;
        private static List<Materias> listaMaterias = new List<Materias>();
        public string NomeCoor;

        public EdicaoCurso(int codigo)
        {
            InitializeComponent();


            btnCadastrarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuario.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCadastrarUsuario.FlatAppearance.BorderSize = 1;

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;

            editarItem.FlatStyle = FlatStyle.Flat;
            editarItem.FlatAppearance.BorderColor = Color.ForestGreen;
            editarItem.FlatAppearance.BorderSize = 1;

            addItem.FlatStyle = FlatStyle.Flat;
            addItem.FlatAppearance.BorderColor = Color.ForestGreen;
            addItem.FlatAppearance.BorderSize = 1;

            removerMaterias.FlatStyle = FlatStyle.Flat;
            removerMaterias.FlatAppearance.BorderColor = Color.ForestGreen;
            removerMaterias.FlatAppearance.BorderSize = 1;

            verificar = codigo;

            var pesquisa = new ControleClass().procurarCurso(verificar);

            PreencherCampos(pesquisa);
            PrencheerCombo();
            PrencheerComboProfessor();
        }

        public void PreencherCampos(Curso item)
        {
            txtCodigo.Value     = item.Codigo;
            txtNome.Text        = item.Nome;
            var pesquisaCoor    = new ControleClass().procurarCoordenador(item.Coordernador_id);
            txtCoordenador.Text = pesquisaCoor.Nome;
            NomeCoor            = pesquisaCoor.Nome;
            txtQuantidadePeriodo.Text = Convert.ToString(item.QuantidadePeriodo);
            listaMaterias       = item.Materias; 
        }

        private void TxtPeriodo_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNomeM.Items.Clear();
            List<Materias> listinha = new ControleClass().procurarMateria(verificar, Convert.ToInt32(txtPeriodo.Text));

            foreach (Materias mat in listinha)
            {
                txtNomeM.Items.Add(mat.Nome);
            }
        }

        public void PrencheerCombo()
        {
            var listaCoordenador = new ControleClass().listarCoordenador();
            foreach (Coordenador coord in listaCoordenador)
            {
                txtCoordenador.Items.Add(coord.Nome);
            }
        }

        public void PrencheerComboProfessor()
        {
            var listaProfessor = new ControleClass().listarProfessor();
            foreach (Professores professores in listaProfessor)
            {
                txtProfessor.Items.Add(professores.Nome);
                txtNProfessor.Items.Add(professores.Nome);
            }
        }

        private void TxtNomeM_SelectedValueChanged(object sender, EventArgs e)
        {
            var listinhas = new ControleClass().procurarMateriaNome(verificar, txtNomeM.Text);

            txtCod.Value = listinhas.Codigo;
            txtCarga.Value = listinhas.Carga_horaria;

            var listinhas2 = new ControleClass().procurarProfessor(listinhas.Professor_id);
            txtProfessor.Text = listinhas2.Nome;
        }

        private void EditarItem_Click(object sender, EventArgs e)
        {
            Materias materia = new Materias();

            materia.Nome            = txtNomeM.Text;
            materia.Codigo          = Convert.ToInt32(txtCod.Value);
            materia.Carga_horaria   = Convert.ToInt32(txtCarga.Value);
            materia.Periodo         = Convert.ToInt32(txtPeriodo.Text);

            var pesquisa = new ControleClass().procurarProfessorNome(txtProfessor.Text);
            pesquisa.Curso = txtNome.Text;
            pesquisa.Materia = txtNomeM.Text;

            materia.Professor_id = pesquisa.NR;

            listaMaterias.RemoveAll(x => x.Codigo == Convert.ToInt32(txtCod.Value));

            listaMaterias.Add(materia);

            new ControleClass().excluirProfessor(pesquisa.NR);
            new ControleClass().adicionarProfessor(pesquisa);

            MessageBox.Show("Matéria editada com sucesso!", "Matéria editada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNomeM.Text   = "";
            txtCod.Value    = 0;
            txtCarga.Value  = 0;
            txtProfessor.Text   = "";
            txtPeriodo.Text     = "";
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            Materias materia = new Materias();

            materia.Nome = txtNNome.Text;
            materia.Codigo = Convert.ToInt32(txtNCodigo.Value);
            materia.Carga_horaria = Convert.ToInt32(txtNCargo.Value);
            materia.Periodo = Convert.ToInt32(txtNPeriodo.Text);

            var pesquisa = new ControleClass().procurarProfessorNome(txtNProfessor.Text);
            pesquisa.Curso   = txtNome.Text;
            pesquisa.Materia = txtNNome.Text;

            materia.Professor_id = pesquisa.NR;

            listaMaterias.Add(materia);

            new ControleClass().excluirProfessor(pesquisa.NR);
            new ControleClass().adicionarProfessor(pesquisa);

            MessageBox.Show("Matéria cadastrada com sucesso!", "Matéria cadastrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNNome.Text       = "";
            txtNCodigo.Value    = 0;
            txtNCargo.Value     = 0;
            txtNProfessor.Text  = "";
            txtNPeriodo.Text      = "";
        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();

            curso.Materias = listaMaterias;
            curso.Codigo = Convert.ToInt32(txtCodigo.Value);
            curso.Nome = txtNome.Text;
            curso.QuantidadePeriodo = Convert.ToInt32(txtQuantidadePeriodo.Text);

            var pesquisaCood = new ControleClass().procurarCoordenadorNome(txtCoordenador.Text);
            pesquisaCood.Curso = txtNome.Text; 

            curso.Coordernador_id = pesquisaCood.NR;
            if (NomeCoor == txtCoordenador.Text)
            {
                new ControleClass().excluirCoordenador(Convert.ToInt32(pesquisaCood.NR));
                new ControleClass().adicionarCoordenador(pesquisaCood);
            } else
            {
                var pesquisaCood2 = new ControleClass().procurarCoordenadorNome(NomeCoor);
                pesquisaCood2.Curso = "";
                new ControleClass().excluirCoordenador(Convert.ToInt32(pesquisaCood2.NR));
                new ControleClass().adicionarCoordenador(pesquisaCood2);

                new ControleClass().excluirCoordenador(Convert.ToInt32(pesquisaCood.NR));
                new ControleClass().adicionarCoordenador(pesquisaCood);
            }
           

            new ControleClass().excluirCurso(Convert.ToInt32(txtCodigo.Value));
            new ControleClass().adicionarCurso(curso);

            MessageBox.Show("Curso editado com sucesso!", "Curso editado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoverMaterias_Click(object sender, EventArgs e)
        {
            listaMaterias.RemoveAll(x => x.Codigo == Convert.ToInt32(txtCod.Value));
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            Hide();
            curso.Show();
        }
    }
}
