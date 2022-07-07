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
    public partial class CadastroProfessor : Form
    {
        public CadastroProfessor()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ProfessorBLL professorBLL = new ProfessorBLL();
            Professor professor = new Professor();

            professor.Id = Convert.ToInt32(textBoxid.Text);
            professor.NomeProfessor = textBoxNomeDoProfessor.Text;
            professor.CPF_Professor = cpf_maskedTextBox1.Text;
            professor.Email = textBoxEmail.Text;
            professor.Telefone = maskedTextBoxTelefone.Text;
            professor.DataDeNascimento = maskedTextBoxData.Text;
            professor.EnderecoProfessor = textBoxEndereco.Text;
            professor.Setor = textBoxSetor.Text;
            professor.CEP = maskedTextBoxCEP.Text;
            professor.Senha = textBoxSenha.Text;
            professorBLL.Inserir(professor);
            MessageBox.Show("Operação realizada com sucesso!");
            professorBindingSource.DataSource = typeof(AgentePedagogico);
            professorBindingSource.AddNew();
            textBoxNomeDoProfessor.Focus();
        }

    }
}
