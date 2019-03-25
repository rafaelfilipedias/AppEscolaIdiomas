namespace AppEscolaIdiomas
{
    partial class frmManterProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterProfessor));
            this.btnSair = new System.Windows.Forms.Button();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mskDataNas = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNas = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSalvaar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.picBusca = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvProfessor = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).BeginInit();
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
            this.btnSair.Location = new System.Drawing.Point(911, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(29, 28);
            this.btnSair.TabIndex = 237;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.mskTelefone.Location = new System.Drawing.Point(119, 182);
            this.mskTelefone.Mask = "(99) 9 9999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(138, 27);
            this.mskTelefone.TabIndex = 234;
            this.mskTelefone.Text = "31992635468";
            this.mskTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTelefone_KeyPress);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefone.Location = new System.Drawing.Point(4, 184);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(109, 25);
            this.lblTelefone.TabIndex = 233;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(74, 134);
            this.mskCpf.Mask = "999\\.999\\.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(122, 27);
            this.mskCpf.TabIndex = 232;
            this.mskCpf.Text = "13232653259";
            this.mskCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCpf_KeyPress);
            this.mskCpf.Leave += new System.EventHandler(this.mskCpf_Leave);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCpf.Location = new System.Drawing.Point(4, 135);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(60, 25);
            this.lblCpf.TabIndex = 231;
            this.lblCpf.Text = "CPF:";
            // 
            // mskDataNas
            // 
            this.mskDataNas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataNas.Location = new System.Drawing.Point(241, 96);
            this.mskDataNas.Mask = "99/99/9999";
            this.mskDataNas.Name = "mskDataNas";
            this.mskDataNas.Size = new System.Drawing.Size(96, 27);
            this.mskDataNas.TabIndex = 230;
            this.mskDataNas.Text = "10082001";
            this.mskDataNas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskDataNas_KeyPress);
            // 
            // lblDataNas
            // 
            this.lblDataNas.AutoSize = true;
            this.lblDataNas.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataNas.Location = new System.Drawing.Point(4, 96);
            this.lblDataNas.Name = "lblDataNas";
            this.lblDataNas.Size = new System.Drawing.Size(232, 25);
            this.lblDataNas.TabIndex = 229;
            this.lblDataNas.Text = "Data de Nascimento:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEmail.Location = new System.Drawing.Point(95, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 27);
            this.txtEmail.TabIndex = 228;
            this.txtEmail.Text = "weberlucas@gmail.com";
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
            this.btnSalvaar.Location = new System.Drawing.Point(709, 527);
            this.btnSalvaar.Name = "btnSalvaar";
            this.btnSalvaar.Size = new System.Drawing.Size(200, 40);
            this.btnSalvaar.TabIndex = 227;
            this.btnSalvaar.Text = "Salvar";
            this.btnSalvaar.UseVisualStyleBackColor = false;
            this.btnSalvaar.Click += new System.EventHandler(this.btnSalvaar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(4, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 25);
            this.lblEmail.TabIndex = 226;
            this.lblEmail.Text = "E-mail:";
            // 
            // picBusca
            // 
            this.picBusca.Image = ((System.Drawing.Image)(resources.GetObject("picBusca.Image")));
            this.picBusca.Location = new System.Drawing.Point(578, 186);
            this.picBusca.Name = "picBusca";
            this.picBusca.Size = new System.Drawing.Size(33, 28);
            this.picBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBusca.TabIndex = 225;
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
            this.btnEditar.Location = new System.Drawing.Point(709, 590);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 40);
            this.btnEditar.TabIndex = 221;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBusca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusca.Location = new System.Drawing.Point(617, 186);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(179, 27);
            this.txtBusca.TabIndex = 224;
            this.txtBusca.Text = "Busque pelo código";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            // 
            // dgvProfessor
            // 
            this.dgvProfessor.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessor.Location = new System.Drawing.Point(9, 235);
            this.dgvProfessor.Name = "dgvProfessor";
            this.dgvProfessor.Size = new System.Drawing.Size(900, 256);
            this.dgvProfessor.TabIndex = 223;
            this.dgvProfessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessor_CellContentClick);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNome.Location = new System.Drawing.Point(90, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(363, 27);
            this.txtNome.TabIndex = 220;
            this.txtNome.Text = "Weber Lucas";
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAluno_KeyPress);
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeAluno.Location = new System.Drawing.Point(4, 13);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(81, 25);
            this.lblNomeAluno.TabIndex = 222;
            this.lblNomeAluno.Text = "Nome:";
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
            this.btnAtualizar.Location = new System.Drawing.Point(30, 511);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(227, 30);
            this.btnAtualizar.TabIndex = 261;
            this.btnAtualizar.Text = "Atualizar Informações";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmManterProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(940, 673);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.mskDataNas);
            this.Controls.Add(this.lblDataNas);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSalvaar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.picBusca);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvProfessor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterProfessor";
            this.Load += new System.EventHandler(this.frmManterProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mskDataNas;
        private System.Windows.Forms.Label lblDataNas;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSalvaar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picBusca;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvProfessor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Button btnAtualizar;
    }
}