namespace AppEscolaIdiomas
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnTurma = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.pnlMostrar = new System.Windows.Forms.Panel();
            this.btnVoltarLogin = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlMenu.Controls.Add(this.btnTurma);
            this.pnlMenu.Controls.Add(this.btnAluno);
            this.pnlMenu.Controls.Add(this.pnlMostrar);
            this.pnlMenu.Controls.Add(this.btnVoltarLogin);
            this.pnlMenu.Controls.Add(this.btnProfessor);
            this.pnlMenu.Controls.Add(this.btnIdioma);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1125, 667);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnTurma
            // 
            this.btnTurma.FlatAppearance.BorderSize = 0;
            this.btnTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurma.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTurma.Location = new System.Drawing.Point(3, 428);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(174, 94);
            this.btnTurma.TabIndex = 7;
            this.btnTurma.Text = "Manter Turma";
            this.btnTurma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurma.UseVisualStyleBackColor = true;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAluno.Location = new System.Drawing.Point(3, 324);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(174, 94);
            this.btnAluno.TabIndex = 6;
            this.btnAluno.Text = "Manter Aluno";
            this.btnAluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlMostrar.Location = new System.Drawing.Point(180, 3);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(958, 673);
            this.pnlMostrar.TabIndex = 5;
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
            this.btnVoltarLogin.Size = new System.Drawing.Size(138, 60);
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
            this.btnProfessor.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfessor.Location = new System.Drawing.Point(3, 224);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(174, 94);
            this.btnProfessor.TabIndex = 1;
            this.btnProfessor.Text = "Manter Professor";
            this.btnProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnIdioma
            // 
            this.btnIdioma.FlatAppearance.BorderSize = 0;
            this.btnIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdioma.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdioma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIdioma.Location = new System.Drawing.Point(3, 135);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(174, 83);
            this.btnIdioma.TabIndex = 0;
            this.btnIdioma.Text = "Manter Idioma";
            this.btnIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdioma.UseVisualStyleBackColor = true;
            this.btnIdioma.Click += new System.EventHandler(this.btnIdioma_Click);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1149, 691);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.pnlMenu.ResumeLayout(false);
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
    }
}