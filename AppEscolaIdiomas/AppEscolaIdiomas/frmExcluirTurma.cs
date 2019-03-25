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
    public partial class frmExcluirTurma : Form
    {
        string idClicado;
        public frmExcluirTurma()
        {
            InitializeComponent();
        }
        ClassTurma turma = new ClassTurma();

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmExcluirTurma_Load(object sender, EventArgs e)
        {
            dgvTurma.DataSource = turma.RetTurma();
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

        private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTurma.Rows[e.RowIndex].Cells["codTurma"].Value.ToString() != "")
            {
                idClicado = (dgvTurma.Rows[e.RowIndex].Cells["codTurma"].Value.ToString());
            }
            txtCod.Text = dgvTurma.Rows[e.RowIndex].Cells["codTurma"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir essa turma?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (turma.Excluir(idClicado) == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso.");
                    dgvTurma.DataSource = turma.RetTurma();
                }
                else
                {
                    MessageBox.Show("Exclusão não concluída. Tente novamente.");
                }
            }
        }
    }
}
