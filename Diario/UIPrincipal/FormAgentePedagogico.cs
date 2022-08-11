using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormAgentePedagogico : Form
    {
        public FormAgentePedagogico()
        {
            InitializeComponent();
        }

        private void inserir()
        {
            AgentePedagogicoBLL agentePedagogicoBLL = new AgentePedagogicoBLL();
            AgentePedagogico agentePedagogico = new AgentePedagogico();

            agentePedagogico.Id = Convert.ToInt32(idTextBox.Text);
            agentePedagogico.NomeAgente = nomeAgenteTextBox.Text;
            agentePedagogico.Senha = senhaTextBox.Text;

            agentePedagogicoBLL.Inserir(agentePedagogico);

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                agentePedagogicoBindingSource.EndEdit();
                inserir();
                MessageBox.Show("Cadastro realizado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Ocorreu um erro: " + ex.Message);
            }
        }

        private void labelaAcessoAgente_Click(object sender, EventArgs e)
        {

        }
    }
}
