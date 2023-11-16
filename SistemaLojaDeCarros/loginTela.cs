using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaLojaDeCarros
{
    public partial class LoginTela : Form
    {
        //chamando a string de conexao
        Conexao con = new Conexao();

        //Instânciando ação para executar script sql
        MySqlCommand cmd = new MySqlCommand();


        Banco banco = new Banco();

        bool fullscreen = false;

        //declarando as variáveis do usuário logado
        public bool logado = false;
        public static string usuarioConectado;
        public static int cdgUsuarioConectado;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public LoginTela()
        {
            InitializeComponent();
        }

        private void loginTela_Load(object sender, EventArgs e)
        {
            // AO CARREGAR A TELA
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
                Util.exibeErro("USUARIO/SENHA INVÁLIDOS");
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

        private void GoFullscreen(ref bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                fullscreen = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                fullscreen = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GoFullscreen(ref fullscreen);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
