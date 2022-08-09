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
    public partial class PrincipalAgente : Form
    {
        public PrincipalAgente()
        {
            InitializeComponent();
        }



        private void EventoCadastroAluno_Click(object sender, EventArgs e)
        {
            using (FormCadastroAluno frn = new FormCadastroAluno())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (CadastroProfessor frn = new CadastroProfessor())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }
    }
}
