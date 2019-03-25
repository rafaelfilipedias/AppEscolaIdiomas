namespace AppEscolaIdiomas
{
    partial class frmExcluirIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcluirIdioma));
            this.lblForm = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.picBusca = new System.Windows.Forms.PictureBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvIdioma = new System.Windows.Forms.DataGridView();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lbLCod = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblForm.Location = new System.Drawing.Point(301, 9);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(332, 33);
            this.lblForm.TabIndex = 273;
            this.lblForm.Text = "Formulário de Exclusão";
            this.lblForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(288, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(373, 23);
            this.lblTitulo.TabIndex = 272;
            this.lblTitulo.Text = "Insira o código do idioma para excluir";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(875, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(29, 28);
            this.btnSair.TabIndex = 271;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picBusca
            // 
            this.picBusca.Image = ((System.Drawing.Image)(resources.GetObject("picBusca.Image")));
            this.picBusca.Location = new System.Drawing.Point(634, 172);
            this.picBusca.Name = "picBusca";
            this.picBusca.Size = new System.Drawing.Size(33, 28);
            this.picBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBusca.TabIndex = 270;
            this.picBusca.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBusca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusca.Location = new System.Drawing.Point(673, 172);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(221, 27);
            this.txtBusca.TabIndex = 269;
            this.txtBusca.Text = "Busque pelo código ou nome";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            // 
            // dgvIdioma
            // 
            this.dgvIdioma.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdioma.Location = new System.Drawing.Point(4, 205);
            this.dgvIdioma.Name = "dgvIdioma";
            this.dgvIdioma.Size = new System.Drawing.Size(890, 348);
            this.dgvIdioma.TabIndex = 268;
            this.dgvIdioma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdioma_CellContentClick);
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCod.Location = new System.Drawing.Point(182, 127);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(137, 27);
            this.txtCod.TabIndex = 267;
            // 
            // lbLCod
            // 
            this.lbLCod.AutoSize = true;
            this.lbLCod.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLCod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbLCod.Location = new System.Drawing.Point(4, 127);
            this.lbLCod.Name = "lbLCod";
            this.lbLCod.Size = new System.Drawing.Size(172, 25);
            this.lbLCod.TabIndex = 274;
            this.lbLCod.Text = "Cód. do Idioma";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(30, 571);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 40);
            this.btnExcluir.TabIndex = 275;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmExcluirIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(906, 673);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lbLCod);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.picBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvIdioma);
            this.Controls.Add(this.txtCod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExcluirIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExcluirIdioma";
            this.Load += new System.EventHandler(this.frmExcluirIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdioma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvIdioma;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lbLCod;
        private System.Windows.Forms.Button btnExcluir;
    }
}