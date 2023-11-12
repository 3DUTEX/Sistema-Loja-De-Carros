namespace SistemaLojaDeCarros
{
    partial class Veiculo
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
            this.panelVeiculo = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExcluirVeiculo = new System.Windows.Forms.Button();
            this.btnConsultarVeiculo = new System.Windows.Forms.Button();
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.panelVeiculoCabecalio = new System.Windows.Forms.Panel();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.panelInfoVeiculo = new System.Windows.Forms.Panel();
            this.panelVeiculo.SuspendLayout();
            this.panelVeiculoCabecalio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVeiculo
            // 
            this.panelVeiculo.BackColor = System.Drawing.Color.Gray;
            this.panelVeiculo.Controls.Add(this.btnMenu);
            this.panelVeiculo.Controls.Add(this.btnExcluirVeiculo);
            this.panelVeiculo.Controls.Add(this.btnConsultarVeiculo);
            this.panelVeiculo.Controls.Add(this.btnCadVeiculo);
            this.panelVeiculo.Controls.Add(this.panelVeiculoCabecalio);
            this.panelVeiculo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVeiculo.Location = new System.Drawing.Point(0, 0);
            this.panelVeiculo.Name = "panelVeiculo";
            this.panelVeiculo.Size = new System.Drawing.Size(200, 450);
            this.panelVeiculo.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMenu.FlatAppearance.BorderSize = 3;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(0, 427);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 23);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Voltar ao Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExcluirVeiculo
            // 
            this.btnExcluirVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluirVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExcluirVeiculo.FlatAppearance.BorderSize = 3;
            this.btnExcluirVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVeiculo.Location = new System.Drawing.Point(0, 200);
            this.btnExcluirVeiculo.Name = "btnExcluirVeiculo";
            this.btnExcluirVeiculo.Size = new System.Drawing.Size(200, 50);
            this.btnExcluirVeiculo.TabIndex = 3;
            this.btnExcluirVeiculo.Text = "Excluir";
            this.btnExcluirVeiculo.UseVisualStyleBackColor = true;
            this.btnExcluirVeiculo.Click += new System.EventHandler(this.btnExcluirVeiculo_Click);
            // 
            // btnConsultarVeiculo
            // 
            this.btnConsultarVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConsultarVeiculo.FlatAppearance.BorderSize = 3;
            this.btnConsultarVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVeiculo.Location = new System.Drawing.Point(0, 150);
            this.btnConsultarVeiculo.Name = "btnConsultarVeiculo";
            this.btnConsultarVeiculo.Size = new System.Drawing.Size(200, 50);
            this.btnConsultarVeiculo.TabIndex = 2;
            this.btnConsultarVeiculo.Text = "Consultar";
            this.btnConsultarVeiculo.UseVisualStyleBackColor = true;
            this.btnConsultarVeiculo.Click += new System.EventHandler(this.btnConsultarVeiculo_Click);
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCadVeiculo.FlatAppearance.BorderSize = 3;
            this.btnCadVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVeiculo.Location = new System.Drawing.Point(0, 100);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(200, 50);
            this.btnCadVeiculo.TabIndex = 1;
            this.btnCadVeiculo.Text = "Cadastrar";
            this.btnCadVeiculo.UseVisualStyleBackColor = true;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // panelVeiculoCabecalio
            // 
            this.panelVeiculoCabecalio.BackColor = System.Drawing.Color.DimGray;
            this.panelVeiculoCabecalio.Controls.Add(this.lblVeiculo);
            this.panelVeiculoCabecalio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVeiculoCabecalio.Location = new System.Drawing.Point(0, 0);
            this.panelVeiculoCabecalio.Name = "panelVeiculoCabecalio";
            this.panelVeiculoCabecalio.Size = new System.Drawing.Size(200, 100);
            this.panelVeiculoCabecalio.TabIndex = 0;
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(23, 39);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(155, 24);
            this.lblVeiculo.TabIndex = 0;
            this.lblVeiculo.Text = "Área do Veículo";
            // 
            // panelInfoVeiculo
            // 
            this.panelInfoVeiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoVeiculo.Location = new System.Drawing.Point(200, 0);
            this.panelInfoVeiculo.Name = "panelInfoVeiculo";
            this.panelInfoVeiculo.Size = new System.Drawing.Size(600, 450);
            this.panelInfoVeiculo.TabIndex = 1;
            // 
            // Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInfoVeiculo);
            this.Controls.Add(this.panelVeiculo);
            this.Name = "Veiculo";
            this.Text = "Veiculo";
            this.panelVeiculo.ResumeLayout(false);
            this.panelVeiculoCabecalio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVeiculo;
        private System.Windows.Forms.Panel panelVeiculoCabecalio;
        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.Button btnExcluirVeiculo;
        private System.Windows.Forms.Button btnConsultarVeiculo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelInfoVeiculo;
    }
}