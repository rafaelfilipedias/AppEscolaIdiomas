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
    public partial class frmManterAluno : Form
    {
        string idClicado;
        private string codUsuario;
        public frmManterAluno(string codUsuario2)
        {
            codUsuario = codUsuario2;
            InitializeComponent();
        }
        ClassAluno aluno = new ClassAluno();
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

        private void mskDataNas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void mskCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void mskTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmManterAluno_Load(object sender, EventArgs e)
        {
            dgvAluno.DataSource = aluno.RetAluno();
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString() != "")
            {
                idClicado = (dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString());
            }

            txtNomeAluno.Text = dgvAluno.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dgvAluno.Rows[e.RowIndex].Cells["email"].Value.ToString();
            mskDataNas.Text = dgvAluno.Rows[e.RowIndex].Cells["dataNas"].Value.ToString();
            mskCpf.Text = dgvAluno.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            mskTelefone.Text = dgvAluno.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtMatricula.Text = dgvAluno.Rows[e.RowIndex].Cells["Matricula_codMatricula"].Value.ToString();
        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskCpf.Text.Length < 11)
            {
                mskCpf.ForeColor = Color.Red;
            }
            else
            {
                mskCpf.ForeColor = Color.Black;
            }
        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskTelefone.Text.Length < 11)
            {
                mskTelefone.ForeColor = Color.Red;
            }
            else
            {
                mskTelefone.ForeColor = Color.Black;
            }
        }

        private void txtNomeAluno_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text.Length <= 3)
            {
                txtNomeAluno.ForeColor = Color.Red;
            }
            else
            {
                txtNomeAluno.ForeColor = Color.Black;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            aluno.EmailDigitado = txtEmail.Text;
            if (aluno
.ValidarEmail() == true)
            {
                txtEmail.ForeColor = Color.Red;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;

            }
        }

        public bool Validar()
        {
            if (mskCpf.ForeColor == Color.Red)
            {
                MessageBox.Show("CPF inválido.");
                return false;
            }
            if (txtNomeAluno.ForeColor == Color.Red)
            {
                MessageBox.Show("Nome inválido.");
                return false;
            }
            if (mskTelefone.ForeColor == Color.Red)
            {
                MessageBox.Show("Telefone inválido.");
                return false;
            }
            if (txtEmail.ForeColor == Color.Red)
            {
                MessageBox.Show("Email inválido.");
                return false;
            }
            return true;
        }

        private void btnSalvaar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "");
            string cpfSemMascara = mskCpf.Text.Replace(".", "");

            if ((mskCpf.Text != "") && (txtNomeAluno.Text != "") && (txtEmail.Text != "") && (mskDataNas.Text != "") && (txtMatricula.Text != "") && (mskTelefone.Text != ""))
            {

                if (Validar() == true)
                {

                    aluno.Nome = txtNomeAluno.Text;
                    aluno.Telefone = telefoneSemMascara;
                    aluno.Cpf = mskCpf.Text;
                    aluno.Email = txtEmail.Text;
                    aluno.DataNas = Convert.ToDateTime(mskDataNas.Text).ToString("yyyy/MM/dd");
                    aluno.Matricula_codMatricula = txtMatricula.Text;
              

                    DataTable dt = aluno.RetAluno();

                    string codigo = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codAluno"].ToString().Replace("ALUN", "") : "0";
                    codigo = "ALUN" + (int.Parse(codigo) + 1).ToString().PadLeft(3, '0');
                    aluno.CodAluno = codigo;
                    if (aluno.Inserir(codUsuario) == true)
                    {
                        MessageBox.Show("Registro concluido com sucesso.");
                        dgvAluno.DataSource = aluno.RetAluno();
                    }
                    else
                    {
                        MessageBox.Show("Registro não concluido.");
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
    }
}
