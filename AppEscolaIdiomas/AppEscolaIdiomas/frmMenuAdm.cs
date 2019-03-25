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
    public partial class frmMenuAdm : Form
    {
        private string codUsuario;
        public frmMenuAdm(string codUsuario2)
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
        private void pnlMostrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirIdioma());

        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmManterFuncionario(codUsuario));
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirProfessor());
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirAluno());
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirTurma());
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExcluirFuncionario());
        }
    }
}
