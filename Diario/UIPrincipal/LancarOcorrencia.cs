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
    public partial class LancarOcorrencia : Form
    {
        public LancarOcorrencia()
        {
            InitializeComponent();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LancarOcorrencia_Load(object sender, EventArgs e)
        {

        }

        private void btn_lancaOcorrencia_Click(object sender, EventArgs e)
        {

        }

        private void buttonSAIR_Click(object sender, EventArgs e)
        {
            using(PrincipalProfessor  frn = new PrincipalProfessor())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }
    }
}
