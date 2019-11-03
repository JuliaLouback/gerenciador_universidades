namespace Universidade.View
{
    partial class Cargos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargos));
            this.tabela = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cadastrarSetor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisaSetor = new System.Windows.Forms.Button();
            this.txtPesquisaCod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisaSetor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisaCod)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle4;
            this.tabela.Location = new System.Drawing.Point(56, 209);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(1183, 299);
            this.tabela.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(568, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cargos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(310, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 33);
            this.label1.TabIndex = 57;
            this.label1.Text = "Sistema de Gerenciamento de Universidades\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 65);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(56, 527);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(128, 43);
            this.btnVoltar.TabIndex = 60;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // cadastrarSetor
            // 
            this.cadastrarSetor.BackColor = System.Drawing.Color.ForestGreen;
            this.cadastrarSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarSetor.ForeColor = System.Drawing.Color.White;
            this.cadastrarSetor.Location = new System.Drawing.Point(1088, 116);
            this.cadastrarSetor.Name = "cadastrarSetor";
            this.cadastrarSetor.Size = new System.Drawing.Size(151, 52);
            this.cadastrarSetor.TabIndex = 61;
            this.cadastrarSetor.Text = "Cadastrar";
            this.cadastrarSetor.UseVisualStyleBackColor = false;
            this.cadastrarSetor.Click += new System.EventHandler(this.CadastrarSetor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(631, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 77;
            this.label2.Text = "Pesquisar por Setor";
            // 
            // btnPesquisaSetor
            // 
            this.btnPesquisaSetor.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisaSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaSetor.ForeColor = System.Drawing.Color.White;
            this.btnPesquisaSetor.Location = new System.Drawing.Point(1116, 570);
            this.btnPesquisaSetor.Name = "btnPesquisaSetor";
            this.btnPesquisaSetor.Size = new System.Drawing.Size(123, 28);
            this.btnPesquisaSetor.TabIndex = 76;
            this.btnPesquisaSetor.Text = "Pesquisar";
            this.btnPesquisaSetor.UseVisualStyleBackColor = false;
            this.btnPesquisaSetor.Click += new System.EventHandler(this.BtnPesquisaSetor_Click);
            // 
            // txtPesquisaCod
            // 
            this.txtPesquisaCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaCod.Location = new System.Drawing.Point(879, 527);
            this.txtPesquisaCod.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtPesquisaCod.Name = "txtPesquisaCod";
            this.txtPesquisaCod.Size = new System.Drawing.Size(216, 26);
            this.txtPesquisaCod.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(631, 529);
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
            this.btnPesquisa.Location = new System.Drawing.Point(1116, 527);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(123, 28);
            this.btnPesquisa.TabIndex = 73;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // txtPesquisaSetor
            // 
            this.txtPesquisaSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaSetor.FormattingEnabled = true;
            this.txtPesquisaSetor.Location = new System.Drawing.Point(879, 570);
            this.txtPesquisaSetor.Name = "txtPesquisaSetor";
            this.txtPesquisaSetor.Size = new System.Drawing.Size(216, 26);
            this.txtPesquisaSetor.TabIndex = 78;
            // 
            // Cargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 622);
            this.Controls.Add(this.txtPesquisaSetor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisaSetor);
            this.Controls.Add(this.txtPesquisaCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.cadastrarSetor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Universidades";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisaCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button cadastrarSetor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisaSetor;
        private System.Windows.Forms.NumericUpDown txtPesquisaCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ComboBox txtPesquisaSetor;
    }
}