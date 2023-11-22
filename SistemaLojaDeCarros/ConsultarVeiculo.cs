using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaDeCarros
{
    public partial class ConsultarVeiculo : Form
    {
        Banco banco = new Banco();

        static public string cdgVeiculoClicado;

        public ConsultarVeiculo()
        {
            InitializeComponent();
            selectAll();
        }

        private void selectAll()
        {
            DataTable dt = banco.selectDataTable("SELECT * FROM VEICULO");
            dtGridVeiculos.DataSource = dt;
        }

        private void txtPesqId_TextChanged(object sender, EventArgs e)
        {
            bool idIsNum = int.TryParse(txtPesqId.Text, out int id);

            if(!idIsNum && txtPesqId.Text != "") 
            {
                Util.exibeErro("O id precisa ser um número!");
                txtPesqId.Text = "";
                return;
            }

            txtPesqModelo.Enabled = txtPesqPlaca.Enabled = txtPesqId.Text == "" ? true : false;
            //As textbox Modelo e Placa só estarão ativas se a TextBox ID estiver vazia. Caso contrário, ela fica desativada.
           
            atualizaDataGrid();
        }

        private void atualizaDataGrid()
        {
            string id = txtPesqId.Text.Trim();
            string modelo = txtPesqModelo.Text.Trim();
            string placa = txtPesqPlaca.Text.Trim();

            DataTable dt = banco.selectDataTable("SELECT * FROM VEICULO");

            if(id.Length > 0)
            {
                dt = banco.selectDataTable($"SELECT * FROM VEICULO WHERE cdg_veiculo = '{id}'");
            }
            else if(modelo.Length > 0)
            {
                dt = banco.selectDataTable($"SELECT * FROM VEICULO WHERE nm_modelo like '{modelo}'");
            }
            else if(placa.Length > 0)
            {
                dt = banco.selectDataTable($"SELECT * FROM VEICULO WHERE nm_placa = '{placa}'");
            }
            
            dtGridVeiculos.DataSource = dt;
        }

        private void txtPesqPlaca_TextChanged(object sender, EventArgs e)
        {
            txtPesqId.Enabled = txtPesqModelo.Enabled = txtPesqPlaca.Text == "" ? true : false;
            //Mesma ideia citada no ID, só que agora com a placa
            atualizaDataGrid();
        }
    }
}
