namespace SistemaLojaDeCarros
{
    partial class ConsultarCliente
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
            this.lblConsultarCli = new System.Windows.Forms.Label();
            this.lblPesqId = new System.Windows.Forms.Label();
            this.lblPesqName = new System.Windows.Forms.Label();
            this.txtPesqName = new System.Windows.Forms.TextBox();
            this.txtPesqId = new System.Windows.Forms.TextBox();
            this.dtGridClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarCli
            // 
            this.lblConsultarCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarCli.AutoSize = true;
            this.lblConsultarCli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarCli.Location = new System.Drawing.Point(318, 31);
            this.lblConsultarCli.Name = "lblConsultarCli";
            this.lblConsultarCli.Size = new System.Drawing.Size(167, 22);
            this.lblConsultarCli.TabIndex = 3;
            this.lblConsultarCli.Text = "Consultar Cliente";
            // 
            // lblPesqId
            // 
            this.lblPesqId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesqId.AutoSize = true;
            this.lblPesqId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqId.Location = new System.Drawing.Point(173, 115);
            this.lblPesqId.Name = "lblPesqId";
            this.lblPesqId.Size = new System.Drawing.Size(143, 18);
            this.lblPesqId.TabIndex = 4;
            this.lblPesqId.Text = "Pesquisar por Id:";
            // 
            // lblPesqName
            // 
            this.lblPesqName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesqName.AutoSize = true;
            this.lblPesqName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqName.Location = new System.Drawing.Point(144, 169);
            this.lblPesqName.Name = "lblPesqName";
            this.lblPesqName.Size = new System.Drawing.Size(172, 18);
            this.lblPesqName.TabIndex = 5;
            this.lblPesqName.Text = "Pesquisar por nome:";
            // 
            // txtPesqName
            // 
            this.txtPesqName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqName.Location = new System.Drawing.Point(322, 170);
            this.txtPesqName.Name = "txtPesqName";
            this.txtPesqName.Size = new System.Drawing.Size(175, 20);
            this.txtPesqName.TabIndex = 7;
            // 
            // txtPesqId
            // 
            this.txtPesqId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqId.Location = new System.Drawing.Point(322, 116);
            this.txtPesqId.Name = "txtPesqId";
            this.txtPesqId.Size = new System.Drawing.Size(100, 20);
            this.txtPesqId.TabIndex = 8;
            // 
            // dtGridClientes
            // 
            this.dtGridClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridClientes.Location = new System.Drawing.Point(107, 233);
            this.dtGridClientes.Name = "dtGridClientes";
            this.dtGridClientes.Size = new System.Drawing.Size(579, 150);
            this.dtGridClientes.TabIndex = 9;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 422);
            this.Controls.Add(this.dtGridClientes);
            this.Controls.Add(this.txtPesqId);
            this.Controls.Add(this.txtPesqName);
            this.Controls.Add(this.lblPesqName);
            this.Controls.Add(this.lblPesqId);
            this.Controls.Add(this.lblConsultarCli);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultarCli;
        private System.Windows.Forms.Label lblPesqId;
        private System.Windows.Forms.Label lblPesqName;
        private System.Windows.Forms.TextBox txtPesqName;
        private System.Windows.Forms.TextBox txtPesqId;
        private System.Windows.Forms.DataGridView dtGridClientes;
    }
}