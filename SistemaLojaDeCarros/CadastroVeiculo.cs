using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaDeCarros
{
    public partial class CadastroVeiculo : Form
    {
        Conexao con = new Conexao();
        public static string msg;
        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        private bool validaCampos()
        {
            if(txtBoxModelo.Text.Length == 0)
            {
                Util.exibeErro("O campo modelo não pode estar vazio!");
                return false;
            }
            if(txtBoxFabricante.Text.Length == 0)
            {
                Util.exibeErro("O campo fabricante não pode estar vazio!");
                return false;
            }
            if(txtBoxPlaca.Text.Length == 0)
            {
                Util.exibeErro("O campo placa não pode estar vazio!");
                return false;
            }
            if(txtBoxCor.Text.Length == 0)
            {
                Util.exibeErro("O campo cor não pode estar vazio!");
                return false;
            }
            if(txtBoxDescricao.Text.Length == 0)
            {
                Util.exibeErro("O campo descrição não pode estar vazio!");
                return false;
            }
            if(pictureBoxVeiculo.Image == null)
            {
                Util.exibeErro("O campo imagem não pode estar vazio!");
                return false;
            }
            return true;
        }

        private void btnInserirVeiculo_Click(object sender, EventArgs e)
        {
            string modelo = txtBoxModelo.Text;
            string fabricante = txtBoxFabricante.Text;
            string placa = txtBoxPlaca.Text;
            string cor = txtBoxCor.Text;
            string veiculo = txtBoxDescricao.Text;
            
            validaCampos();

            string strInsertVeiculo = "INSERT INTO VEICULO(nm_modelo, nm_fabricante, nm_placa, nm_cor, ds_veiculo, imagem) VALUES(@modelo, @fabricante, @placa, @cor, @descricao, '" + pictureBoxVeiculo.Image + "')";
            MySqlCommand cmd = new MySqlCommand(strInsertVeiculo, con.MyConnectarBD());

            cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = modelo;
            cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = fabricante;
            cmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = placa;
            cmd.Parameters.Add("@cor", MySqlDbType.VarChar).Value = cor;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = veiculo;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Veículo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaForm();
            }

            catch(Exception ex)
            {
                msg = "Ocorreu um erro ao fazer o cadastro!" + ex.Message;
            }

            con.MyDesConnectionBD();
      
        }

        private void limpaForm()
        {
            txtBoxModelo.Text = "";
            txtBoxFabricante.Text = "";
            txtBoxPlaca.Text = "";
            txtBoxDescricao.Text = "";
            txtBoxCor.Text = "";
            pictureBoxVeiculo.Image = null;
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Escolha a imagem(*.jpg; *.png)|*.jpg; *.png";

            if(ofd.ShowDialog() == DialogResult.OK)
                pictureBoxVeiculo.Image = Image.FromFile(ofd.FileName);
        }
    }
}
