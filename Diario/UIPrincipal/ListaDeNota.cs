using BLL;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class ListaDeNota : Form
    {
        public ListaDeNota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NotaBLL notaBLL = new NotaBLL();
            notaBindingSource.DataSource = notaBLL.Buscar(textBoxBuscarNota.Text);
        }

        private void button_Click(object sender, EventArgs e)
        {
            using (PrincipalAluno frn = new PrincipalAluno())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
            }
        }
    }
}