namespace Universidade.View
{
    partial class Alunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alunos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cadastrarFuncionario = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.txtPesquisaCod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisarCurso = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisaCod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(59, 507);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(128, 43);
            this.btnVoltar.TabIndex = 69;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 65);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // cadastrarFuncionario
            // 
            this.cadastrarFuncionario.BackColor = System.Drawing.Color.ForestGreen;
            this.cadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.cadastrarFuncionario.Location = new System.Drawing.Point(1101, 118);
            this.cadastrarFuncionario.Name = "cadastrarFuncionario";
            this.cadastrarFuncionario.Size = new System.Drawing.Size(141, 45);
            this.cadastrarFuncionario.TabIndex = 67;
            this.cadastrarFuncionario.Text = "Cadastrar";
            this.cadastrarFuncionario.UseVisualStyleBackColor = false;
            this.cadastrarFuncionario.Click += new System.EventHandler(this.CadastrarAluno_Click);
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabela.Location = new System.Drawing.Point(59, 192);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(1183, 299);
            this.tabela.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(599, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 31);
            this.label3.TabIndex = 65;
            this.label3.Text = "Alunos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(348, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 33);
            this.label1.TabIndex = 64;
            this.label1.Text = "Sistema de Gerenciamento de Universidades\r\n";
            // 
            // txtPesquisaCurso
            // 
            this.txtPesquisaCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaCurso.Location = new System.Drawing.Point(884, 545);
            this.txtPesquisaCurso.Name = "txtPesquisaCurso";
            this.txtPesquisaCurso.Size = new System.Drawing.Size(216, 24);
            this.txtPesquisaCurso.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(637, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 77;
            this.label2.Text = "Pesquisar por Nome";
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaNome.ForeColor = System.Drawing.Color.White;
            this.btnPesquisaNome.Location = new System.Drawing.Point(1121, 544);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(123, 28);
            this.btnPesquisaNome.TabIndex = 76;
            this.btnPesquisaNome.Text = "Pesquisar";
            this.btnPesquisaNome.UseVisualStyleBackColor = false;
            this.btnPesquisaNome.Click += new System.EventHandler(this.BtnPesquisaNome_Click);
            // 
            // txtPesquisaCod
            // 
            this.txtPesquisaCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaCod.Location = new System.Drawing.Point(884, 510);
            this.txtPesquisaCod.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtPesquisaCod.Name = "txtPesquisaCod";
            this.txtPesquisaCod.Size = new System.Drawing.Size(216, 24);
            this.txtPesquisaCod.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(637, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 74;
            this.label4.Text = "Pesquisar por Código";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa.Location = new System.Drawing.Point(1121, 508);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(123, 28);
            this.btnPesquisa.TabIndex = 73;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(637, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 25);
            this.label5.TabIndex = 80;
            this.label5.Text = "Pesquisar por Curso";
            // 
            // btnPesquisarCurso
            // 
            this.btnPesquisarCurso.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCurso.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarCurso.Location = new System.Drawing.Point(1121, 581);
            this.btnPesquisarCurso.Name = "btnPesquisarCurso";
            this.btnPesquisarCurso.Size = new System.Drawing.Size(123, 28);
            this.btnPesquisarCurso.TabIndex = 79;
            this.btnPesquisarCurso.Text = "Pesquisar";
            this.btnPesquisarCurso.UseVisualStyleBackColor = false;
            this.btnPesquisarCurso.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.FormattingEnabled = true;
            this.txtCurso.Location = new System.Drawing.Point(884, 581);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(216, 24);
            this.txtCurso.TabIndex = 81;
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 624);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPesquisarCurso);
            this.Controls.Add(this.txtPesquisaCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisaNome);
            this.Controls.Add(this.txtPesquisaCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cadastrarFuncionario);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Universidades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisaCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cadastrarFuncionario;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.NumericUpDown txtPesquisaCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisarCurso;
        private System.Windows.Forms.ComboBox txtCurso;
    }
}