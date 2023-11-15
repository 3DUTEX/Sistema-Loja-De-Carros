﻿using MySql.Data.MySqlClient;
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
        private string nome, sobrenome, logradouro, num, bairro, cidade, usuario, dtNasc;

        private bool alterou = false;

        private void lblSobrenome_DoubleClick(object sender, EventArgs e)
        {
            ativaTxtBox(txtBoxSobren, lblSobrenome, sobrenome);
        }

        private void txtBoxSobren_KeyPress(object sender, KeyPressEventArgs e)
        {
            editaTxtBox(ref sobrenome, txtBoxSobren, lblSobrenome, e);
        }
        private void lblNome_DoubleClick(object sender, EventArgs e)
        {
            ativaTxtBox(txtBoxNome, lblNome, nome);
        }

        private void txtBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            editaTxtBox(ref nome, txtBoxNome, lblNome, e);
        }

        Banco banco = new Banco();
        public DetalhesCliente()
        {
            InitializeComponent();

            string strSelect = $"SELECT * FROM vw_dadosCli WHERE cdg_cliente = {ConsultarCliente.cdgClienteClicado}";

            using (MySqlDataReader reader = banco.select(strSelect))
            {
                while(reader.Read())
                {
                    nome = reader["nm_cliente"].ToString();
                    sobrenome = reader["nm_sobrenome"].ToString();
                    dtNasc = (reader["dt_nasc"].ToString());
                    logradouro = reader["nm_logradouro"].ToString();
                    num = reader["no_casa"].ToString();
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
            lblNum.Text = num;
            lblBairro.Text = bairro;
            lblCadaPor.Text = usuario;
        }

        private void editaTxtBox(ref string var, TextBox txtBox, Label lbl, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
