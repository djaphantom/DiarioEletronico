using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class Ocorrencia : Form
    {
        public Ocorrencia()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluirO_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            OcorrenciaBLL ocorrenciaBLL = new OcorrenciaBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)ocorrenciaBindingSource.Current).Row["Id"]);
            ocorrenciaBLL.Excluir(id);
            ocorrenciaBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonBuscarOcorrencia_Click(object sender, EventArgs e)
        {
            OcorrenciaBLL ocorrenciaBLL = new OcorrenciaBLL();
            ocorrenciaBindingSource.DataSource = ocorrenciaBLL.Buscar(textBoxOcorrencia.Text);
        }

        private void Ocorrencia_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovoO_Click(object sender, EventArgs e)
        {
            using (LancarOcorrencia frn = new LancarOcorrencia())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }  
        }

        private void buttonAlterarO_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            /*using (LancarOcorrencia frn = new  LancarOcorrencia (ocorrenciaBindingSource.Current))
=======
            using (LancarOcorrencia frm = new LancarOcorrencia())
>>>>>>> 83745d01bb4f85d2909fad628164f210cc086cc1
            {
                frn.ShowDialog();
            }*/
        }

        private void buttonSairO_Click(object sender, EventArgs e)
        {
            using(PrincipalProfessor frn = new PrincipalProfessor())    
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close(); 
            }
        }

        private void textBoxOcorrencia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
