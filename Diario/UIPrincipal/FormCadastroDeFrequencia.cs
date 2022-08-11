using BLL;
using Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroDeFrequencia : Form
    {
        public FormCadastroDeFrequencia()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            FrequenciaBLL frequenciaBLL = new FrequenciaBLL();
            Frequencia frequencia = new Frequencia();

            frequencia.Id = Convert.ToInt32(idTextBox);
            frequencia.Id_Aluno = Convert.ToInt32(id_AlunoTextBox);
            frequencia.Id_Diario = Convert.ToInt32(id_DiarioTextBox);


            frequenciaBLL.Inserir(frequencia);
            MessageBox.Show("Operação realizada com sucesso!");
            frequenciaBindingSource.DataSource = typeof(Frequencia);
            frequenciaBindingSource.AddNew();
            idTextBox.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FrequenciaBLL frequenciaBLL = new FrequenciaBLL();
            frequenciaBindingSource.DataSource = frequenciaBLL.Buscar(textBox_BuscarFrequencia.Text);
        }

        private void btn_retornar_Click(object sender, EventArgs e)
        {
            using (PrincipalProfessor frn = new PrincipalProfessor())
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
            FrequenciaBLL frequenciaBLL = new FrequenciaBLL();

            int id;

            id = Convert.ToInt32(((DataRowView)frequenciaBindingSource.Current).Row["Id"]);
            frequenciaBLL.Excuir(id);
            frequenciaBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com secesso!");
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
