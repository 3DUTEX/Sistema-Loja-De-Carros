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
            this.txtPesqSobrenome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarCli
            // 
            this.lblConsultarCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarCli.AutoSize = true;
            this.lblConsultarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarCli.Location = new System.Drawing.Point(413, 31);
            this.lblConsultarCli.Name = "lblConsultarCli";
            this.lblConsultarCli.Size = new System.Drawing.Size(152, 24);
            this.lblConsultarCli.TabIndex = 3;
            this.lblConsultarCli.Text = "Consultar Cliente";
            // 
            // lblPesqId
            // 
            this.lblPesqId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesqId.AutoSize = true;
            this.lblPesqId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqId.Location = new System.Drawing.Point(424, 97);
            this.lblPesqId.Name = "lblPesqId";
            this.lblPesqId.Size = new System.Drawing.Size(128, 20);
            this.lblPesqId.TabIndex = 4;
            this.lblPesqId.Text = "Pesquisar por Id:";
            // 
            // lblPesqName
            // 
            this.lblPesqName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesqName.AutoSize = true;
            this.lblPesqName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqName.Location = new System.Drawing.Point(242, 152);
            this.lblPesqName.Name = "lblPesqName";
            this.lblPesqName.Size = new System.Drawing.Size(55, 20);
            this.lblPesqName.TabIndex = 5;
            this.lblPesqName.Text = "Nome:";
            // 
            // txtPesqName
            // 
            this.txtPesqName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqName.Location = new System.Drawing.Point(303, 145);
            this.txtPesqName.Name = "txtPesqName";
            this.txtPesqName.Size = new System.Drawing.Size(175, 31);
            this.txtPesqName.TabIndex = 7;
            this.txtPesqName.TextChanged += new System.EventHandler(this.txtPesqName_TextChanged);
            // 
            // txtPesqId
            // 
            this.txtPesqId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqId.Location = new System.Drawing.Point(573, 90);
            this.txtPesqId.Name = "txtPesqId";
            this.txtPesqId.Size = new System.Drawing.Size(47, 31);
            this.txtPesqId.TabIndex = 8;
            this.txtPesqId.TextChanged += new System.EventHandler(this.txtPesqId_TextChanged);
            // 
            // dtGridClientes
            // 
            this.dtGridClientes.AllowUserToAddRows = false;
            this.dtGridClientes.AllowUserToDeleteRows = false;
            this.dtGridClientes.AllowUserToResizeColumns = false;
            this.dtGridClientes.AllowUserToResizeRows = false;
            this.dtGridClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridClientes.Location = new System.Drawing.Point(186, 233);
            this.dtGridClientes.Name = "dtGridClientes";
            this.dtGridClientes.ReadOnly = true;
            this.dtGridClientes.Size = new System.Drawing.Size(641, 150);
            this.dtGridClientes.TabIndex = 9;
            this.dtGridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridClientes_CellDoubleClick);
            // 
            // txtPesqSobrenome
            // 
            this.txtPesqSobrenome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqSobrenome.Location = new System.Drawing.Point(588, 145);
            this.txtPesqSobrenome.Name = "txtPesqSobrenome";
            this.txtPesqSobrenome.Size = new System.Drawing.Size(175, 31);
            this.txtPesqSobrenome.TabIndex = 11;
            this.txtPesqSobrenome.TextChanged += new System.EventHandler(this.txtPesqSobrenome_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sobrenome:";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 422);
            this.Controls.Add(this.txtPesqSobrenome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridClientes);
            this.Controls.Add(this.txtPesqId);
            this.Controls.Add(this.txtPesqName);
            this.Controls.Add(this.lblPesqName);
            this.Controls.Add(this.lblPesqId);
            this.Controls.Add(this.lblConsultarCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox txtPesqSobrenome;
        private System.Windows.Forms.Label label1;
    }
}