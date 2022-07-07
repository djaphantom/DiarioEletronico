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
    public partial class FormPlanoDeAula : Form
    {
        public FormPlanoDeAula()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            PlanoDeAulaBLL planoDeAulaBLLoBLL = new PlanoDeAulaBLL();
            PlanoDeAula planoDeAula = new PlanoDeAula();

            planoDeAula.Id = Convert.ToInt32(idTextBox.Text);
            planoDeAula.Id_Diario = Convert.ToInt32(id_DiarioTextBox.Text);
            planoDeAula.Id_professor = Convert.ToInt32(id_professorTextBox.Text);

            planoDeAulaBLLoBLL.Inserir(planoDeAula);
            MessageBox.Show("Operação realizada com sucesso!");
            planoDeAulaBindingSource.DataSource = typeof(PlanoDeAula);
            planoDeAulaBindingSource.AddNew();
            idTextBox.Focus();
        }
    }
}
