using BLL;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class PrincipalAluno : Form
    {
        public PrincipalAluno()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            using (FormLogin frn = new FormLogin())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BoletimBLL boletimBLL = new BoletimBLL();
            boletimBindingSource.DataSource = boletimBLL.Buscar(textBoxBuscar.Text);
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
