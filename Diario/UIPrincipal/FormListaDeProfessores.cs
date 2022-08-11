using BLL;
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
    public partial class FormListaDeProfessores : Form
    {
        public FormListaDeProfessores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfessorBLL professorBLL = new ProfessorBLL();
            professorBindingSource.DataSource = professorBLL.Buscar(textBox1.Text);
        }

        private void btn_novo_cadastro_Click(object sender, EventArgs e)
        {
            using (CadastroProfessor frn = new CadastroProfessor())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();

            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            ProfessorBLL professorBLL = new ProfessorBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)professorBindingSource.Current).Row["Id"]);
            professorBLL.Excuir(id);
            professorBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void btn_retornar_Click(object sender, EventArgs e)
        {
            using (PrincipalAgente frn = new PrincipalAgente())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();

            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
           /* using (CadastroProfessor frm = new CadastroProfessor(professorBindingSource.Current))
            {
                frm.ShowDialog();
            }*/
        }
    }
}
