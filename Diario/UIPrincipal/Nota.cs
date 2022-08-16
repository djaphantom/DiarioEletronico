using BLL;
using Model;
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
    public partial class CadastroDeNota : Form
    {
        public CadastroDeNota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NotaBLL notaBLL = new NotaBLL();
            Nota nota = new Nota();

            nota.Id = Convert.ToInt32(idTextBox.Text);
            nota.Id_Aluno = Convert.ToInt32(id_AlunoTextBox.Text);
            nota.Id_Diario = Convert.ToInt32(id_DiarioTextBox.Text);
            nota.Id_Turma = Convert.ToInt32(id_TurmaTextBox.Text);
            nota.NotaAluno = Convert.ToInt32(notaAlunoTextBox);


            notaBLL.Inserir(nota);
            MessageBox.Show("Operação realizada com sucesso!");
            notaBindingSource.DataSource = typeof(Nota);
            notaBindingSource.AddNew();
            idTextBox.Focus();
        }

        private void Nota_Load(object sender, EventArgs e)
        {

        }

        private void buttonExcluirNota_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            NotaBLL notaBLL = new NotaBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)notaBindingSource.Current).Row["Id"]);
            notaBLL.Excluir(id);
            notaBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            using (PrincipalProfessor frn = new PrincipalProfessor ())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAcessarBolitin_Click(object sender, EventArgs e)
        {

        }

        private void ButonAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}

