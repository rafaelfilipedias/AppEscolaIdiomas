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
    public partial class frmExcluirIdioma : Form
    {
        string idClicado;
        public frmExcluirIdioma()
        {
            InitializeComponent();
        }
        ClassIdioma idioma = new ClassIdioma();

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

        private void frmExcluirIdioma_Load(object sender, EventArgs e)
        {
            dgvIdioma.DataSource = idioma.RetIdioma();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse idioma?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (idioma.Excluir(idClicado) == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso.");
                    dgvIdioma.DataSource = idioma.RetIdioma();
                }
                else
                {
                    MessageBox.Show("Exclusão não concluída. Tente novamente.");
                }
            }
        }

        private void dgvIdioma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIdioma.Rows[e.RowIndex].Cells["codIdioma"].Value.ToString() != "")
            {
                idClicado = (dgvIdioma.Rows[e.RowIndex].Cells["codIdioma"].Value.ToString());
            }
            txtCod.Text = dgvIdioma.Rows[e.RowIndex].Cells["codIdioma"].Value.ToString();
        }
    }
}
