namespace AppEscolaIdiomas
{
    partial class frmManterTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterTurma));
            this.btnSair = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtNumAlunos = new System.Windows.Forms.TextBox();
            this.btnSalvaar = new System.Windows.Forms.Button();
            this.lblNumAlunos = new System.Windows.Forms.Label();
            this.picBusca = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.txtCodIdioma = new System.Windows.Forms.TextBox();
            this.lblCodIdioma = new System.Windows.Forms.Label();
            this.txtCodProf = new System.Windows.Forms.TextBox();
            this.lblCodProf = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(910, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(29, 28);
            this.btnSair.TabIndex = 232;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(133, 135);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(348, 57);
            this.txtDescricao.TabIndex = 231;
            this.txtDescricao.Text = "Aulas voltadas a conversação em francês.";
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // txtMateria
            // 
            this.txtMateria.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMateria.Location = new System.Drawing.Point(107, 96);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(253, 27);
            this.txtMateria.TabIndex = 230;
            this.txtMateria.Text = "Francês";
            this.txtMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMateria_KeyPress);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescricao.Location = new System.Drawing.Point(3, 136);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(122, 25);
            this.lblDescricao.TabIndex = 229;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMateria.Location = new System.Drawing.Point(2, 101);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(101, 25);
            this.lblMateria.TabIndex = 228;
            this.lblMateria.Text = "Matéria:";
            // 
            // txtNumAlunos
            // 
            this.txtNumAlunos.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNumAlunos.Location = new System.Drawing.Point(221, 58);
            this.txtNumAlunos.Name = "txtNumAlunos";
            this.txtNumAlunos.Size = new System.Drawing.Size(139, 27);
            this.txtNumAlunos.TabIndex = 227;
            this.txtNumAlunos.Text = "15";
            this.txtNumAlunos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAlunos_KeyPress);
            // 
            // btnSalvaar
            // 
            this.btnSalvaar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalvaar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnSalvaar.FlatAppearance.BorderSize = 0;
            this.btnSalvaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvaar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvaar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvaar.Image")));
            this.btnSalvaar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvaar.Location = new System.Drawing.Point(697, 517);
            this.btnSalvaar.Name = "btnSalvaar";
            this.btnSalvaar.Size = new System.Drawing.Size(185, 40);
            this.btnSalvaar.TabIndex = 226;
            this.btnSalvaar.Text = "Salvar";
            this.btnSalvaar.UseVisualStyleBackColor = false;
            this.btnSalvaar.Click += new System.EventHandler(this.btnSalvaar_Click);
            // 
            // lblNumAlunos
            // 
            this.lblNumAlunos.AutoSize = true;
            this.lblNumAlunos.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAlunos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumAlunos.Location = new System.Drawing.Point(3, 59);
            this.lblNumAlunos.Name = "lblNumAlunos";
            this.lblNumAlunos.Size = new System.Drawing.Size(210, 25);
            this.lblNumAlunos.TabIndex = 225;
            this.lblNumAlunos.Text = "Número de Alunos:";
            // 
            // picBusca
            // 
            this.picBusca.Image = ((System.Drawing.Image)(resources.GetObject("picBusca.Image")));
            this.picBusca.Location = new System.Drawing.Point(649, 203);
            this.picBusca.Name = "picBusca";
            this.picBusca.Size = new System.Drawing.Size(33, 28);
            this.picBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBusca.TabIndex = 224;
            this.picBusca.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(697, 593);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(185, 40);
            this.btnEditar.TabIndex = 220;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusca.Location = new System.Drawing.Point(688, 203);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(179, 27);
            this.txtBusca.TabIndex = 223;
            this.txtBusca.Text = "Busque pelo código";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            // 
            // dgvTurma
            // 
            this.dgvTurma.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Location = new System.Drawing.Point(8, 236);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(859, 150);
            this.dgvTurma.TabIndex = 222;
            this.dgvTurma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellContentClick);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNome.Location = new System.Drawing.Point(78, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 27);
            this.txtNome.TabIndex = 219;
            this.txtNome.Text = "Turma de Francês";
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAluno_KeyPress);
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeAluno.Location = new System.Drawing.Point(2, 18);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(81, 25);
            this.lblNomeAluno.TabIndex = 221;
            this.lblNomeAluno.Text = "Nome:";
            // 
            // txtCodIdioma
            // 
            this.txtCodIdioma.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCodIdioma.Location = new System.Drawing.Point(637, 53);
            this.txtCodIdioma.Name = "txtCodIdioma";
            this.txtCodIdioma.Size = new System.Drawing.Size(139, 27);
            this.txtCodIdioma.TabIndex = 240;
            this.txtCodIdioma.Text = "IDI003";
            // 
            // lblCodIdioma
            // 
            this.lblCodIdioma.AutoSize = true;
            this.lblCodIdioma.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodIdioma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodIdioma.Location = new System.Drawing.Point(460, 51);
            this.lblCodIdioma.Name = "lblCodIdioma";
            this.lblCodIdioma.Size = new System.Drawing.Size(180, 25);
            this.lblCodIdioma.TabIndex = 239;
            this.lblCodIdioma.Text = "Cód. do Idioma:";
            // 
            // txtCodProf
            // 
            this.txtCodProf.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCodProf.Location = new System.Drawing.Point(663, 20);
            this.txtCodProf.Name = "txtCodProf";
            this.txtCodProf.Size = new System.Drawing.Size(139, 27);
            this.txtCodProf.TabIndex = 238;
            this.txtCodProf.Text = "PROF001";
            // 
            // lblCodProf
            // 
            this.lblCodProf.AutoSize = true;
            this.lblCodProf.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodProf.Location = new System.Drawing.Point(460, 18);
            this.lblCodProf.Name = "lblCodProf";
            this.lblCodProf.Size = new System.Drawing.Size(205, 25);
            this.lblCodProf.TabIndex = 237;
            this.lblCodProf.Text = "Cód. do Professor:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.Location = new System.Drawing.Point(26, 412);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(221, 35);
            this.btnAtualizar.TabIndex = 261;
            this.btnAtualizar.Text = "Atualizar Informações";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmManterTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(940, 673);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtCodIdioma);
            this.Controls.Add(this.lblCodIdioma);
            this.Controls.Add(this.txtCodProf);
            this.Controls.Add(this.lblCodProf);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.txtNumAlunos);
            this.Controls.Add(this.btnSalvaar);
            this.Controls.Add(this.lblNumAlunos);
            this.Controls.Add(this.picBusca);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterTurma";
            this.Load += new System.EventHandler(this.frmManterTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtNumAlunos;
        private System.Windows.Forms.Button btnSalvaar;
        private System.Windows.Forms.Label lblNumAlunos;
        private System.Windows.Forms.PictureBox picBusca;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.TextBox txtCodIdioma;
        private System.Windows.Forms.Label lblCodIdioma;
        private System.Windows.Forms.TextBox txtCodProf;
        private System.Windows.Forms.Label lblCodProf;
        private System.Windows.Forms.Button btnAtualizar;
    }
}