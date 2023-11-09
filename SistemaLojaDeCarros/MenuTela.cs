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
    public partial class MenuTela : Form
    {
        public MenuTela()
        {
            InitializeComponent();
        }

        private void MenuTela_Load(object sender, EventArgs e)
        {
            lblUsuLogado.Text = LoginTela.usuarioConectado;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            this.Hide();
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Show();
            this.Hide();
        }
    }
}
