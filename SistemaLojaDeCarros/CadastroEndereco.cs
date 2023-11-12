using System;
using System.Windows.Forms;

namespace SistemaLojaDeCarros
{
    public partial class CadastroEndereco : Form
    {
        public CadastroEndereco()
        {
            InitializeComponent();
        }


        private void btnEnderecoCada_Click(object sender, EventArgs e)
        {
            // Validando se os campos estão vazios
            if (validaForm())
            {
                
            }
        }

        private void msgErro(string msg)
        {
            MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool validaForm()
        {
            if (txtBoxLog.Text.Length == 0)
            {
                msgErro("Logradouro não pode estar vazio!");
                return false;
            }
            if (txtBoxNum.Text.Length == 0)
            {
                msgErro("Número não pode estar vazio!");
                return false;
            }
            if (txtBoxBairro.Text.Length == 0)
            {
                msgErro("Bairro não pode estar vazio!");
                return false;
            }
            if (txtBoxCidade.Text.Length == 0)
            {
                msgErro("Cidade não pode estar vazio!");
                return false;
            }

            return true;
        }
    }
}
