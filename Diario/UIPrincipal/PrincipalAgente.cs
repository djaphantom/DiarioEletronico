using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class PrincipalAgente : Form
    {
        public PrincipalAgente()
        {
            InitializeComponent();
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

        private void CadastroTurma_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_lista_professores_Click(object sender, EventArgs e)
        {
            using (FormListaDeProfessores frn = new FormListaDeProfessores())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }

        private void btn_lista_professores_Click_1(object sender, EventArgs e)
        {
            using (FormListaDeProfessores frn = new FormListaDeProfessores())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (FormAgentePedagogico frn = new FormAgentePedagogico())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
