using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SistemaLojaDeCarros
{
    public partial class CadastroEndereco : Form
    {
        Banco banco = new Banco();

        public string logradouro, num, complemento, bairro, cidade;

        public bool enderecoPreenchido = false;
        public CadastroEndereco()
        {
            InitializeComponent();
        }


        private void btnEnderecoCada_Click(object sender, EventArgs e)
        {
            // Validando se os campos estão vazios
            if (validaForm())
            {
                logradouro = txtBoxLog.Text;
                num = txtBoxNum.Text;
                complemento = txtBoxComple.Text;
                bairro = txtBoxBairro.Text;
                cidade = txtBoxCidade.Text;
                enderecoPreenchido = true;

                this.Close();
            }

        }

        private bool validaForm()
        {
            if (txtBoxLog.Text.Length == 0)
            {
                Util.exibeErro("Logradouro não pode estar vazio!");
                return false;
            }
            if (txtBoxNum.Text.Length == 0)
            {
                Util.exibeErro("Número não pode estar vazio!");
                return false;
            }
            if (txtBoxBairro.Text.Length == 0)
            {
                Util.exibeErro("Bairro não pode estar vazio!");
                return false;
            }
            if (txtBoxCidade.Text.Length == 0)
            {
                Util.exibeErro("Cidade não pode estar vazio!");
                return false;
            }
            bool resultParse = int.TryParse(txtBoxNum.Text, out int num);
            if (!resultParse)
            {
                Util.exibeErro("O número da casa precisa ser um número!");
                return false;
            }

            return true;
        }
    }
}
