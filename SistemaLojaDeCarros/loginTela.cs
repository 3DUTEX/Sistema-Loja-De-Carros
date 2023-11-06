using MySql.Data.MySqlClient;
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
    public partial class LoginTela : Form
    {
        //chamando a string de conexao
        Conexao con = new Conexao();

        //Instânciando ação para executar script sql
        MySqlCommand cmd = new MySqlCommand();

        //declarando as variáveis do usuário logado
        public bool logado = false;
        public static string usuarioConectado;
        public LoginTela()
        {
            InitializeComponent();
        }

        private void loginTela_Load(object sender, EventArgs e)
        {

        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked == true) //Mostrar senha está marcado?
                txtBoxSenha.UseSystemPasswordChar = false;
            else
                txtBoxSenha.UseSystemPasswordChar = true;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            DataTable dados = new DataTable();
            MySqlDataAdapter Data = new MySqlDataAdapter("SELECT * FROM LOGINFUNC WHERE  NM_USUARIO=@USER AND NO_SENHA=@SENHA", con.MyConnectarBD()); // Procurando Login no BD

            Data.SelectCommand.Parameters.AddWithValue("@USER", txtBoxLogin.Text);
            Data.SelectCommand.Parameters.AddWithValue("@SENHA", txtBoxSenha.Text);

            Data.Fill(dados);

            if (dados.Rows.Count == 0)
            {
                logado = false;
                MessageBox.Show("USUARIO/SENHA INVÁLIDOS");
            }
            else
            {
                usuarioConectado = txtBoxLogin.Text;
                logado = true;
                MenuTela menu = new MenuTela();
                menu.Show();
                this.Hide();

                MessageBox.Show("SEJA BEM VINDO AO SISTEMA, TOME CUIDADO!");
            }
        }
    }
}
