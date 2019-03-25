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
    public partial class frmExcluirProfessor : Form
    {
        string idClicado;
        public frmExcluirProfessor()
        {
            InitializeComponent();
        }
        ClassProfessor prof = new ClassProfessor();
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvProf.DataSource = prof.RetProfBusca(txtBusca.Text);

        }


        private void frmExcluirProfessor_Load(object sender, EventArgs e)
        {
            dgvProf.DataSource = prof.RetProfessores();
        }

        private void dgvProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProf.Rows[e.RowIndex].Cells["codProf"].Value.ToString() != "")
            {
                idClicado = (dgvProf.Rows[e.RowIndex].Cells["codProf"].Value.ToString());
            }
            txtCod.Text = dgvProf.Rows[e.RowIndex].Cells["codProf"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "") {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse professor?", "Confirmação", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (prof.Excluir(idClicado) == true)
                    {
                        MessageBox.Show("Exclusão concluida com sucesso.");
                        dgvProf.DataSource = prof.RetProfessores();
                    }
                    else
                    {
                        MessageBox.Show("Exclusão não concluída. Tente novamente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Clique no código do professor que será excluido.");
            }
            
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }
    }
}
