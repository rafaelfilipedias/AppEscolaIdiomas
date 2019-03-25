namespace AppEscolaIdiomas
{
    partial class frmMenuAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.pnlMostrar = new System.Windows.Forms.Panel();
            this.btnVoltarLogin = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlMenu.Controls.Add(this.btnExcluirFunc);
            this.pnlMenu.Controls.Add(this.btnFunc);
            this.pnlMenu.Controls.Add(this.btnTurma);
            this.pnlMenu.Controls.Add(this.btnAluno);
            this.pnlMenu.Controls.Add(this.pnlMostrar);
            this.pnlMenu.Controls.Add(this.btnVoltarLogin);
            this.pnlMenu.Controls.Add(this.btnProfessor);
            this.pnlMenu.Controls.Add(this.btnIdioma);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1095, 667);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.FlatAppearance.BorderSize = 0;
            this.btnExcluirFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFunc.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirFunc.Location = new System.Drawing.Point(3, 433);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(174, 67);
            this.btnExcluirFunc.TabIndex = 9;
            this.btnExcluirFunc.Text = "Excluir Funcionário";
            this.btnExcluirFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirFunc.UseVisualStyleBackColor = true;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFunc.Location = new System.Drawing.Point(0, 29);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(174, 83);
            this.btnFunc.TabIndex = 8;
            this.btnFunc.Text = "Manter Funcionário";
            this.btnFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.FlatAppearance.BorderSize = 0;
            this.btnTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurma.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTurma.Location = new System.Drawing.Point(3, 363);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(174, 64);
            this.btnTurma.TabIndex = 7;
            this.btnTurma.Text = "Excluir Turma";
            this.btnTurma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurma.UseVisualStyleBackColor = true;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAluno.Location = new System.Drawing.Point(3, 292);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(174, 65);
            this.btnAluno.TabIndex = 6;
            this.btnAluno.Text = "Excluir Aluno";
            this.btnAluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlMostrar.Controls.Add(this.lblTitulo2);
            this.pnlMostrar.Controls.Add(this.lblTitulo);
            this.pnlMostrar.Location = new System.Drawing.Point(180, 3);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(970, 667);
            this.pnlMostrar.TabIndex = 5;
            this.pnlMostrar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMostrar_Paint);
            // 
            // btnVoltarLogin
            // 
            this.btnVoltarLogin.FlatAppearance.BorderSize = 0;
            this.btnVoltarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltarLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarLogin.Image")));
            this.btnVoltarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltarLogin.Location = new System.Drawing.Point(3, 604);
            this.btnVoltarLogin.Name = "btnVoltarLogin";
            this.btnVoltarLogin.Size = new System.Drawing.Size(174, 60);
            this.btnVoltarLogin.TabIndex = 3;
            this.btnVoltarLogin.Text = "Voltar";
            this.btnVoltarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarLogin.UseVisualStyleBackColor = true;
            this.btnVoltarLogin.Click += new System.EventHandler(this.btnVoltarLogin_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.FlatAppearance.BorderSize = 0;
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfessor.Location = new System.Drawing.Point(3, 206);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(174, 80);
            this.btnProfessor.TabIndex = 1;
            this.btnProfessor.Text = "Excluir Professor";
            this.btnProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnIdioma
            // 
            this.btnIdioma.FlatAppearance.BorderSize = 0;
            this.btnIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdioma.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdioma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIdioma.Location = new System.Drawing.Point(3, 118);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(174, 72);
            this.btnIdioma.TabIndex = 0;
            this.btnIdioma.Text = "Excluir Idioma";
            this.btnIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdioma.UseVisualStyleBackColor = true;
            this.btnIdioma.Click += new System.EventHandler(this.btnIdioma_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(98, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(406, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bem vindo Administrador";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(99, 106);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(488, 36);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Escolha uma das opções ao lado";
            // 
            // frmMenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1122, 693);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuAdm";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMostrar.ResumeLayout(false);
            this.pnlMostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Panel pnlMostrar;
        private System.Windows.Forms.Button btnVoltarLogin;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnIdioma;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblTitulo;
    }
}