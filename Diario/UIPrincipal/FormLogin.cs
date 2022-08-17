using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormLogin : Form
    {
        public bool Logou;
        public FormLogin()
        {
            InitializeComponent();
            Logou = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.ImageLocation = Environment.CurrentDirectory + @"\Imagens\ImagemLongin.png";
            pictureBoxLogoM.ImageLocation = Environment.CurrentDirectory + @"\Imagens\senai-logo-1.png";
            pictureBoxSenhaLogo.ImageLocation = Environment.CurrentDirectory + @"\Imagens\adicionar-usuario.png";
            pictureBoxUsuarioLogo.ImageLocation = Environment.CurrentDirectory + @"\Imagens\senha (1).png";
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
         
            string nome;
            string senha;

            AgentePedagogicoBLL agenteBLL = new AgentePedagogicoBLL();
            BindingSource AgenteBindingSource = new BindingSource();
            AgenteBindingSource.DataSource = agenteBLL.Buscar(textBoxUsuario.Text);

            ProfessorBLL professorBLL = new ProfessorBLL();
            BindingSource professorBindingSource = new BindingSource();
            professorBindingSource.DataSource = professorBLL.Buscar(textBoxUsuario.Text);

            AlunoBLL alunoBLL = new AlunoBLL();
            BindingSource alunoBindingSource = new BindingSource();
            alunoBindingSource.DataSource = alunoBLL.Buscar(textBoxUsuario.Text);

            /* COMEÇO DE VALIDAÇÃO DE SENHA E USUARIO COM CONDIÇÕES */

            if (AgenteBindingSource.Count != 0)
            {
                nome = ((DataRowView)AgenteBindingSource.Current).Row["NomeUsuario"].ToString();
                senha = ((DataRowView)AgenteBindingSource.Current).Row["Senha"].ToString();

                // if (nome == textBoxUsuario.Text && Infra.Criptografia.verificarHash(textBoxSenha.Text, senha))
                if (nome == textBoxUsuario.Text && senha == textBoxSenha.Text)
                {
                    Logou = true;
                    this.Visible = !this.Visible;
                    using (PrincipalAgente frn = new PrincipalAgente())
                    {
                        frn.ShowDialog();
                    }
                    this.Visible = !this.Visible;
                    Close();
                }

            }
            else
            {
                if (professorBindingSource.Count != 0)
                {
                    nome = ((DataRowView)professorBindingSource.Current).Row["NomeUsuario"].ToString();
                    senha = ((DataRowView)professorBindingSource.Current).Row["Senha"].ToString();
                    if (nome == textBoxUsuario.Text && Infra.Criptografia.verificarHash(textBoxSenha.Text, senha))
                    {
                        Logou = true;
                        this.Visible = !this.Visible;
                        using (PrincipalProfessor frn = new PrincipalProfessor())
                        {
                            frn.ShowDialog();
                        }
                        this.Visible = !this.Visible;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("USUÁRIO OU SENHA INCORRETOS!");
                        textBoxSenha.Text = "";
                        textBoxSenha.Focus();
                    }
                }

                else
                {
                    if (alunoBindingSource.Count != 0)
                    {
                        nome = ((DataRowView)alunoBindingSource.Current).Row["NomeUsuario"].ToString();
                        senha = ((DataRowView)alunoBindingSource.Current).Row["Senha"].ToString();

                        if (nome == textBoxUsuario.Text && Infra.Criptografia.verificarHash(textBoxSenha.Text, senha))
                        {
                            Logou = true;
                            this.Visible = !this.Visible;
                            using (PrincipalAluno frn = new PrincipalAluno())
                            {
                                frn.ShowDialog();
                            }
                            this.Visible = !this.Visible;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("USUÁRIO OU SENHA INCORRETOS!");
                            textBoxSenha.Text = "";
                            textBoxSenha.Focus();
                        }
                    }

                    else
                    {
                        MessageBox.Show("USUÁRIO OU SENHA INCORRETOS!");
                        textBoxSenha.Text = "";
                        textBoxSenha.Focus();
                    }/* AGENTE PEDAGOGICO VALIDAÇÃO */
                }
            }
        }

        private void CBMostra_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMostra_senha.Checked)
            {
                textBoxSenha.PasswordChar = '\0';
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
            }
        }
    }
}
