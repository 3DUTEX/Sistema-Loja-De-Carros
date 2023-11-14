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
    public partial class DetalhesCliente : Form
    {
        private string nome, sobrenome, logradouro, num, bairro, cidade, usuario;

        DateTime dtNasc;

        Banco banco = new Banco();
        public DetalhesCliente()
        {
            InitializeComponent();

            string strSelect = $"SELECT * FROM vw_dadosCli WHERE cdg_cliente = {ConsultarCliente.cdgClienteClicado}";

            using (MySqlDataReader reader = banco.select(strSelect))
            {
                while(reader.Read())
                {
                    nome = reader["nm_cliente"].ToString();
                    sobrenome = reader["nm_sobrenome"].ToString();
                    dtNasc = DateTime.Parse(reader["dt_nasc"].ToString());
                    logradouro = reader["nm_logradouro"].ToString();
                    num = reader["no_casa"].ToString();
                    bairro = reader["nm_bairro"].ToString();
                    cidade = reader["nm_cidade"].ToString();
                    usuario = reader["nm_usuario"].ToString();
                }

                reader.Close();
            }

            lblNome.Text = $"{nome} {sobrenome}";
            lblDataNasc.Text = dtNasc.ToString();
            lblEndereco.Text = $"{logradouro} {num} {bairro} {cidade}";
            lblCadaPor.Text = usuario;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
