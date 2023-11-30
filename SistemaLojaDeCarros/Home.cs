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
    public partial class Home : Form
    { 
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblUsuConectado.Text = LoginTela.usuarioConectado;
        }

        private void Home_Resize(object sender, EventArgs e)
        { 
            lblWelcome.Font = new Font("Arial Rounded MT Bold", 20);
            lblUsuConectado.Font = new Font("Arial Rounded MT Bold", 20);
        }
    }
}
