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
    public partial class ConsultarCliente : Form
    {
        Banco banco = new Banco();  
        Conexao con =  new Conexao();


        public ConsultarCliente()
        {
            InitializeComponent();
            selectAll();
        }

        private void txtPesqId_TextChanged(object sender, EventArgs e)
        {
            string id = txtPesqId.Text;
            if (id.Length > 0)
            {
                DataTable dt = new DataTable($"select * from Cliente where cdg_cliente = {id}");
                dtGridClientes.DataSource = dt;
            }
            else
                selectAll();

        }

        private void txtPesqName_TextChanged(object sender, EventArgs e)
        {
            string nome = txtPesqName.Text;
            string sobrenome = txtPesqSobrenome.Text;

            DataTable dt = banco.selectDataTable($"select * from Cliente");

            if (nome.Length > 0 && sobrenome.Length > 0)
            {
                dt = banco.selectDataTable($"select * from Cliente where nm_cliente like '%{nome}%' and nm_sobrenome like '{sobrenome}'");
            }
            else if (nome.Length > 0)
            {
                dt = banco.selectDataTable($"select * from Cliente where nm_cliente like '%{nome}%'");
            }
            else if(sobrenome.Length > 0 )
            {
                dt = banco.selectDataTable($"select * from Cliente where nm_sobrenome like '%{sobrenome}%'");
            }

            dtGridClientes.DataSource = dt;
        }

        private void selectAll()
        {
            DataTable dt = banco.selectDataTable("select * from Cliente");
            dtGridClientes.DataSource = dt;
        }
    }
}
