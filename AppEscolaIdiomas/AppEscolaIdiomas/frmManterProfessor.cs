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
    public partial class frmManterProfessor : Form
    {
        string idClicado;
        public frmManterProfessor()
        {
            InitializeComponent();
        }
        ClassProfessor prof = new ClassProfessor();
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

        private void frmManterProfessor_Load(object sender, EventArgs e)
        {
            dgvProfessor.DataSource = prof.RetProfessores();
        }

        private void dgvProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfessor.Rows[e.RowIndex].Cells["codProf"].Value.ToString() != "")
            {
                idClicado = (dgvProfessor.Rows[e.RowIndex].Cells["codProf"].Value.ToString());
            }

            txtNome.Text = dgvProfessor.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dgvProfessor.Rows[e.RowIndex].Cells["email"].Value.ToString();
            mskCpf.Text = dgvProfessor.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            mskDataNas.Text = dgvProfessor.Rows[e.RowIndex].Cells["dataNas"].Value.ToString();
            mskTelefone.Text = dgvProfessor.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            prof.CpfDigitado = mskCpf.Text;
            if (prof.ValidarCpf() == true)
            {
                mskCpf.ForeColor = Color.Tomato;
            }
            else
            {
                mskCpf.ForeColor = Color.Black;

            }
        }

        public bool Validar()
        {
            if (mskCpf.ForeColor == Color.Tomato)
            {
                MessageBox.Show("CPF inválido.");
                return false;
            }
            return true;
        }
        private void btnSalvaar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string dataNasSemMascara = mskDataNas.Text.Replace("/", "");
            string cpfSemMascara = mskCpf.Text.Replace(".", "");

            if ((cpfSemMascara != "") && (txtNome.Text != "") && (txtEmail.Text != "") && (telefoneSemMascara != "") && (dataNasSemMascara != "") )
            {
                if (Validar() == true)
                {

                    prof.Nome = txtNome.Text;
                    prof.Telefone = telefoneSemMascara;
                    prof.Email = txtEmail.Text;
                    prof.DataNas = Convert.ToDateTime(mskDataNas.Text).ToString("yyyy/MM/dd");
                    prof.Cpf = cpfSemMascara;
                    DataTable dt = prof.RetProfessores();
                    string codigo = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codProf"].ToString().Replace("PROF", "") : "0";
                    codigo = "PROF" + (int.Parse(codigo) + 1).ToString().PadLeft(3, '0');
                    prof.CodProf = codigo;

                    if (prof.Inserir() == true)
                    {
                        MessageBox.Show("Registro concluido com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Registro não concluido.Tente novamente.");
                    }
                    dgvProfessor.DataSource = prof.RetProfessores();


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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvProfessor.DataSource = prof.RetProfBusca(txtBusca.Text);
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string dataNasSemMascara = mskDataNas.Text.Replace("/", "");
            string cpfSemMascara = mskCpf.Text.Replace(".", "");

            if (txtBusca.Text != "")
            {
                if ((cpfSemMascara != "") && (txtNome.Text != "") && (txtEmail.Text != "") && (telefoneSemMascara != "") && (dataNasSemMascara != ""))
                {

                    prof.Nome = txtNome.Text;
                    prof.Telefone = telefoneSemMascara;
                    prof.Email = txtEmail.Text;
                    prof.DataNas = Convert.ToDateTime(mskDataNas.Text).ToString("yyyy/MM/dd");
                    prof.Cpf = cpfSemMascara;

                    if (prof.Editar(idClicado) == true)
                    {
                        MessageBox.Show("Edição concluida com sucesso.");
                        dgvProfessor.DataSource = prof.RetProfessores();
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvProfessor.DataSource = prof.RetProfessores();
        }
    }
}
