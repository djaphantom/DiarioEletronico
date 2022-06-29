using System.Windows.Forms;
using System;

namespace UIPrincipal
{
    public partial class FormLongin : Form
    {
        public FormLongin()
        {
            InitializeComponent();
        }

        private void FormLongin_Load(object sender, EventArgs e)
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


    }
}
