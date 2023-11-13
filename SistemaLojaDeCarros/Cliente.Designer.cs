namespace SistemaLojaDeCarros
{
    partial class Cliente
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.panelClienteCabecalio = new System.Windows.Forms.Panel();
            this.panelInfoCliente = new System.Windows.Forms.Panel();
            this.panelCliente.SuspendLayout();
            this.panelClienteCabecalio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(23, 39);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(140, 24);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Área do Cliente";
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.Gray;
            this.panelCliente.Controls.Add(this.btnMenu);
            this.panelCliente.Controls.Add(this.btnExcluirCliente);
            this.panelCliente.Controls.Add(this.btnConsultarCliente);
            this.panelCliente.Controls.Add(this.btnCadCliente);
            this.panelCliente.Controls.Add(this.panelClienteCabecalio);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCliente.Location = new System.Drawing.Point(0, 0);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(200, 450);
            this.panelCliente.TabIndex = 4;
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
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Voltar ao Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluirCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExcluirCliente.FlatAppearance.BorderSize = 3;
            this.btnExcluirCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCliente.Location = new System.Drawing.Point(0, 200);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(200, 50);
            this.btnExcluirCliente.TabIndex = 7;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConsultarCliente.FlatAppearance.BorderSize = 3;
            this.btnConsultarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.Location = new System.Drawing.Point(0, 150);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(200, 50);
            this.btnConsultarCliente.TabIndex = 6;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCadCliente.FlatAppearance.BorderSize = 3;
            this.btnCadCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCliente.Location = new System.Drawing.Point(0, 100);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(200, 50);
            this.btnCadCliente.TabIndex = 5;
            this.btnCadCliente.Text = "Cadastrar";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // panelClienteCabecalio
            // 
            this.panelClienteCabecalio.BackColor = System.Drawing.Color.DimGray;
            this.panelClienteCabecalio.Controls.Add(this.lblCliente);
            this.panelClienteCabecalio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClienteCabecalio.Location = new System.Drawing.Point(0, 0);
            this.panelClienteCabecalio.Name = "panelClienteCabecalio";
            this.panelClienteCabecalio.Size = new System.Drawing.Size(200, 100);
            this.panelClienteCabecalio.TabIndex = 0;
            // 
            // panelInfoCliente
            // 
            this.panelInfoCliente.CausesValidation = false;
            this.panelInfoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoCliente.Location = new System.Drawing.Point(200, 0);
            this.panelInfoCliente.Name = "panelInfoCliente";
            this.panelInfoCliente.Size = new System.Drawing.Size(600, 450);
            this.panelInfoCliente.TabIndex = 5;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInfoCliente);
            this.Controls.Add(this.panelCliente);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.panelCliente.ResumeLayout(false);
            this.panelClienteCabecalio.ResumeLayout(false);
            this.panelClienteCabecalio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Panel panelClienteCabecalio;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelInfoCliente;
    }
}