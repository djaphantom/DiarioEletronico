using BLL;
using DAL;
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
            try
            {
                professorBindingSource.EndEdit();
                inserir();
                MessageBox.Show("Cadastro realizado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            using (PrincipalAgente frn = new PrincipalAgente())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }

        }

        private void inserir()
        {
            ProfessorBLL professorBLL = new ProfessorBLL();
            Professor professor = new Professor();

            professor.Id = Convert.ToInt32(textBoxid.Text);
            professor.Id_Sexo = Convert.ToInt32(Sexo_comboBox.SelectedValue.ToString());
            professor.NomeProfessor = textBoxNomeDoProfessor.Text;
            professor.CPF_Professor = cpf_maskedTextBox1.Text;
            professor.EnderecoProfessor = textBoxEndereco.Text;
            professor.Setor = textBoxSetor.Text;
            professor.Id_Cidade = Convert.ToInt32(comboBoxCidade.SelectedValue.ToString());
            professor.CEP = maskedTextBoxCEP.Text;
            professor.Id_Cidade = Convert.ToInt32(comboBoxUF.SelectedValue.ToString());
            professor.Email = textBoxEmail.Text;
            professor.Telefone = maskedTextBoxTelefone.Text;
            professor.DataDeNascimento = maskedTextBoxData.Text;
            professor.Senha = textBoxSenha.Text;
            professorBLL.Inserir(professor);
        }

        private void retornarCidade()
        {
            Banco banco = new Banco();
            comboBoxCidade.Items.Clear();
            comboBoxCidade.DataSource = Banco.dql(banco.vqueryCidade);
            comboBoxCidade.DisplayMember = "NomeCidade";
            comboBoxCidade.ValueMember = "Id";

        }
        private void retornarSexo()
        {
            Banco banco = new Banco();
            Sexo_comboBox.Items.Clear();
            Sexo_comboBox.DataSource = Banco.dql(banco.vquerySEXO);
            Sexo_comboBox.DisplayMember = "SEXO";
            Sexo_comboBox.ValueMember = "Id";

        }
        private void retornarUF()
        {
            Banco banco = new Banco();
            Sexo_comboBox.Items.Clear();
            Sexo_comboBox.DataSource = Banco.dql(banco.vqueryUF);
            Sexo_comboBox.DisplayMember = "SEXO";
            Sexo_comboBox.ValueMember = "Id";

        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            retornarCidade();
            retornarSexo();
        }
    }
}
