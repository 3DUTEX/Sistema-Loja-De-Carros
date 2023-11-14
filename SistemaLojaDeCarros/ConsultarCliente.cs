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
            bool idIsNum = int.TryParse(txtPesqId.Text, out int  id);
            if (!idIsNum && txtPesqId.Text != "")
            {
                Util.exibeErro("id precisa ser um número.");
                txtPesqId.Text = "";
                return;
            }
                
            if (txtPesqId.Text != "")
            {
                txtPesqName.Enabled = false;
                txtPesqSobrenome.Enabled = false;
            }
            else
            {
                txtPesqName.Enabled = true;
                txtPesqSobrenome.Enabled = true;
            }
                
            this.atualizaDataGrid();
        }

        private void txtPesqName_TextChanged(object sender, EventArgs e)
        {
            if (txtPesqName.Text != "")
                txtPesqId.Enabled = false;
            else
                txtPesqId.Enabled = true;
            this.atualizaDataGrid();
        }
        private void txtPesqSobrenome_TextChanged(object sender, EventArgs e)
        {
            if (txtPesqSobrenome.Text != "")
                txtPesqId.Enabled = false;
            else
                txtPesqId.Enabled = true;
            this.atualizaDataGrid();
        }

        private void selectAll()
        {
            DataTable dt = banco.selectDataTable("select * from Cliente");
            dtGridClientes.DataSource = dt;
        }

        private void atualizaDataGrid()
        {
            string nome = txtPesqName.Text.Trim();
            string sobrenome = txtPesqSobrenome.Text.Trim();
            string id = txtPesqId.Text.Trim();

            DataTable dt = banco.selectDataTable($"select * from Cliente");

            if (nome.Length > 0 && sobrenome.Length > 0)
            {
                dt = banco.selectDataTable($"select * from Cliente where nm_cliente like '%{nome}%' and nm_sobrenome like '%{sobrenome}%'");
            }
            else if (nome.Length > 0)
            {
                dt = banco.selectDataTable($"select * from Cliente where nm_cliente like '%{nome}%'");
            }
            else if (sobrenome.Length > 0)
            {
                dt = banco.selectDataTable($"select * from Cliente where nm_sobrenome like '%{sobrenome}%'");
            }
            else if (id.Length > 0)
            {
                dt = banco.selectDataTable($"select * from Cliente where cdg_cliente = {id}");
                dtGridClientes.DataSource = dt;
            }

            dtGridClientes.DataSource = dt;
        }
    }
}
