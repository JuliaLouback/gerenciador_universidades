﻿using System;
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
    public partial class Aluno : Form
    {
        public Aluno()
        {
            InitializeComponent();
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

            List<Alunos> lstUsr = new ControleClass().listarAluno();
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                Código = usuario.NR,
                Nome = usuario.Nome,
                CPF = usuario.CPF,
                Email = usuario.Email,
                Curso = usuario.Curso,

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
                new ControleClass().excluirAluno(Convert.ToInt32(tabela.CurrentRow.Cells[2].Value.ToString()));
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
    }
}
