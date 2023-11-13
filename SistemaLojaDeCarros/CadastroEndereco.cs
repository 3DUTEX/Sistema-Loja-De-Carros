using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SistemaLojaDeCarros
{
    public partial class CadastroEndereco : Form
    {
        Banco banco = new Banco();

        public int cdgEnderecoCadastrado;
        public CadastroEndereco()
        {
            InitializeComponent();
        }


        private void btnEnderecoCada_Click(object sender, EventArgs e)
        {
            // Validando se os campos estão vazios
            if (validaForm())
            {
                string strInsert = $"INSERT INTO ENDERECO(nm_logradouro, no_casa, ds_complemento, nm_bairro, nm_cidade) VALUES('{txtBoxLog.Text}', '{txtBoxNum.Text}'," +
                    $"'{txtBoxComple.Text}', '{txtBoxBairro.Text}', '{txtBoxCidade.Text}');";

                bool resultInsert = banco.ExecuteNonQuery(strInsert); // executa o insert

                if(resultInsert) //Se o insert der certo exibe mensagem
                {
                    MessageBox.Show("Endereço cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Buscando o id onde foi cadastrado o endereco
                using (MySqlDataReader reader = banco.select($"SELECT * FROM ENDERECO WHERE nm_logradouro = '{txtBoxLog.Text}' AND no_casa = '{txtBoxNum.Text}' AND nm_bairro = '{txtBoxBairro.Text}'"))
                {
                    while(reader.Read())
                    {
                        cdgEnderecoCadastrado = int.Parse(reader["cdg_endereco"].ToString()); // Colocando ID em uma variável
                    }

                    reader.Close();
                    
                }
                this.Close();
            }

        }

        private bool validaForm()
        {
            if (txtBoxLog.Text.Length == 0)
            {
                Geral.msgErro("Logradouro não pode estar vazio!");
                return false;
            }
            if (txtBoxNum.Text.Length == 0)
            {
                Geral.msgErro("Número não pode estar vazio!");
                return false;
            }
            if (txtBoxBairro.Text.Length == 0)
            {
                Geral.msgErro("Bairro não pode estar vazio!");
                return false;
            }
            if (txtBoxCidade.Text.Length == 0)
            {
                Geral.msgErro("Cidade não pode estar vazio!");
                return false;
            }

            return true;
        }
    }
}
