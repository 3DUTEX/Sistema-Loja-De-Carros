using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SistemaLojaDeCarros
{
    public partial class LoginTela : Form
    {
        //chamando a string de conexao
        Conexao con = new Conexao();

        //Instânciando ação para executar script sql
        MySqlCommand cmd = new MySqlCommand();


        Banco banco = new Banco();

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
            // using faz com que a instância do MySqlDataReader seja descartada depois de utilizada, fechando a conexão
            using (MySqlDataReader reader = banco.select($"SELECT * FROM LOGINFUNC WHERE NM_USUARIO= '{txtBoxLogin.Text}' AND NO_SENHA = '{txtBoxSenha.Text}' "))
            {
                // Se achar registro atribui as variáveis
                while (reader.Read())
                {
                    cdgUsuarioConectado = int.Parse(reader["cdg_loginFunc"].ToString());
                    usuarioConectado = reader["nm_usuario"].ToString();
                }

                reader.Close();
            }

            if (usuarioConectado == null)
            {
                logado = false;
                MessageBox.Show("USUARIO/SENHA INVÁLIDOS");
            }
            else
            {
                logado = true;
                MenuTela menu = new MenuTela();
                menu.Show();
                this.Hide();

                MessageBox.Show("SEJA BEM VINDO AO SISTEMA, TOME CUIDADO!");
            }
        }
    }
}
