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
    public partial class CadastroCliente : Form
    {
        Banco banco = new Banco();

        CadastroEndereco telaEndereco;
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
            // Valida campos
            if (!validaCampos()) //  Se falso, retorne
                return;

            int cdgUsuario = LoginTela.cdgUsuarioConectado;
            int cdgEnderecoCli = telaEndereco.cdgEnderecoCadastrado;
            if (cdgEnderecoCli != 0)
            {
                string strInsert = $"INSERT INTO CLIENTE (nm_cliente, nm_sobrenome, dt_nasc, cdg_loginFunc, cdg_endereco) VALUES ('{txtBoxNomeCli.Text}', '{txtBoxSobrenomeCli.Text}', STR_TO_DATE('{maskTxtBoxDtNasc.Text}', '%d/%m/%Y'), {LoginTela.cdgUsuarioConectado}, {telaEndereco.cdgEnderecoCadastrado});";
                bool resultInsert = banco.ExecuteNonQuery(strInsert);
                if(resultInsert)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetaForm();
                }
                else
                {
                    Util.exibeErro("Ocorreu um erro, verifique os dados e tente novamente!");
                    string strDelete = $"DELETE FROM ENDERECO WHERE cdg_endereco = {cdgEnderecoCli}"; // Apaga endereço criado caso o registro do cliente não seja concluído
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
            if(txtBoxNomeCli.Text.Length == 0)
            {
                Util.exibeErro("O campo nome não pode estar vazio!");
                return false;
            }
            if (txtBoxSobrenomeCli.Text.Length == 0)
            {
                Util.exibeErro("O campo sobrenome não pode estar vazio!");
                return false;
            }
            if(!maskTxtBoxDtNasc.MaskCompleted)
            {
                Util.exibeErro("O campo data não pode estar vazio!");
                return false;
            }
            

            return true;
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
            telaEndereco.cdgEnderecoCadastrado = 0;
            limpaDadosCli();
            formEnabled(false);
            btnTelaEndereco.Enabled = true;
        }
    }
}
