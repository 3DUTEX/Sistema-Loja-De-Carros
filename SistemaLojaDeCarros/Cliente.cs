using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaDeCarros
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        
        private void carregarNovaJanela(object objCarregarNovaJanela)
        {
            if (this.panelInfoCliente.Controls.Count > 0)
                this.panelInfoCliente.Controls.RemoveAt(0);
            Form novaJan = objCarregarNovaJanela as Form;
            novaJan.TopLevel = false;
            novaJan.Dock = DockStyle.Fill;
            this.panelInfoCliente.Controls.Add(novaJan);
            this.panelInfoCliente.Tag = novaJan;
            novaJan.Show();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            carregarNovaJanela(new CadastroCliente());
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            carregarNovaJanela(new ConsultarCliente());
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            carregarNovaJanela(new ConsultarCliente());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuTela menu = new MenuTela();
            menu.Show();
            this.Hide();
        }
    }
}
