using BLL;
using DAL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroAluno : Form
    {
        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void inserir()
        {
            AlunoBLL alunoBLL = new AlunoBLL();
            Aluno aluno = new Aluno();

            aluno.ID = Convert.ToInt32(textBox_idAluno.Text);
            aluno.Id_Turma = Convert.ToInt32(comboBoxTURMA.SelectedValue.ToString());
            aluno.NomeAluno = textBoxNomeAluno.Text;
            aluno.EnderecoAluno = textBoxEndereco.Text;
            aluno.Setor = textBoxSetor.Text;
            aluno.Numero = Convert.ToInt32(textBoxNumero.Text);
            aluno.CEP = maskedTextBoxCEP.Text;
            aluno.Id_Cidade = Convert.ToInt32(comboBoxCIDADE.SelectedValue.ToString());
            aluno.TelefoneResponsavel = maskedTextBoxTelefone.Text;
            aluno.Email = textBoxEmail.Text;
            aluno.DataDeNascimento = maskedTextBoxData.Text;
            aluno.Id_Sexo = Convert.ToInt32(comboBoxSEXO.SelectedValue.ToString());
            aluno.NomeResponsavel = textBoxNResponsavel.Text;
            aluno.Senha = textBoxSenha.Text;
            aluno.CPF = cpf_maskedTextBox1.Text;

            alunoBLL.Inserir(aluno);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                alunoBindingSource.EndEdit();
                inserir();
                MessageBox.Show("Cadastro realizado com sucesso!");
                alunoBindingSource.DataSource = typeof(Aluno);
                alunoBindingSource.AddNew();
                textBoxNomeAluno.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(" Ocorreu um erro: " + ex.Message);
            }
        }//BOTÃO DE SALVAR COM MESSAGEM DE SUCESSO OU DE ERRO AO SALVAR

        private void retornarCidade()
        {
            Banco banco = new Banco();
            comboBoxCIDADE.Items.Clear();
            comboBoxCIDADE.DataSource = Banco.dql(banco.vqueryCidade);
            comboBoxCIDADE.DisplayMember = "NomeCidade";
            comboBoxCIDADE.ValueMember = "Id";

        }
        private void retornarSexo()
        {
            Banco banco = new Banco();
            comboBoxSEXO.Items.Clear();
            comboBoxSEXO.DataSource = Banco.dql(banco.vquerySEXO);
            comboBoxSEXO.DisplayMember = "SEXO";
            comboBoxSEXO.ValueMember = "Id";

        }
        private void retornarUF()
        {
            Banco banco = new Banco();
            comboBoxUF.Items.Clear();
            comboBoxUF.DataSource = Banco.dql(banco.vqueryUF);
            comboBoxUF.DisplayMember = "NomeUF";
            comboBoxUF.ValueMember = "Id";

        }
        private void retornarTurma()
        {
            Banco banco = new Banco();
            comboBoxTURMA.Items.Clear();
            comboBoxTURMA.DataSource = Banco.dql(banco.vqueryTurma);
            comboBoxTURMA.DisplayMember = "Periodo";
            comboBoxTURMA.ValueMember = "Id";

        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            retornarCidade();
            retornarSexo();
            retornarUF();
            retornarTurma();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            using (PrincipalAgente frn = new PrincipalAgente())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroAluno frn = new FormCadastroAluno())
            {
                this.Visible = !this.Visible;
                frn.ShowDialog();
                this.Visible = !this.Visible;
                Close();
            }
        }

        private void textBox_idAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSetor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCIDADE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}

