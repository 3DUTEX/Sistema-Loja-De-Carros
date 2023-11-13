namespace SistemaLojaDeCarros
{
    partial class ExcluirCliente
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
            this.lblExcluirCli = new System.Windows.Forms.Label();
            this.lblExclPorId = new System.Windows.Forms.Label();
            this.lblExclPorNome = new System.Windows.Forms.Label();
            this.txtPesqId = new System.Windows.Forms.TextBox();
            this.txtPesqName = new System.Windows.Forms.TextBox();
            this.dtGridClientes = new System.Windows.Forms.DataGridView();
            this.btnPesqCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExcluirCli
            // 
            this.lblExcluirCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExcluirCli.AutoSize = true;
            this.lblExcluirCli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluirCli.Location = new System.Drawing.Point(318, 31);
            this.lblExcluirCli.Name = "lblExcluirCli";
            this.lblExcluirCli.Size = new System.Drawing.Size(142, 22);
            this.lblExcluirCli.TabIndex = 3;
            this.lblExcluirCli.Text = "Excluir Cliente";
            // 
            // lblExclPorId
            // 
            this.lblExclPorId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExclPorId.AutoSize = true;
            this.lblExclPorId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExclPorId.Location = new System.Drawing.Point(173, 115);
            this.lblExclPorId.Name = "lblExclPorId";
            this.lblExclPorId.Size = new System.Drawing.Size(143, 18);
            this.lblExclPorId.TabIndex = 5;
            this.lblExclPorId.Text = "Pesquisar por Id:";
            // 
            // lblExclPorNome
            // 
            this.lblExclPorNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExclPorNome.AutoSize = true;
            this.lblExclPorNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExclPorNome.Location = new System.Drawing.Point(144, 169);
            this.lblExclPorNome.Name = "lblExclPorNome";
            this.lblExclPorNome.Size = new System.Drawing.Size(172, 18);
            this.lblExclPorNome.TabIndex = 6;
            this.lblExclPorNome.Text = "Pesquisar por nome:";
            // 
            // txtPesqId
            // 
            this.txtPesqId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqId.Location = new System.Drawing.Point(322, 116);
            this.txtPesqId.Name = "txtPesqId";
            this.txtPesqId.Size = new System.Drawing.Size(100, 20);
            this.txtPesqId.TabIndex = 9;
            // 
            // txtPesqName
            // 
            this.txtPesqName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqName.Location = new System.Drawing.Point(322, 170);
            this.txtPesqName.Name = "txtPesqName";
            this.txtPesqName.Size = new System.Drawing.Size(175, 20);
            this.txtPesqName.TabIndex = 10;
            // 
            // dtGridClientes
            // 
            this.dtGridClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridClientes.Location = new System.Drawing.Point(107, 233);
            this.dtGridClientes.Name = "dtGridClientes";
            this.dtGridClientes.Size = new System.Drawing.Size(579, 150);
            this.dtGridClientes.TabIndex = 11;
            // 
            // btnPesqCliente
            // 
            this.btnPesqCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqCliente.Location = new System.Drawing.Point(346, 406);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(100, 32);
            this.btnPesqCliente.TabIndex = 12;
            this.btnPesqCliente.Text = "Pesquisar";
            this.btnPesqCliente.UseVisualStyleBackColor = true;
            // 
            // ExcluirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesqCliente);
            this.Controls.Add(this.dtGridClientes);
            this.Controls.Add(this.txtPesqName);
            this.Controls.Add(this.txtPesqId);
            this.Controls.Add(this.lblExclPorNome);
            this.Controls.Add(this.lblExclPorId);
            this.Controls.Add(this.lblExcluirCli);
            this.Name = "ExcluirCliente";
            this.Text = "ExcluirCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExcluirCli;
        private System.Windows.Forms.Label lblExclPorId;
        private System.Windows.Forms.Label lblExclPorNome;
        private System.Windows.Forms.TextBox txtPesqId;
        private System.Windows.Forms.TextBox txtPesqName;
        private System.Windows.Forms.DataGridView dtGridClientes;
        private System.Windows.Forms.Button btnPesqCliente;
    }
}