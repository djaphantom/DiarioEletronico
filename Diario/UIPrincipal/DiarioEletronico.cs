using BLL;
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
    public partial class DiarioEletronico : Form
    {
        public DiarioEletronico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            DiarioEletronicoBLL diarioEletronicoBLL = new DiarioEletronicoBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)diarioEletronicoBindingSource.Current).Row["Id"]);
            diarioEletronicoBLL.Excluir(id);
            diarioEletronicoBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            DiarioEletronicoBLL diarioEletronicoBLL = new DiarioEletronicoBLL();
            diarioEletronicoBindingSource.DataSource = diarioEletronicoBLL.Buscar(textBusca.Text);
        }
    }
}
