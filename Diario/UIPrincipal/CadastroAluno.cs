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
            aluno.NomeAluno = textBoxNomeAluno.Text;
            aluno.Id_Turma = Convert.ToInt32(textBoxid_Turma.Text);
            aluno.EnderecoAluno = textBoxEndereco.Text;
            aluno.Setor = textBoxSetor.Text;
            aluno.Numero = Convert.ToInt32(textBoxNumero.Text);
            aluno.CEP = textBoxCep.Text;
            aluno.CidadeAluno = textBoxCidade.Text;
            aluno.UF = textBoxUF.Text;
            aluno.TelefoneResponsavel = textBoxTelefone.Text;
            aluno.Email = textBoxEmail.Text;
            aluno.DataDeNascimento = textBoxDataNasc.Text;
            aluno.Sexo = textBoxSexoF_M.Text;
            aluno.NomeResponsavel = textBoxNResponsavel.Text;
            aluno.Senha = textBoxSenha.Text;
            aluno.cpf = textBoxCPF.Text;
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

