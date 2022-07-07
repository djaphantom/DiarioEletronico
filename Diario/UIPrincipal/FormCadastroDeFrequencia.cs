using BLL;
using Model;
using System;
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
    }
}
