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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private  void btnTelaEndereco_Click(object sender, EventArgs e)
        {
            CadastroEndereco telaEndereco = new CadastroEndereco();
            telaEndereco.Show();
        }
    }
}
