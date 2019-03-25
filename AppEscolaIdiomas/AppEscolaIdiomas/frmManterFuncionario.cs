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
    public partial class frmManterFuncionario : Form
    {
        string codUsuario;
        string idClicado;

        public frmManterFuncionario(string codUsuario2)
        {
            codUsuario = codUsuario2;
            InitializeComponent();
        }
        ClassFuncionario func = new ClassFuncionario();
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNomeAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            func.EmailDigitado = txtEmail.Text;
            if (func.ValidarEmail() == true)
            {
                txtEmail.ForeColor = Color.Tomato;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;

            }
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            func.CpfDigitado = mskCpf.Text;
            if (func.ValidarCpf() == true)
            {
                mskCpf.ForeColor = Color.Tomato;
            }
            else
            {
                mskCpf.ForeColor = Color.Black;

            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length <= 3)
            {
                txtNome.ForeColor = Color.Tomato;
            }
            else
            {
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length > 8)
            {
                txtSenha.ForeColor = Color.Tomato;
            }
            else
            {
                txtSenha.ForeColor = Color.Black;
            }
        }

        public bool Validar()
        {
            if (mskCpf.ForeColor == Color.Tomato)
            {
                MessageBox.Show("CPF inválido.");
                return false;
            }
            if (txtNome.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Nome inválido.");
                return false;
            }
            if (mskTelefone.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Telefone inválido.");
                return false;
            }
            if (txtEmail.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Email inválido.");
                return false;
            }

            if (txtSenha.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Senha inválida.");
                return false;
            }
            if (func.ValidarSenha(txtSenha.Text) == false)
            {
                MessageBox.Show("A senha deve conter letras e números.");
                return false;
            }
            return true;
        }

        private void btnSalvaar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string dataNasSemMascara = mskDataNas.Text.Replace("/", "");
            string cpfSemMascara = mskCpf.Text.Replace(".", "");


            if ((cpfSemMascara != "") && (txtNome.Text != "") && (txtEmail.Text != "") && (telefoneSemMascara != "") && (dataNasSemMascara != "") && (txtSenha.Text != ""))
            {
                if (Validar() == true)
                {

                    func.Nome = txtNome.Text;
                    func.Telefone = telefoneSemMascara;
                    func.Email = txtEmail.Text;
                    func.Senha = txtSenha.Text;
                    func.CodTipo = cboTipoFuncionario.SelectedIndex + 1;
                    func.Cpf = cpfSemMascara;
                    func.DataNas = Convert.ToDateTime(mskDataNas.Text).ToString("yyyy/MM/dd");
                    DataTable dt = func.RetFuncionarios();
                    string codigo = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codFunc"].ToString().Replace("FUNC", "") : "0";
                    codigo = "FUNC" + (int.Parse(codigo) + 1).ToString().PadLeft(3, '0');
                    func.CodFunc = codigo;

                    if (func.Inserir(codUsuario) == true)
                    {
                        MessageBox.Show("Registro concluido com sucesso.");
                        dgvFuncionario.DataSource = func.RetFuncionarios();
                    }
                    else
                    {
                        MessageBox.Show("Registro não concluido.Tente novamente.");
                    }
                   


                }
                else
                {
                    MessageBox.Show("Registro não concluido.");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados.");
            }
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = func.RetFuncionarioCod(txtBusca.Text);
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.ForeColor = Color.Black;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = func.RetFuncionarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string dataNasSemMascara = mskDataNas.Text.Replace("/", "");
            string cpfSemMascara = mskCpf.Text.Replace(".", "");

            if (txtBusca.Text != "")
            {
                if ((cpfSemMascara != "") && (txtNome.Text != "") && (txtEmail.Text != "") && (telefoneSemMascara != "") && (dataNasSemMascara != "") && (txtSenha.Text != ""))
                {

                    func.Nome = txtNome.Text;
                    func.Telefone = telefoneSemMascara;
                    func.Email = txtEmail.Text;
                    func.Senha = txtSenha.Text;
                    func.CodTipo = cboTipoFuncionario.SelectedIndex + 1;
                    func.DataNas = Convert.ToDateTime(mskDataNas.Text).ToString("yyyy/MM/dd");

                    if (func.Editar(idClicado) == true)
                    {
                        MessageBox.Show("Edição concluida com sucesso.");
                        dgvFuncionario.DataSource = func.RetFuncionarios();
                    }
                    else
                    {
                        MessageBox.Show("Edição não concluída tente novamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os dados.");
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo de busca .");
            }
        }
    }
}

