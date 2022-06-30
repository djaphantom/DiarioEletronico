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
