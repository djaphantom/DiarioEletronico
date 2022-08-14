using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class PrincipalAluno : Form
    {
        public PrincipalAluno()
        {
            InitializeComponent();
        }

        private void bletinDoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNota_Click(object sender, EventArgs e)
        {

        }

        private void VoltarLongin_Click(object sender, EventArgs e)
        {
            using (FormLogin frn = new FormLogin())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }

        private void buttonFrequencia_Click(object sender, EventArgs e)
        {

        }
    }
}
