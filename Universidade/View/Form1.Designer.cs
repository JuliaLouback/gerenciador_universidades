namespace Universidade
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrarSetores = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(98, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Gerenciamento de Universidades\r\n";
            // 
            // btnCadastrarUser
            // 
            this.btnCadastrarUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarUser.Image")));
            this.btnCadastrarUser.Location = new System.Drawing.Point(37, 198);
            this.btnCadastrarUser.Name = "btnCadastrarUser";
            this.btnCadastrarUser.Size = new System.Drawing.Size(217, 130);
            this.btnCadastrarUser.TabIndex = 2;
            this.btnCadastrarUser.UseVisualStyleBackColor = false;
            this.btnCadastrarUser.Click += new System.EventHandler(this.BtnCadastrarUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(100, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuários";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCurso.Image")));
            this.btnCadastrarCurso.Location = new System.Drawing.Point(289, 198);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(217, 130);
            this.btnCadastrarCurso.TabIndex = 7;
            this.btnCadastrarCurso.UseVisualStyleBackColor = false;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.BtnCadastrarCurso_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(615, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Setores";
            // 
            // btnCadastrarSetores
            // 
            this.btnCadastrarSetores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarSetores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarSetores.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarSetores.Image")));
            this.btnCadastrarSetores.Location = new System.Drawing.Point(541, 198);
            this.btnCadastrarSetores.Name = "btnCadastrarSetores";
            this.btnCadastrarSetores.Size = new System.Drawing.Size(217, 130);
            this.btnCadastrarSetores.TabIndex = 9;
            this.btnCadastrarSetores.UseVisualStyleBackColor = false;
            this.btnCadastrarSetores.Click += new System.EventHandler(this.btnCadastrarSetores_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(365, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cursos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(283, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Painel de Controle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrarSetores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrarCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrarUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Universidades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrarSetores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

