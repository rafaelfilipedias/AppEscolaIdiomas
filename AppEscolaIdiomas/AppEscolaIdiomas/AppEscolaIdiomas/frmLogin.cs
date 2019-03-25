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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        ClassFuncionario func = new ClassFuncionario();
        private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            frmEnviarSenha enviarSenha = new frmEnviarSenha();
            enviarSenha.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            func.Email = txtLogin.Text;
            func.Senha = txtSenha.Text;

            DataTable dt = func.RealizarLogin();

            // saber se foram retornados registros do select
            if (dt.Rows.Count > 0)
            {
                //Como usar os dados desta tabela
                string loginFunc = dt.Rows[0]["email"].ToString();
                string codUsuario = dt.Rows[0]["codFunc"].ToString();
                int codTipoFunc = int.Parse(dt.Rows[0]["codTipo"].ToString());

                if (codTipoFunc == 1)
                {
                    //fmrMenuAdm menu = new fmrMenuAdm(codUsuario);
                    //menu.Show();
                }
                else if (codTipoFunc == 2)
                {
                    
                    frmFuncionario func = new frmFuncionario(codUsuario);
                    this.Hide();
                    func.Show();
                }
            }
            else
            {
                MessageBox.Show("Login e senha errados");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

