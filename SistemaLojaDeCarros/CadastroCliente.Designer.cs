namespace SistemaLojaDeCarros
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxNomeCli = new System.Windows.Forms.TextBox();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblSobrenomeCli = new System.Windows.Forms.Label();
            this.txtBoxSobrenomeCli = new System.Windows.Forms.TextBox();
            this.lblDtNascCli = new System.Windows.Forms.Label();
            this.btnCadaCliente = new System.Windows.Forms.Button();
            this.btnTelaEndereco = new System.Windows.Forms.Button();
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.maskTxtBoxDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtBoxNomeCli
            // 
            this.txtBoxNomeCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNomeCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxNomeCli.Enabled = false;
            this.txtBoxNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeCli.Location = new System.Drawing.Point(292, 253);
            this.txtBoxNomeCli.Name = "txtBoxNomeCli";
            this.txtBoxNomeCli.Size = new System.Drawing.Size(209, 31);
            this.txtBoxNomeCli.TabIndex = 0;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(212, 253);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(74, 25);
            this.lblNomeCli.TabIndex = 1;
            this.lblNomeCli.Text = "Nome:";
            // 
            // lblSobrenomeCli
            // 
            this.lblSobrenomeCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSobrenomeCli.AutoSize = true;
            this.lblSobrenomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenomeCli.Location = new System.Drawing.Point(158, 307);
            this.lblSobrenomeCli.Name = "lblSobrenomeCli";
            this.lblSobrenomeCli.Size = new System.Drawing.Size(128, 25);
            this.lblSobrenomeCli.TabIndex = 3;
            this.lblSobrenomeCli.Text = "Sobrenome:";
            // 
            // txtBoxSobrenomeCli
            // 
            this.txtBoxSobrenomeCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSobrenomeCli.Enabled = false;
            this.txtBoxSobrenomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSobrenomeCli.Location = new System.Drawing.Point(292, 301);
            this.txtBoxSobrenomeCli.Name = "txtBoxSobrenomeCli";
            this.txtBoxSobrenomeCli.Size = new System.Drawing.Size(209, 31);
            this.txtBoxSobrenomeCli.TabIndex = 2;
            // 
            // lblDtNascCli
            // 
            this.lblDtNascCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtNascCli.AutoSize = true;
            this.lblDtNascCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNascCli.Location = new System.Drawing.Point(74, 352);
            this.lblDtNascCli.Name = "lblDtNascCli";
            this.lblDtNascCli.Size = new System.Drawing.Size(212, 25);
            this.lblDtNascCli.TabIndex = 5;
            this.lblDtNascCli.Text = "Data de Nascimento:";
            // 
            // btnCadaCliente
            // 
            this.btnCadaCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadaCliente.Enabled = false;
            this.btnCadaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadaCliente.Location = new System.Drawing.Point(235, 457);
            this.btnCadaCliente.Name = "btnCadaCliente";
            this.btnCadaCliente.Size = new System.Drawing.Size(207, 60);
            this.btnCadaCliente.TabIndex = 12;
            this.btnCadaCliente.Text = "Cadastrar";
            this.btnCadaCliente.UseVisualStyleBackColor = true;
            this.btnCadaCliente.Click += new System.EventHandler(this.btnCadaCliente_Click);
            // 
            // btnTelaEndereco
            // 
            this.btnTelaEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTelaEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaEndereco.Location = new System.Drawing.Point(191, 133);
            this.btnTelaEndereco.Name = "btnTelaEndereco";
            this.btnTelaEndereco.Size = new System.Drawing.Size(310, 59);
            this.btnTelaEndereco.TabIndex = 13;
            this.btnTelaEndereco.Text = "Cadastrar Endereço";
            this.btnTelaEndereco.UseVisualStyleBackColor = true;
            this.btnTelaEndereco.Click += new System.EventHandler(this.btnTelaEndereco_Click);
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.Location = new System.Drawing.Point(186, 59);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(315, 25);
            this.lblTituloCliente.TabIndex = 14;
            this.lblTituloCliente.Text = "Insira as informações do cliente";
            // 
            // maskTxtBoxDtNasc
            // 
            this.maskTxtBoxDtNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxtBoxDtNasc.Enabled = false;
            this.maskTxtBoxDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtBoxDtNasc.Location = new System.Drawing.Point(292, 349);
            this.maskTxtBoxDtNasc.Mask = "00/00/0000";
            this.maskTxtBoxDtNasc.Name = "maskTxtBoxDtNasc";
            this.maskTxtBoxDtNasc.Size = new System.Drawing.Size(209, 31);
            this.maskTxtBoxDtNasc.TabIndex = 16;
            this.maskTxtBoxDtNasc.Click += new System.EventHandler(this.maskTxtBoxDtNasc_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 646);
            this.Controls.Add(this.maskTxtBoxDtNasc);
            this.Controls.Add(this.lblTituloCliente);
            this.Controls.Add(this.btnTelaEndereco);
            this.Controls.Add(this.btnCadaCliente);
            this.Controls.Add(this.lblDtNascCli);
            this.Controls.Add(this.lblSobrenomeCli);
            this.Controls.Add(this.txtBoxSobrenomeCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.txtBoxNomeCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNomeCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblSobrenomeCli;
        private System.Windows.Forms.TextBox txtBoxSobrenomeCli;
        private System.Windows.Forms.Label lblDtNascCli;
        private System.Windows.Forms.Button btnCadaCliente;
        private System.Windows.Forms.Button btnTelaEndereco;
        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.MaskedTextBox maskTxtBoxDtNasc;
    }
}