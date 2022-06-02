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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            AlunoBLL alunoBLL = new AlunoBLL();
            Aluno aluno = new Aluno();

            aluno.ID = Convert.ToInt32('nome do textbox');      
            aluno.NomeAluno = ('nome do textbox');             
            
        }
    }
}
