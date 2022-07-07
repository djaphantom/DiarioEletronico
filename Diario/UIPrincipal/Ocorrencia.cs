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
    }
}
