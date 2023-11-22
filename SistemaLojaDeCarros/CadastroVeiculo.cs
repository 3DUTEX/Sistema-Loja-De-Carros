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
        Banco banco = new Banco();

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
            validaCampos();

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxVeiculo.Image.Save(ms, pictureBoxVeiculo.Image.RawFormat);
                byte[] imagem = ms.ToArray();

                string strInsertVeiculo = $"INSERT INTO VEICULO(nm_modelo, nm_fabricante, nm_placa, nm_cor, ds_veiculo, imagem) VALUES('{txtBoxModelo.Text}','{txtBoxFabricante.Text}'" +
                    $"'{txtBoxPlaca.Text}', '{txtBoxCor.Text}', '{txtBoxDescricao.Text}', @imagem)";
                bool insertVeiculo = banco.ExecuteNonQuery(strInsertVeiculo);

                if (insertVeiculo)
                {
                    MessageBox.Show("Veículo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaForm();
                }
                else
                    Util.exibeErro("Ocorreu um erro, verifique os dados e tente novamente!");
            }
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
