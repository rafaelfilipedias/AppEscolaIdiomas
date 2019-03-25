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
    public partial class frmManterTurma : Form
    {
        string idClicado;
        public frmManterTurma()
        {
            InitializeComponent();
        }

        ClassTurma turma = new ClassTurma();

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtNumAlunos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMateria_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmManterTurma_Load(object sender, EventArgs e)
        {
            dgvTurma.DataSource = turma.RetTurma();
        }

        private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTurma.Rows[e.RowIndex].Cells["codIdioma"].Value.ToString() != "")
            {
                idClicado = (dgvTurma.Rows[e.RowIndex].Cells["codTurma"].Value.ToString());
            }

            txtNome.Text = dgvTurma.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtDescricao.Text = dgvTurma.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            txtNumAlunos.Text = dgvTurma.Rows[e.RowIndex].Cells["numAlunos"].Value.ToString();
            txtMateria.Text = dgvTurma.Rows[e.RowIndex].Cells["materia"].Value.ToString();
            txtCodProf.Text = dgvTurma.Rows[e.RowIndex].Cells["Professor_codProf"].Value.ToString();
            txtCodIdioma.Text = dgvTurma.Rows[e.RowIndex].Cells["Idioma_codIdioma"].Value.ToString();
        }

        private void btnSalvaar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtDescricao.Text != "")&& (txtNumAlunos.Text != "") && (txtMateria.Text != "") && (txtCodProf.Text != "") && (txtCodIdioma.Text != "") )
            {

                if (Validar() == true)
                {
                    turma.Nome = txtNome.Text;
                    turma.Descricao = txtDescricao.Text;
                    turma.NumAlunos = int.Parse(txtNumAlunos.Text);
                    turma.Materia = txtMateria.Text;
                    turma.Professor_codProf = txtCodProf.Text;
                    turma.Idioma_codIdioma = txtCodIdioma.Text;

                    DataTable dt = turma.RetTurma();

                    string codigo = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codTurma"].ToString().Replace("TURM", "") : "0";
                    codigo = "TURM" + (int.Parse(codigo) + 1).ToString().PadLeft(3, '0');
                    turma.CodTurma = codigo;
                    if (turma.Inserir() == true)
                    {
                        MessageBox.Show("Registro concluido com sucesso.");
                        dgvTurma.DataSource = turma.RetTurma();
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

        private void txtNome_Leave(object sender, EventArgs e)
        {
            turma.NomeDigitado = txtNome.Text;
            if (turma.ValidarNome() == true)
            {
                txtNome.ForeColor = Color.Red;
            }
            else
            {
                txtNome.ForeColor = Color.Black;
            }
        }

        public bool Validar()
        {
            if (txtNome.ForeColor == Color.Red)
            {
                MessageBox.Show("Nome inválido.");
                return false;
            }
            if (txtCodIdioma.ForeColor == Color.Red)
            {
                MessageBox.Show("Código de idioma inválido.");
                return false;
            }

            return true;
        }

        private void txtCodIdioma_Leave(object sender, EventArgs e)
        {
            turma.CodIdiomaDigitado = txtCodIdioma.Text;
            if (turma.ValidarCodIdioma() == true)
            {
                txtCodIdioma.ForeColor = Color.Black;
            }
            else
            {
                txtCodIdioma.ForeColor = Color.Red;
            }
        }
    }
}
