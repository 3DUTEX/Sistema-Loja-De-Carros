﻿namespace SistemaLojaDeCarros
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblConsultarCli = new System.Windows.Forms.Label();
            this.lblPesqId = new System.Windows.Forms.Label();
            this.lblPesqName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar Veiculo";
            // 
            // lblConsultarCli
            // 
            this.lblConsultarCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultarCli.AutoSize = true;
            this.lblConsultarCli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarCli.Location = new System.Drawing.Point(299, 34);
            this.lblConsultarCli.Name = "lblConsultarCli";
            this.lblConsultarCli.Size = new System.Drawing.Size(170, 22);
            this.lblConsultarCli.TabIndex = 4;
            this.lblConsultarCli.Text = "Consultar Veículo";
            // 
            // lblPesqId
            // 
            this.lblPesqId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesqId.AutoSize = true;
            this.lblPesqId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqId.Location = new System.Drawing.Point(267, 144);
            this.lblPesqId.Name = "lblPesqId";
            this.lblPesqId.Size = new System.Drawing.Size(143, 18);
            this.lblPesqId.TabIndex = 5;
            this.lblPesqId.Text = "Pesquisar por Id:";
            // 
            // lblPesqName
            // 
            this.lblPesqName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesqName.AutoSize = true;
            this.lblPesqName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqName.Location = new System.Drawing.Point(227, 215);
            this.lblPesqName.Name = "lblPesqName";
            this.lblPesqName.Size = new System.Drawing.Size(172, 18);
            this.lblPesqName.TabIndex = 6;
            this.lblPesqName.Text = "Pesquisar por nome:";
            // 
            // ConsultarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPesqName);
            this.Controls.Add(this.lblPesqId);
            this.Controls.Add(this.lblConsultarCli);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarVeiculo";
            this.Text = "ConsultarVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConsultarCli;
        private System.Windows.Forms.Label lblPesqId;
        private System.Windows.Forms.Label lblPesqName;
    }
}