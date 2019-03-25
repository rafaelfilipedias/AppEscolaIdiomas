using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscolaIdiomas
{
    public partial class frmFuncionario : Form
    {
        private string codUsuario;
        public frmFuncionario(string codUsuario2)
        {
            codUsuario = codUsuario2;
            InitializeComponent();
        }

        private void AbrirFormPanel(object FormFilho)
        {
            if (this.pnlMostrar.Controls.Count > 0)
                this.pnlMostrar.Controls.RemoveAt(0);
            Form fh = FormFilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlMostrar.Controls.Add(fh);
            this.pnlMostrar.Tag = fh;
            fh.Show();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmManterIdioma());
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmManterTurma());
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmManterProfessor(codUsuario));
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmManterAluno(codUsuario));
        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }

    
}
