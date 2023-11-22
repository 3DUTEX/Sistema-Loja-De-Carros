using SistemaLojaDeCarros.Properties;
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
            sideMenu();  //inicia com o menu escondido
            ajustaPosicao(panelSubCliente); //metodo que ajusta a posição inicialmente do panel cliente
        }
    
        private void sideMenu() //escondendo menu
        {
            panelSubCliente.Visible = false;
            panelSubVeiculo.Visible = false;
        }
        private void showSideMenu(Panel panel) //mostrando o menu
        {
            if (panel.Visible == false)
                panel.Visible = true;
            else
                panel.Visible = false;
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            showSideMenu(panelSubCliente);
            ajustaPosicao(panelSubCliente);
            trocaImagem(panelSubCliente, pictureSeta);
        }

        private void pictureSeta_Click(object sender, EventArgs e)
        {
            showSideMenu(panelSubCliente);
            ajustaPosicao(panelSubCliente);
            trocaImagem(panelSubCliente, pictureSeta);
        }

        private bool ajustaPosicao(Panel panel) //método que ajusta a posição da seta no veiculo
        {
            bool posicao = panel.Visible;
            if (posicao)           
                pictureSeta2.Location = new Point(168, 221);            
            else            
                pictureSeta2.Location = new Point(168, 140);
            
            return posicao;   
        }

        private void btVeiculo_Click(object sender, EventArgs e)
        {
            showSideMenu(panelSubVeiculo);       
            trocaImagem(panelSubVeiculo, pictureSeta2);      
        }

        private void pictureSeta2_Click(object sender, EventArgs e) //método de click também pra picturebox
        {
            showSideMenu(panelSubVeiculo);
            trocaImagem(panelSubVeiculo, pictureSeta2);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Tem certeza que deseja sair do programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBoxSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Tem certeza que deseja sair do programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
                Application.Exit();
        }    

        private void trocaImagem(Panel panel, PictureBox pictureBox) //método que troca a imagem do picture box, quando o painel está visível
        {
            if (panel.Visible == true)
                pictureBox.Image = Resources.setinha;
            else
                pictureBox.Image = Resources.icons8_voltar_30;
        }

        private void carregarNovaJanela(object objCarregarNovaJanela)
        {
            if (this.panelExibir.Controls.Count > 0)
                this.panelExibir.Controls.RemoveAt(0);
            Form novaJan = objCarregarNovaJanela as Form;
            novaJan.TopLevel = false;
            novaJan.Dock = DockStyle.Fill;
            this.panelExibir.Controls.Add(novaJan);
            this.panelExibir.Tag = novaJan;
            novaJan.Show();
        }

        private void btCadastrarCli_Click(object sender, EventArgs e)
        {
            carregarNovaJanela(new CadastroCliente());
        }

        private void btConsultarCliente_Click(object sender, EventArgs e)
        {
            carregarNovaJanela(new ConsultarCliente());
        }

        private void btCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            carregarNovaJanela(new CadastroVeiculo());
        }

        private void btConsultarVeiculo_Click(object sender, EventArgs e)
        {
            carregarNovaJanela(new ConsultarVeiculo());
        }

        
    }
}
