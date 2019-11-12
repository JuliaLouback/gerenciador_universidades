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
        ControleClass controles = new ControleClass();

        public int verificar = 0;
        private static List<Materias> listaMaterias = new List<Materias>();
        public string NomeCoor;
        public string NomeProf;
        Professores prof = new Professores();

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
            removerMaterias.FlatAppearance.BorderColor = Color.Red;
            removerMaterias.FlatAppearance.BorderSize = 1;

            //txtNome.Enabled = false;

            verificar = codigo;

            var pesquisa = controles.procurarCurso(verificar);

            PreencherCampos(pesquisa);
            PrencheerCombo();
            PrencheerComboProfessor();
        }

        public void PreencherCampos(Curso item)
        {
            txtCodigo.Value     = item.Codigo;
            txtNome.Text        = item.Nome;
            var pesquisaCoor    = controles.procurarCoordenador(item.Coordernador_id);
            if (pesquisaCoor != null) {
                txtCoordenador.Text = pesquisaCoor.Nome;
                NomeCoor = pesquisaCoor.Nome;
            }
            txtQuantidadePeriodo.Text = Convert.ToString(item.QuantidadePeriodo);
            listaMaterias       = item.Materias; 
        }

        private void TxtPeriodo_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNomeM.Items.Clear();
            List<Materias> listinha = controles.procurarMateria(verificar, Convert.ToInt32(txtPeriodo.Text));

            foreach (Materias mat in listinha)
            {
                txtNomeM.Items.Add(mat.Nome);
            }
        }

        public void PrencheerCombo()
        {
            var listaCoordenador = controles.listarCoordenador();
            foreach (Coordenador coord in listaCoordenador)
            {
                txtCoordenador.Items.Add(coord.Nome);
            }
        }

        public void PrencheerComboProfessor()
        {
            var listaProfessor = controles.listarProfessorMateria();
            foreach (Professores professores in listaProfessor)
            {
                txtProfessor.Items.Add(professores.Nome);
                txtNProfessor.Items.Add(professores.Nome);
            }
        }

        private void TxtNomeM_SelectedValueChanged(object sender, EventArgs e)
        {
            var listinhas = controles.procurarMateriaNome(verificar, txtNomeM.Text);

            txtCod.Value = listinhas.Codigo;
            txtCarga.Value = listinhas.Carga_horaria;

            var listinhas2 = controles.procurarProfessor(listinhas.Professor_id);
            if (listinhas2 != null) { 
                txtProfessor.Text = listinhas2.Nome;
                NomeProf = txtProfessor.Text;
                prof = listinhas2;
            }
        }

        private void EditarItem_Click(object sender, EventArgs e)
        {
            Materias materia = new Materias();

            materia.Nome            = txtNomeM.Text;
            materia.Codigo          = Convert.ToInt32(txtCod.Value);
            materia.Carga_horaria   = Convert.ToInt32(txtCarga.Value);
            materia.Periodo         = Convert.ToInt32(txtPeriodo.Text);

            var pesquisa = controles.procurarProfessorNome(txtProfessor.Text);
            if (pesquisa != null)
            {
                pesquisa.Curso_id = Convert.ToInt32(txtCodigo.Value);
                pesquisa.Materia_id = Convert.ToInt32(txtCod.Value);
            }
    

            materia.Professor_id = pesquisa.NR;

            listaMaterias.RemoveAll(x => x.Codigo == Convert.ToInt32(txtCod.Value));

            listaMaterias.Add(materia);

            if (NomeProf == txtProfessor.Text)
            {
                controles.excluirProfessor(pesquisa.NR);
                controles.adicionarProfessor(pesquisa);
            }
            else
            {
                var pesquisaProf2 = controles.procurarProfessorNome(NomeProf);
                pesquisaProf2.Curso_id   = 0;
                pesquisaProf2.Materia_id = 0;
                controles.excluirProfessor(Convert.ToInt32(pesquisaProf2.NR));
                controles.adicionarProfessor(pesquisaProf2);

                controles.excluirProfessor(Convert.ToInt32(pesquisa.NR));
                controles.adicionarProfessor(pesquisa);
            }

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

            var pesquisa = controles.procurarProfessorNome(txtNProfessor.Text);
            pesquisa.Curso_id   = Convert.ToInt32(txtCodigo.Value); ;
            pesquisa.Materia_id = Convert.ToInt32(txtNCodigo.Value); ;

            materia.Professor_id = pesquisa.NR;

            listaMaterias.Add(materia);

            controles.excluirProfessor(pesquisa.NR);
            controles.adicionarProfessor(pesquisa);

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

            var pesquisaCood = controles.procurarCoordenadorNome(txtCoordenador.Text);
            pesquisaCood.Curso_id = Convert.ToInt32(txtCodigo.Value); 

            curso.Coordernador_id = pesquisaCood.NR;
            if (NomeCoor == txtCoordenador.Text)
            {
                controles.excluirCoordenador(Convert.ToInt32(pesquisaCood.NR));
                controles.adicionarCoordenador(pesquisaCood);
            } else
            {
                var pesquisaCood2 = controles.procurarCoordenadorNome(NomeCoor);
                pesquisaCood2.Curso_id = 0;
                controles.excluirCoordenador(Convert.ToInt32(pesquisaCood2.NR));
                controles.adicionarCoordenador(pesquisaCood2);

                controles.excluirCoordenador(Convert.ToInt32(pesquisaCood.NR));
                controles.adicionarCoordenador(pesquisaCood);
            }
           

            controles.excluirCurso(Convert.ToInt32(txtCodigo.Value));
            controles.adicionarCurso(curso);

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
