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
    public partial class Disciplina : Form
    {
        public Disciplina()
        {
            InitializeComponent();
        }

        private void Disciplina_Load(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            using (PrincipalAgente frn = new PrincipalAgente())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            DisciplinaBLL disciplinaBLL = new DisciplinaBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)disciplinaBindingSource.Current).Row["Id"]);
            disciplinaBLL.Excluir(id);
            disciplinaBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            DisciplinaBLL disciplinaBLL = new DisciplinaBLL();
            disciplinaBindingSource.DataSource = disciplinaBLL.Buscar(textBoxDiciplina.Text);

        }
    }
}
