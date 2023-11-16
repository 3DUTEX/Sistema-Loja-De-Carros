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
    public partial class DetalhesCliente : Form
    {
        private string nome, sobrenome, logradouro, num, complemento, bairro, cidade, usuario, dtNasc;

        private bool alterou = false;

        private void lblNome_DoubleClick(object sender, EventArgs e)
        {
            ativaTxtBox(txtBoxNome, lblNome, nome);
        }

        private void txtBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validaTxtBox(txtBoxNome, null, "nome", e))
                editaTxtBox(ref nome, txtBoxNome, lblNome, e);
        }
        private void lblSobrenome_DoubleClick(object sender, EventArgs e)
        {
            ativaTxtBox(txtBoxSobren, lblSobrenome, sobrenome);
        }

        private void txtBoxSobren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validaTxtBox(txtBoxSobren, null, "sobrenome", e))
                editaTxtBox(ref sobrenome, txtBoxSobren, lblSobrenome, e);
        }

        private void lblDataNasc_DoubleClick(object sender, EventArgs e)
        {
            lblDataNasc.Visible = false;
            maskTxtDtNasc.Visible = true;
            maskTxtDtNasc.Text = dtNasc;
            maskTxtDtNasc.Focus();
        }
        private void maskTxtDtNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validaTxtBox(null, maskTxtDtNasc, "data de nascimento", e))
            {
                if (e.KeyChar == (char)13)
                {

                    if (maskTxtDtNasc.Text != dtNasc) // Verifica se foi alterado
                        alterou = true;

                    if (alterou) // Se alterou, coloca o novo valor na variável
                        dtNasc = maskTxtDtNasc.Text;

                    maskTxtDtNasc.Visible = false;
                    lblDataNasc.Visible = true;
                    lblDataNasc.Text = dtNasc;
                }
            }
        }

        private void lblLogradouro_DoubleClick(object sender, EventArgs e)
        {
            ativaTxtBox(txtBoxLog, lblLogradouro, logradouro);
        }
        private void txtBoxLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validaTxtBox(txtBoxLog, null, "logradouro", e))
                editaTxtBox(ref logradouro, txtBoxLog, lblLogradouro, e);
        }

        private void lblNum_DoubleClick(object sender, EventArgs e)
        {
            ativaTxtBox(txtBoxNum, lblNum, num);
        }

        private void txtBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validaTxtBox(txtBoxNum, null, "número", e))
            {
                if (e.KeyChar == (char)13)
                {
                    bool isNum = int.TryParse(txtBoxNum.Text, out int numConvertido);
                    if (!isNum)
                    {
                        Util.exibeErro("O número da casa precisa ser um número inteiro!");
                        return;
                    }
                    editaTxtBox(ref num, txtBoxNum, lblNum, e);
                }
            }

        }

        private void lblBairro_DoubleClick(object sender, EventArgs e)
        {
            ativaTxtBox(txtBoxBairro, lblBairro, bairro);
        }

        private void txtBoxBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validaTxtBox(txtBoxBairro, null, "bairro", e))
                editaTxtBox(ref bairro, txtBoxBairro, lblBairro, e);
        }

        private void lblCidade_DoubleClick(object sender, EventArgs e)
        {
            ativaTxtBox(txtBoxCidade, lblCidade, cidade);
        }

        private void txtBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validaTxtBox(txtBoxCidade, null, "cidade", e))
                editaTxtBox(ref cidade, txtBoxCidade, lblCidade, e);
        }

        private void lblComplemento_DoubleClick(object sender, EventArgs e)
        {
            ativaTxtBox(txtBoxComple, lblComplemento, complemento);
        }

        private void txtBoxComple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (txtBoxComple.Text.Length == 0)
                {
                    voltaLabel(txtBoxComple, lblComplemento, "Não informado");
                }else
                    editaTxtBox(ref complemento, txtBoxComple, lblComplemento, e);
            }
        }

        Banco banco = new Banco();

        public DetalhesCliente()
        {
            InitializeComponent();

            string strSelect = $"SELECT * FROM vw_dadosCli WHERE cdg_cliente = {ConsultarCliente.cdgClienteClicado}";

            using (MySqlDataReader reader = banco.select(strSelect))
            {
                while (reader.Read())
                {
                    nome = reader["nm_cliente"].ToString();
                    sobrenome = reader["nm_sobrenome"].ToString();

                    dtNasc = (reader["dt_nasc"].ToString());
                    string[] dtNascSplit = dtNasc.Split(' ');
                    dtNasc = dtNascSplit[0]; // Pegando somente a data, sem o tempo

                    logradouro = reader["nm_logradouro"].ToString();
                    num = reader["no_casa"].ToString();
                    complemento = reader["ds_complemento"].ToString();
                    bairro = reader["nm_bairro"].ToString();
                    cidade = reader["nm_cidade"].ToString();
                    usuario = reader["nm_usuario"].ToString();
                }

                reader.Close();
            }



            lblNome.Text = nome;
            lblSobrenome.Text = sobrenome;
            lblDataNasc.Text = dtNasc;
            lblLogradouro.Text = logradouro;
            lblComplemento.Text = complemento != "" ? complemento : "Não Informado";
            lblNum.Text = num;
            lblBairro.Text = bairro;
            lblCadaPor.Text = usuario;
        }

        private bool validaTxtBox(TextBox txtBox, MaskedTextBox maskTxtBox, string nomeCampo, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtBox != null)
                {
                    if (txtBox.Text.Length == 0)
                    {
                        Util.exibeErro($"O campo {nomeCampo} não pode estar vazio!");
                        return false;
                    }
                }
                if (maskTxtBox != null)
                {
                    if (!maskTxtBox.MaskCompleted)
                    {
                        Util.exibeErro($"O campo {nomeCampo} precisa estar completo!");
                        return false;
                    }
                }
            }

            return true;
        }

        private void editaTxtBox(ref string var, TextBox txtBox, Label lbl, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Tecla ENTER pressionada?
            {

                if (txtBox.Text != var) // Verifica se foi alterado
                    alterou = true;

                if (alterou) // Se alterou, coloca o novo valor na variável
                    var = txtBox.Text;

                voltaLabel(txtBox, lbl, var);
            }
        }
        private void voltaLabel(TextBox txtBox, Label lbl, string var)
        {
            txtBox.Visible = false;
            lbl.Visible = true;
            lbl.Text = var;
        }

        private void ativaTxtBox(TextBox txtBox, Label lbl, string texto)
        {
            lbl.Visible = false;
            txtBox.Visible = true;
            txtBox.Text = texto;
            txtBox.Focus();

        }

        private bool verificaTxtBoxAberto()
        {
            if(txtBoxNome.Visible)
                return false;
            if(txtBoxSobren.Visible)
                return false;
            if(maskTxtDtNasc.Visible)
                return false;
            if(txtBoxLog.Visible)
                return false;
            if(txtBoxComple.Visible)
                return false;
            if(txtBoxNum.Visible)
                return false;
            if(txtBoxBairro.Visible)
                return false;
            if (txtBoxCidade.Visible)
                return false;

            return true;
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja apagar esse cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string cdgEnderecoCliente = banco.ExecuteScalar($"SELECT cdg_endereco FROM cliente WHERE cdg_cliente = {ConsultarCliente.cdgClienteClicado}");
                string strDeleteCliente = $"DELETE FROM cliente WHERE cdg_cliente = {ConsultarCliente.cdgClienteClicado}";
                bool deleteCliente = banco.ExecuteNonQuery(strDeleteCliente);
                if (deleteCliente)
                {
                    string strDeleteEndereco = $"DELETE FROM endereco WHERE cdg_endereco = {cdgEnderecoCliente}";
                    bool deleteEndereco = banco.ExecuteNonQuery(strDeleteEndereco);
                    if (deleteEndereco)
                        MessageBox.Show("Cliente deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!verificaTxtBoxAberto())
            {
                Util.exibeErro("Feche todos os campos de texto (pressione Enter dentro deles)");
                return;
            }
            if (alterou)
            {
                string cdgEnderecoCliente = banco.ExecuteScalar($"SELECT cdg_endereco FROM cliente WHERE cdg_cliente = {ConsultarCliente.cdgClienteClicado}");
                if (cdgEnderecoCliente != "")
                {
                    string strUpdateEndereco = $"UPDATE endereco SET nm_logradouro = '{logradouro}', no_casa = '{num}', ds_complemento = '{complemento}', nm_bairro = '{bairro}', nm_cidade = '{cidade}' WHERE cdg_endereco = {cdgEnderecoCliente}";
                    banco.ExecuteNonQuery(strUpdateEndereco);
                }

                string strUpdateCliente = $"UPDATE cliente SET nm_cliente = '{nome}', nm_sobrenome = '{sobrenome}', dt_nasc = STR_TO_DATE('{dtNasc}', '%d/%m/%Y') WHERE cdg_cliente = {ConsultarCliente.cdgClienteClicado}";
                bool resultUpdate = banco.ExecuteNonQuery(strUpdateCliente);

                if (resultUpdate)
                    MessageBox.Show("Cliente alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Altere algum campo para atualizar um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
