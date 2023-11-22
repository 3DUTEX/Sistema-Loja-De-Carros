namespace SistemaLojaDeCarros
{
    partial class ConsultarVeiculo
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
            this.txtPesqId = new System.Windows.Forms.TextBox();
            this.lblPesqModelo = new System.Windows.Forms.Label();
            this.txtPesqModelo = new System.Windows.Forms.TextBox();
            this.lblPesqPlaca = new System.Windows.Forms.Label();
            this.txtPesqPlaca = new System.Windows.Forms.TextBox();
            this.dtGridVeiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarCli
            // 
            this.lblConsultarCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarCli.AutoSize = true;
            this.lblConsultarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarCli.Location = new System.Drawing.Point(398, 25);
            this.lblConsultarCli.Name = "lblConsultarCli";
            this.lblConsultarCli.Size = new System.Drawing.Size(158, 24);
            this.lblConsultarCli.TabIndex = 4;
            this.lblConsultarCli.Text = "Consultar Veículo";
            // 
            // lblPesqId
            // 
            this.lblPesqId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesqId.AutoSize = true;
            this.lblPesqId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqId.Location = new System.Drawing.Point(379, 97);
            this.lblPesqId.Name = "lblPesqId";
            this.lblPesqId.Size = new System.Drawing.Size(128, 20);
            this.lblPesqId.TabIndex = 5;
            this.lblPesqId.Text = "Pesquisar por Id:";
            // 
            // txtPesqId
            // 
            this.txtPesqId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqId.Location = new System.Drawing.Point(513, 90);
            this.txtPesqId.Name = "txtPesqId";
            this.txtPesqId.Size = new System.Drawing.Size(47, 31);
            this.txtPesqId.TabIndex = 9;
            this.txtPesqId.TextChanged += new System.EventHandler(this.txtPesqId_TextChanged);
            // 
            // lblPesqModelo
            // 
            this.lblPesqModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesqModelo.AutoSize = true;
            this.lblPesqModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqModelo.Location = new System.Drawing.Point(183, 152);
            this.lblPesqModelo.Name = "lblPesqModelo";
            this.lblPesqModelo.Size = new System.Drawing.Size(65, 20);
            this.lblPesqModelo.TabIndex = 10;
            this.lblPesqModelo.Text = "Modelo:";
            // 
            // txtPesqModelo
            // 
            this.txtPesqModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqModelo.Location = new System.Drawing.Point(254, 145);
            this.txtPesqModelo.Name = "txtPesqModelo";
            this.txtPesqModelo.Size = new System.Drawing.Size(175, 31);
            this.txtPesqModelo.TabIndex = 11;
            // 
            // lblPesqPlaca
            // 
            this.lblPesqPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesqPlaca.AutoSize = true;
            this.lblPesqPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqPlaca.Location = new System.Drawing.Point(504, 152);
            this.lblPesqPlaca.Name = "lblPesqPlaca";
            this.lblPesqPlaca.Size = new System.Drawing.Size(52, 20);
            this.lblPesqPlaca.TabIndex = 12;
            this.lblPesqPlaca.Text = "Placa:";
            // 
            // txtPesqPlaca
            // 
            this.txtPesqPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqPlaca.Location = new System.Drawing.Point(562, 145);
            this.txtPesqPlaca.Name = "txtPesqPlaca";
            this.txtPesqPlaca.Size = new System.Drawing.Size(175, 31);
            this.txtPesqPlaca.TabIndex = 13;
            this.txtPesqPlaca.TextChanged += new System.EventHandler(this.txtPesqPlaca_TextChanged);
            // 
            // dtGridVeiculos
            // 
            this.dtGridVeiculos.AllowUserToAddRows = false;
            this.dtGridVeiculos.AllowUserToDeleteRows = false;
            this.dtGridVeiculos.AllowUserToResizeColumns = false;
            this.dtGridVeiculos.AllowUserToResizeRows = false;
            this.dtGridVeiculos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVeiculos.Location = new System.Drawing.Point(152, 238);
            this.dtGridVeiculos.Name = "dtGridVeiculos";
            this.dtGridVeiculos.ReadOnly = true;
            this.dtGridVeiculos.Size = new System.Drawing.Size(641, 150);
            this.dtGridVeiculos.TabIndex = 14;
            // 
            // ConsultarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 422);
            this.Controls.Add(this.dtGridVeiculos);
            this.Controls.Add(this.txtPesqPlaca);
            this.Controls.Add(this.lblPesqPlaca);
            this.Controls.Add(this.txtPesqModelo);
            this.Controls.Add(this.lblPesqModelo);
            this.Controls.Add(this.txtPesqId);
            this.Controls.Add(this.lblPesqId);
            this.Controls.Add(this.lblConsultarCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarVeiculo";
            this.Text = "ConsultarVeiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConsultarCli;
        private System.Windows.Forms.Label lblPesqId;
        private System.Windows.Forms.TextBox txtPesqId;
        private System.Windows.Forms.Label lblPesqModelo;
        private System.Windows.Forms.TextBox txtPesqModelo;
        private System.Windows.Forms.Label lblPesqPlaca;
        private System.Windows.Forms.TextBox txtPesqPlaca;
        private System.Windows.Forms.DataGridView dtGridVeiculos;
    }
}