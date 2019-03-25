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
    public partial class frmEnviarSenha : Form
    {
        public frmEnviarSenha()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ClassFuncionario func = new ClassFuncionario();
            func.EsqueceuSenha(txtEmail.Text);
            if (func.EsqueceuSenha(txtEmail.Text) == false)
            {
                MessageBox.Show("Email não encontrado. Tente novamente.");
            }
            else
            {
                MessageBox.Show("Email enviado com sucesso.");
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }
    }
}
