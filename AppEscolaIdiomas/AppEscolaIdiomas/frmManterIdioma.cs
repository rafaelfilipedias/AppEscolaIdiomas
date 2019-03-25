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
    public partial class frmManterIdioma : Form
    {
        string idClicado;
        public frmManterIdioma()
        {
            InitializeComponent();
        }
        ClassIdioma idioma = new ClassIdioma();

        private void frmManterIdioma_Load(object sender, EventArgs e)
        {
            dgvIdioma.DataSource = idioma.RetIdioma();
        }

        private void dgvIdioma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIdioma.Rows[e.RowIndex].Cells["codIdioma"].Value.ToString() != "")
            {
                idClicado = (dgvIdioma.Rows[e.RowIndex].Cells["codIdioma"].Value.ToString());
            }

            txtNome.Text = dgvIdioma.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtDescricao.Text = dgvIdioma.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtDescricao.Text != ""))
            {
                idioma.Nome = txtNome.Text;
                idioma.Descricao = txtDescricao.Text;

                DataTable dt = idioma.RetIdioma();

                string codigo = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codIdioma"].ToString().Replace("IDI", "") : "0";
                codigo = "IDI" + (int.Parse(codigo) + 1).ToString().PadLeft(3, '0');
                idioma.CodIdioma = codigo;
                if (idioma.Inserir() == true)
                {
                    MessageBox.Show("Registro concluido com sucesso.");
                    dgvIdioma.DataSource = idioma.RetIdioma();
                }
                else
                {
                    MessageBox.Show("Registro não concluido.");
                }
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvIdioma.DataSource = idioma.RetIdiomaBusca(txtBusca.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvIdioma.DataSource = idioma.RetIdioma();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            idioma.Nome = txtNome.Text;
            idioma.Descricao = txtDescricao.Text;

            if (txtBusca.Text != "")
            {
                if ((txtNome.Text != "") && (txtDescricao.Text != ""))
                {
                    idioma.Nome = txtNome.Text;
                    idioma.Descricao = txtDescricao.Text;

                    if (idioma.Editar(idClicado) == true)
                    {
                        MessageBox.Show("Edição concluida com sucesso.");
                        dgvIdioma.DataSource = idioma.RetIdioma();
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
