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
            this.Hide();
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
            if (dgvTurma.Rows[e.RowIndex].Cells["codTurma"].Value.ToString() != "")
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
            if ((txtNome.Text != "") && (txtDescricao.Text != "") && (txtNumAlunos.Text != "") && (txtMateria.Text != "") && (txtCodProf.Text != "") && (txtCodIdioma.Text != ""))
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
                MessageBox.Show("Preencha todos os dados.");
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvTurma.DataSource = turma.RetTurmaBusca(txtBusca.Text);
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                if ((txtNome.Text != "") && (txtDescricao.Text != "") && (txtNumAlunos.Text != "") && (txtMateria.Text != "") && (txtCodProf.Text != "") && (txtCodIdioma.Text != ""))
                {

                    turma.Nome = txtNome.Text;
                    turma.Descricao = txtDescricao.Text;
                    turma.NumAlunos = int.Parse(txtNumAlunos.Text);
                    turma.Materia = txtMateria.Text;
                    turma.Professor_codProf = txtCodProf.Text;
                    turma.Idioma_codIdioma = txtCodIdioma.Text;

                    if (turma.Editar(idClicado) == true)
                    {
                        MessageBox.Show("Edição concluida com sucesso.");
                        dgvTurma.DataSource = turma.RetTurma();
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
            dgvTurma.DataSource = turma.RetTurma();
;        }
    }
}
