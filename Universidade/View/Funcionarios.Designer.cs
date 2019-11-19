namespace Universidade.View
{
    partial class Funcionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.cadastrarFuncionario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPesquisaCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.txtPesquisaCod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisaSetor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisaSetor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisaCod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(312, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 33);
            this.label1.TabIndex = 58;
            this.label1.Text = "Sistema de Gerenciamento de Universidades\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(585, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 31);
            this.label3.TabIndex = 59;
            this.label3.Text = "Funcionários";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.tabela.Location = new System.Drawing.Point(58, 195);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(1183, 299);
            this.tabela.TabIndex = 60;
            this.tabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_CellContentClick);
            // 
            // cadastrarFuncionario
            // 
            this.cadastrarFuncionario.BackColor = System.Drawing.Color.ForestGreen;
            this.cadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.cadastrarFuncionario.Location = new System.Drawing.Point(1090, 117);
            this.cadastrarFuncionario.Name = "cadastrarFuncionario";
            this.cadastrarFuncionario.Size = new System.Drawing.Size(151, 52);
            this.cadastrarFuncionario.TabIndex = 61;
            this.cadastrarFuncionario.Text = "Cadastrar";
            this.cadastrarFuncionario.UseVisualStyleBackColor = false;
            this.cadastrarFuncionario.Click += new System.EventHandler(this.cadastrarFuncionario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 65);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(58, 509);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(128, 43);
            this.btnVoltar.TabIndex = 63;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtPesquisaCurso
            // 
            this.txtPesquisaCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaCurso.Location = new System.Drawing.Point(881, 550);
            this.txtPesquisaCurso.Name = "txtPesquisaCurso";
            this.txtPesquisaCurso.Size = new System.Drawing.Size(216, 24);
            this.txtPesquisaCurso.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(645, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Pesquisar por Nome";
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaNome.ForeColor = System.Drawing.Color.White;
            this.btnPesquisaNome.Location = new System.Drawing.Point(1118, 547);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(123, 28);
            this.btnPesquisaNome.TabIndex = 82;
            this.btnPesquisaNome.Text = "Pesquisar";
            this.btnPesquisaNome.UseVisualStyleBackColor = false;
            this.btnPesquisaNome.Click += new System.EventHandler(this.BtnPesquisaNome_Click);
            // 
            // txtPesquisaCod
            // 
            this.txtPesquisaCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaCod.Location = new System.Drawing.Point(881, 509);
            this.txtPesquisaCod.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtPesquisaCod.Name = "txtPesquisaCod";
            this.txtPesquisaCod.Size = new System.Drawing.Size(216, 24);
            this.txtPesquisaCod.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(645, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "Pesquisar por NR";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa.Location = new System.Drawing.Point(1118, 509);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(123, 28);
            this.btnPesquisa.TabIndex = 79;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // txtPesquisaSetor
            // 
            this.txtPesquisaSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaSetor.FormattingEnabled = true;
            this.txtPesquisaSetor.Location = new System.Drawing.Point(881, 593);
            this.txtPesquisaSetor.Name = "txtPesquisaSetor";
            this.txtPesquisaSetor.Size = new System.Drawing.Size(216, 26);
            this.txtPesquisaSetor.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(645, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Pesquisar por Setor";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btnPesquisaSetor
            // 
            this.btnPesquisaSetor.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisaSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaSetor.ForeColor = System.Drawing.Color.White;
            this.btnPesquisaSetor.Location = new System.Drawing.Point(1118, 593);
            this.btnPesquisaSetor.Name = "btnPesquisaSetor";
            this.btnPesquisaSetor.Size = new System.Drawing.Size(123, 28);
            this.btnPesquisaSetor.TabIndex = 85;
            this.btnPesquisaSetor.Text = "Pesquisar";
            this.btnPesquisaSetor.UseVisualStyleBackColor = false;
            this.btnPesquisaSetor.Click += new System.EventHandler(this.btnPesquisaSetor_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 659);
            this.Controls.Add(this.txtPesquisaSetor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPesquisaSetor);
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
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Universidades";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisaCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button cadastrarFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtPesquisaCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.NumericUpDown txtPesquisaCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ComboBox txtPesquisaSetor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisaSetor;
    }
}