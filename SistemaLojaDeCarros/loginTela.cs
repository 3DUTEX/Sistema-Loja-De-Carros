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
        public static int cdgUsuarioConectado;
        public LoginTela()
        {
            InitializeComponent();
        }

        private void loginTela_Load(object sender, EventArgs e)
        {
            // AO CARREGAR A TELA
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
            MySqlCommand selectUser = new MySqlCommand($"SELECT * FROM LOGINFUNC WHERE NM_USUARIO= '{txtBoxLogin.Text}' AND NO_SENHA = '{txtBoxSenha.Text}' ", con.MyConnectarBD());
                                                         
            MySqlDataReader reader = selectUser.ExecuteReader();

            // Se achar registro atribui as variáveis
            while (reader.Read())
            {
                cdgUsuarioConectado = int.Parse(reader["cdg_loginFunc"].ToString());
                usuarioConectado = reader["nm_usuario"].ToString();
            }
            
            if (usuarioConectado == null)
            {
                logado = false;
                MessageBox.Show("USUARIO/SENHA INVÁLIDOS");
                reader.Close();
            }
            else
            {
                logado = true;
                MenuTela menu = new MenuTela();
                menu.Show();
                this.Hide();

                MessageBox.Show("SEJA BEM VINDO AO SISTEMA, TOME CUIDADO!");
                reader.Close();
            }
        }
    }
}
