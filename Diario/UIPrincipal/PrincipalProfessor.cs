
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class PrincipalProfessor : Form
    {
        public PrincipalProfessor()
        {
            InitializeComponent();
        }

        private void lançarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLancarNota_Click(object sender, EventArgs e)
        {
            using (CadastroDeNota frn = new CadastroDeNota())
            {
                this.Visible = !this.Visible;
                 frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }

<<<<<<< HEAD
        private void buttonPlanoDeAula_Click(object sender, EventArgs e)
=======
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

        private void button1_Click(object sender, EventArgs e)
>>>>>>> 1a84d73bf1f969540e6bce5a2f5d8393ea7739de
        {
            using (FormPlanoDeAula frn = new FormPlanoDeAula())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
<<<<<<< HEAD

=======
>>>>>>> 1a84d73bf1f969540e6bce5a2f5d8393ea7739de
            }
        }
    }
}
