namespace AppEscolaIdiomas
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlCenterPet = new System.Windows.Forms.Panel();
            this.lblMenu1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEsqueceuSenha = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            this.pnlCenterPet.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogin
            // 
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picLogin.Location = new System.Drawing.Point(193, 249);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(54, 47);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogin.TabIndex = 13;
            this.picLogin.TabStop = false;
            // 
            // picSenha
            // 
            this.picSenha.Image = ((System.Drawing.Image)(resources.GetObject("picSenha.Image")));
            this.picSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSenha.Location = new System.Drawing.Point(193, 302);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(54, 47);
            this.picSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSenha.TabIndex = 12;
            this.picSenha.TabStop = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenha.Location = new System.Drawing.Point(253, 302);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(127, 39);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLogin.Location = new System.Drawing.Point(255, 249);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(119, 39);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Email:";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCenterPet
            // 
            this.pnlCenterPet.BackColor = System.Drawing.Color.Gold;
            this.pnlCenterPet.Controls.Add(this.lblMenu1);
            this.pnlCenterPet.Controls.Add(this.button3);
            this.pnlCenterPet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCenterPet.Location = new System.Drawing.Point(0, 0);
            this.pnlCenterPet.Name = "pnlCenterPet";
            this.pnlCenterPet.Size = new System.Drawing.Size(872, 140);
            this.pnlCenterPet.TabIndex = 14;
            // 
            // lblMenu1
            // 
            this.lblMenu1.AutoSize = true;
            this.lblMenu1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenu1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMenu1.Location = new System.Drawing.Point(254, 53);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(356, 45);
            this.lblMenu1.TabIndex = 5;
            this.lblMenu1.Text = "Escola de Idiomas";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(3, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(384, 262);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(356, 26);
            this.txtLogin.TabIndex = 15;
            this.txtLogin.Text = "annaclarasilva767@gmail.com";
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(384, 314);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(255, 26);
            this.txtSenha.TabIndex = 16;
            this.txtSenha.Text = "anna1234";
            // 
            // btnEsqueceuSenha
            // 
            this.btnEsqueceuSenha.FlatAppearance.BorderSize = 0;
            this.btnEsqueceuSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqueceuSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueceuSenha.ForeColor = System.Drawing.Color.White;
            this.btnEsqueceuSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEsqueceuSenha.Location = new System.Drawing.Point(297, 515);
            this.btnEsqueceuSenha.Name = "btnEsqueceuSenha";
            this.btnEsqueceuSenha.Size = new System.Drawing.Size(294, 31);
            this.btnEsqueceuSenha.TabIndex = 19;
            this.btnEsqueceuSenha.Text = "Esqueceu sua senha ? Clique aqui!";
            this.btnEsqueceuSenha.UseVisualStyleBackColor = true;
            this.btnEsqueceuSenha.Click += new System.EventHandler(this.btnEsqueceuSenha_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(492, 421);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(147, 55);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEntrar.Location = new System.Drawing.Point(252, 421);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(139, 55);
            this.btnEntrar.TabIndex = 17;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(872, 550);
            this.Controls.Add(this.btnEsqueceuSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.pnlCenterPet);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.picSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            this.pnlCenterPet.ResumeLayout(false);
            this.pnlCenterPet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlCenterPet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMenu1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEsqueceuSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
    }
}

