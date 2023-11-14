using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SistemaLojaDeCarros
{
    public partial class CadastroCliente : Form
    {
        Banco banco = new Banco();

        CadastroEndereco telaEndereco;

        int cdgEnderecoCadastrado = 0;
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnTelaEndereco_Click(object sender, EventArgs e)
        {
            telaEndereco = new CadastroEndereco();
            telaEndereco.Show();

            formEnabled(true);
            btnTelaEndereco.Enabled = false;
        }

        private void btnCadaCliente_Click(object sender, EventArgs e)
        {
            if (telaEndereco.enderecoPreenchido)
            {
                buscaCodigoEndereco(); // busca endereço para ver se já existe
                if(cdgEnderecoCadastrado == 0)
                {
                    string strInsertEndereco = $"INSERT INTO ENDERECO(nm_logradouro, no_casa, ds_complemento, nm_bairro, nm_cidade) VALUES('{telaEndereco.logradouro}', '{telaEndereco.num}'," +
                        $"'{telaEndereco.complemento}', '{telaEndereco.bairro}', '{telaEndereco.cidade}');";

                    bool resultInsertEndereco = banco.ExecuteNonQuery(strInsertEndereco); // executa o insert

                    if (!resultInsertEndereco)
                    {
                        Util.exibeErro("O cadastro do endereço deu errado, tente novamente!");
                        return;
                    }

                    buscaCodigoEndereco(); // busca endereço depois de cadastrar
                }
            }

            int cdgUsuario = LoginTela.cdgUsuarioConectado;
            if (cdgEnderecoCadastrado != 0)
            {
                // Valida campos
                if (!validaCampos()) //  Se falso, retorne
                    return;
                string strInsert = $"INSERT INTO CLIENTE (nm_cliente, nm_sobrenome, dt_nasc, cdg_loginFunc, cdg_endereco) VALUES ('{txtBoxNomeCli.Text}', '{txtBoxSobrenomeCli.Text}', STR_TO_DATE('{maskTxtBoxDtNasc.Text}', '%d/%m/%Y'), {LoginTela.cdgUsuarioConectado}, {cdgEnderecoCadastrado});";
                bool resultInsert = banco.ExecuteNonQuery(strInsert);
                if (resultInsert)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetaForm();
                }
                else
                {
                    Util.exibeErro("Ocorreu um erro, verifique os dados e tente novamente!");
                    string strDelete = $"DELETE FROM ENDERECO WHERE cdg_endereco = {cdgEnderecoCadastrado}"; // Apaga endereço criado caso o registro do cliente não seja concluído
                    banco.ExecuteNonQuery(strDelete);
                    resetaForm();
                }
            }
            else
            {
                Util.exibeErro("Cadastre o endereço primeiro!");
                formEnabled(false);
                btnTelaEndereco.Enabled = true;
            }
        }

        private bool validaCampos()
        {
            if (txtBoxNomeCli.Text.Length == 0)
            {
                Util.exibeErro("O campo nome não pode estar vazio!");
                return false;
            }
            if (txtBoxSobrenomeCli.Text.Length == 0)
            {
                Util.exibeErro("O campo sobrenome não pode estar vazio!");
                return false;
            }
            if (!maskTxtBoxDtNasc.MaskCompleted)
            {
                Util.exibeErro("O campo data não pode estar vazio!");
                return false;
            }


            return true;
        }

        private void buscaCodigoEndereco()
        {
            // Buscando o id onde foi cadastrado o endereco
            using (MySqlDataReader reader = banco.select($"SELECT * FROM ENDERECO WHERE nm_logradouro = '{telaEndereco.logradouro}' AND no_casa = '{telaEndereco.num}' AND nm_bairro = '{telaEndereco.bairro}'"))
            {
                while (reader.Read())
                {
                    cdgEnderecoCadastrado = int.Parse(reader["cdg_endereco"].ToString()); // Colocando ID em uma variável
                }
                reader.Close();
            }
        }

        private void formEnabled(bool enabled)
        {
            // Ativa ou desativa o formulário
            txtBoxNomeCli.Enabled = enabled;
            txtBoxSobrenomeCli.Enabled = enabled;
            maskTxtBoxDtNasc.Enabled = enabled;
            btnCadaCliente.Enabled = enabled;
        }
        private void limpaDadosCli()
        {
            // Limpa campos do cliente
            txtBoxNomeCli.Text = "";
            txtBoxSobrenomeCli.Text = "";
            maskTxtBoxDtNasc.Text = "";
        }

        private void maskTxtBoxDtNasc_Click(object sender, EventArgs e)
        {
            maskTxtBoxDtNasc.Focus(); // Corrigindo bug de click em um componente mask em um painel
        }

        private void resetaForm()
        {
            // Reseta o formulário e o cdg do endereço
            cdgEnderecoCadastrado = 0;
            limpaDadosCli();
            formEnabled(false);
            btnTelaEndereco.Enabled = true;
            telaEndereco = new CadastroEndereco();
        }
    }
}
