namespace AppEscolaIdiomas
{
    partial class frmEnviarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviarSenha));
            this.pnlCenterPet = new System.Windows.Forms.Panel();
            this.lblMenu1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlCenterPet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenterPet
            // 
            this.pnlCenterPet.BackColor = System.Drawing.Color.Gold;
            this.pnlCenterPet.Controls.Add(this.lblMenu1);
            this.pnlCenterPet.Controls.Add(this.btnSair);
            this.pnlCenterPet.Controls.Add(this.button3);
            this.pnlCenterPet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCenterPet.Location = new System.Drawing.Point(0, 0);
            this.pnlCenterPet.Name = "pnlCenterPet";
            this.pnlCenterPet.Size = new System.Drawing.Size(800, 140);
            this.pnlCenterPet.TabIndex = 15;
            // 
            // lblMenu1
            // 
            this.lblMenu1.AutoSize = true;
            this.lblMenu1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenu1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMenu1.Location = new System.Drawing.Point(226, 54);
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
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(142, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(552, 25);
            this.txtEmail.TabIndex = 19;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(3, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 41);
            this.btnSair.TabIndex = 18;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnviar.Location = new System.Drawing.Point(277, 388);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(280, 37);
            this.btnEnviar.TabIndex = 17;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLogin.Location = new System.Drawing.Point(80, 196);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(654, 35);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "Insira um email para recuperar a sua senha";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEnviarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlCenterPet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEnviarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnviarSenha";
            this.pnlCenterPet.ResumeLayout(false);
            this.pnlCenterPet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCenterPet;
        private System.Windows.Forms.Label lblMenu1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblLogin;
    }
}