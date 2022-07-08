using BLL;
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

            aluno.ID = textBox_idAluno.Text != "" ? Convert.ToInt32(textBox_idAluno.Text) : 0 ;
            aluno.NomeAluno = textBoxNomeAluno.Text;
            aluno.Id_Turma = textBoxid_Turma.Text != "" ? Convert.ToInt32(textBoxid_Turma.Text) : 0 ;
            aluno.EnderecoAluno = textBoxEndereco.Text;
            aluno.Setor = textBoxSetor.Text;
            aluno.Numero = textBoxNumero.Text != "" ? Convert.ToInt32(textBoxNumero.Text) : 0 ;
            aluno.CEP = textBoxCep.Text;


            aluno.Id_Cidade = textBoxCidade.Text != "" ? Convert.ToInt32(textBoxCidade.Text) : 0 ;
            aluno.TelefoneResponsavel = textBoxTelefone.Text;
            aluno.Email = textBoxEmail.Text;
            aluno.DataDeNascimento = textBoxDataNasc.Text;
            aluno.Id_Sexo = textBoxSexoF_M.Text;
            aluno.NomeResponsavel = textBoxNResponsavel.Text;
            aluno.Senha = textBoxSenha.Text;
            aluno.CPF = textBoxCPF.Text;
            alunoBLL.Inserir(aluno);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                alunoBindingSource.EndEdit();
                inserir();
                MessageBox.Show("Cadastro realizado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Ocorreu um erro: " + ex.Message);
            }
        }//BOTÃO DE SALVAR COM MESSAGEM DE SUCESSO OU DE ERRO AO SALVAR


    }

}

