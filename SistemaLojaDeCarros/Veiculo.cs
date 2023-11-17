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
    public partial class Veiculo : Form
    {
        public Veiculo()
        {
            InitializeComponent();
        }

        private void carregarNovaJanela(object objCarregarNovaJanela)
        {
            if (this.panelInfoVeiculo.Controls.Count > 0)
                this.panelInfoVeiculo.Controls.RemoveAt(0);
            Form novaJan = objCarregarNovaJanela as Form;
            novaJan.TopLevel = false;
            novaJan.Dock = DockStyle.Fill;
            this.panelInfoVeiculo.Controls.Add(novaJan);
            this.panelInfoVeiculo.Tag = novaJan;
            novaJan.Show();
        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            carregarNovaJanela(new CadastroVeiculo());
        }

        private void btnConsultarVeiculo_Click(object sender, EventArgs e)
        {
            carregarNovaJanela(new ConsultarVeiculo());
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuTela menu = new MenuTela();
            menu.Show();
            this.Hide();
        }
    }
}
