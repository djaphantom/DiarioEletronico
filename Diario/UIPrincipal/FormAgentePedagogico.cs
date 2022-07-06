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
    public partial class FormAgentePedagogico : Form
    {
        public FormAgentePedagogico()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            AgentePedagogicoBLL agentePedagogicoBLL = new AgentePedagogicoBLL();
            AgentePedagogico agentePedagogico = new AgentePedagogico();

            agentePedagogico.Id = Convert.ToInt32(idTextBox.Text);
            agentePedagogico.NomeAgente = nomeAgenteTextBox.Text;
            agentePedagogico.Senha = senhaTextBox.Text;

            agentePedagogicoBLL.Inserir(agentePedagogico);
            MessageBox.Show("Operação realizada com sucesso!");
            agentePedagogicoBindingSource.DataSource = typeof(AgentePedagogico);
            agentePedagogicoBindingSource.AddNew();
            nomeAgenteTextBox.Focus();
        }
    }
}
