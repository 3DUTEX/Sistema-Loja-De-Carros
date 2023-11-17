namespace SistemaLojaDeCarros
{
    partial class MenuTela
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxSair = new System.Windows.Forms.PictureBox();
            this.pictureSeta2 = new System.Windows.Forms.PictureBox();
            this.pictureSeta = new System.Windows.Forms.PictureBox();
            this.btSair = new System.Windows.Forms.Button();
            this.panelSubVeiculo = new System.Windows.Forms.Panel();
            this.btConsultarVeiculo = new System.Windows.Forms.Button();
            this.btCadastrarVeiculo = new System.Windows.Forms.Button();
            this.btVeiculo = new System.Windows.Forms.Button();
            this.panelSubCliente = new System.Windows.Forms.Panel();
            this.btConsultarCliente = new System.Windows.Forms.Button();
            this.btCadastrarCli = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelExibir = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSeta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSeta)).BeginInit();
            this.panelSubVeiculo.SuspendLayout();
            this.panelSubCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMenu.Controls.Add(this.pictureBoxSair);
            this.panelMenu.Controls.Add(this.pictureSeta2);
            this.panelMenu.Controls.Add(this.pictureSeta);
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.panelSubVeiculo);
            this.panelMenu.Controls.Add(this.btVeiculo);
            this.panelMenu.Controls.Add(this.panelSubCliente);
            this.panelMenu.Controls.Add(this.btCliente);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 6;
            // 
            // pictureBoxSair
            // 
            this.pictureBoxSair.Image = global::SistemaLojaDeCarros.Properties.Resources.icons8_saída_de_emergência_50;
            this.pictureBoxSair.Location = new System.Drawing.Point(166, 419);
            this.pictureBoxSair.Name = "pictureBoxSair";
            this.pictureBoxSair.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSair.TabIndex = 8;
            this.pictureBoxSair.TabStop = false;
            this.pictureBoxSair.Click += new System.EventHandler(this.pictureBoxSair_Click);
            // 
            // pictureSeta2
            // 
            this.pictureSeta2.Image = global::SistemaLojaDeCarros.Properties.Resources.icons8_voltar_30;
            this.pictureSeta2.Location = new System.Drawing.Point(168, 221);
            this.pictureSeta2.Name = "pictureSeta2";
            this.pictureSeta2.Size = new System.Drawing.Size(17, 16);
            this.pictureSeta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSeta2.TabIndex = 7;
            this.pictureSeta2.TabStop = false;
            // 
            // pictureSeta
            // 
            this.pictureSeta.Image = global::SistemaLojaDeCarros.Properties.Resources.icons8_voltar_30;
            this.pictureSeta.Location = new System.Drawing.Point(168, 99);
            this.pictureSeta.Name = "pictureSeta";
            this.pictureSeta.Size = new System.Drawing.Size(17, 16);
            this.pictureSeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSeta.TabIndex = 6;
            this.pictureSeta.TabStop = false;
            this.pictureSeta.Click += new System.EventHandler(this.pictureSeta_Click);
            // 
            // btSair
            // 
            this.btSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(0, 410);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(200, 40);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panelSubVeiculo
            // 
            this.panelSubVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelSubVeiculo.Controls.Add(this.btConsultarVeiculo);
            this.panelSubVeiculo.Controls.Add(this.btCadastrarVeiculo);
            this.panelSubVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubVeiculo.Location = new System.Drawing.Point(0, 248);
            this.panelSubVeiculo.Name = "panelSubVeiculo";
            this.panelSubVeiculo.Size = new System.Drawing.Size(200, 81);
            this.panelSubVeiculo.TabIndex = 4;
            // 
            // btConsultarVeiculo
            // 
            this.btConsultarVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btConsultarVeiculo.FlatAppearance.BorderSize = 0;
            this.btConsultarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarVeiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarVeiculo.ForeColor = System.Drawing.Color.White;
            this.btConsultarVeiculo.Location = new System.Drawing.Point(0, 40);
            this.btConsultarVeiculo.Name = "btConsultarVeiculo";
            this.btConsultarVeiculo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btConsultarVeiculo.Size = new System.Drawing.Size(200, 40);
            this.btConsultarVeiculo.TabIndex = 1;
            this.btConsultarVeiculo.Text = "Consultar Veículo";
            this.btConsultarVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultarVeiculo.UseVisualStyleBackColor = true;
            this.btConsultarVeiculo.Click += new System.EventHandler(this.btConsultarVeiculo_Click);
            // 
            // btCadastrarVeiculo
            // 
            this.btCadastrarVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadastrarVeiculo.FlatAppearance.BorderSize = 0;
            this.btCadastrarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarVeiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVeiculo.ForeColor = System.Drawing.Color.White;
            this.btCadastrarVeiculo.Location = new System.Drawing.Point(0, 0);
            this.btCadastrarVeiculo.Name = "btCadastrarVeiculo";
            this.btCadastrarVeiculo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btCadastrarVeiculo.Size = new System.Drawing.Size(200, 40);
            this.btCadastrarVeiculo.TabIndex = 0;
            this.btCadastrarVeiculo.Text = "Cadastrar Veículo";
            this.btCadastrarVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btCadastrarVeiculo.Click += new System.EventHandler(this.btCadastrarVeiculo_Click);
            // 
            // btVeiculo
            // 
            this.btVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVeiculo.FlatAppearance.BorderSize = 0;
            this.btVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVeiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVeiculo.ForeColor = System.Drawing.Color.White;
            this.btVeiculo.Location = new System.Drawing.Point(0, 208);
            this.btVeiculo.Name = "btVeiculo";
            this.btVeiculo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btVeiculo.Size = new System.Drawing.Size(200, 40);
            this.btVeiculo.TabIndex = 3;
            this.btVeiculo.Text = "Veículo";
            this.btVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVeiculo.UseVisualStyleBackColor = true;
            this.btVeiculo.Click += new System.EventHandler(this.btVeiculo_Click);
            // 
            // panelSubCliente
            // 
            this.panelSubCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelSubCliente.Controls.Add(this.btConsultarCliente);
            this.panelSubCliente.Controls.Add(this.btCadastrarCli);
            this.panelSubCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubCliente.Location = new System.Drawing.Point(0, 127);
            this.panelSubCliente.Name = "panelSubCliente";
            this.panelSubCliente.Size = new System.Drawing.Size(200, 81);
            this.panelSubCliente.TabIndex = 2;
            // 
            // btConsultarCliente
            // 
            this.btConsultarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btConsultarCliente.FlatAppearance.BorderSize = 0;
            this.btConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarCliente.ForeColor = System.Drawing.Color.White;
            this.btConsultarCliente.Location = new System.Drawing.Point(0, 40);
            this.btConsultarCliente.Name = "btConsultarCliente";
            this.btConsultarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btConsultarCliente.Size = new System.Drawing.Size(200, 40);
            this.btConsultarCliente.TabIndex = 1;
            this.btConsultarCliente.Text = "Consultar Cliente";
            this.btConsultarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultarCliente.UseVisualStyleBackColor = true;
            this.btConsultarCliente.Click += new System.EventHandler(this.btConsultarCliente_Click);
            // 
            // btCadastrarCli
            // 
            this.btCadastrarCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadastrarCli.FlatAppearance.BorderSize = 0;
            this.btCadastrarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarCli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCli.ForeColor = System.Drawing.Color.White;
            this.btCadastrarCli.Location = new System.Drawing.Point(0, 0);
            this.btCadastrarCli.Name = "btCadastrarCli";
            this.btCadastrarCli.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btCadastrarCli.Size = new System.Drawing.Size(200, 40);
            this.btCadastrarCli.TabIndex = 0;
            this.btCadastrarCli.Text = "Cadastrar Cliente";
            this.btCadastrarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarCli.UseVisualStyleBackColor = true;
            this.btCadastrarCli.Click += new System.EventHandler(this.btCadastrarCli_Click);
            // 
            // btCliente
            // 
            this.btCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.ForeColor = System.Drawing.Color.White;
            this.btCliente.Location = new System.Drawing.Point(0, 87);
            this.btCliente.Name = "btCliente";
            this.btCliente.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btCliente.Size = new System.Drawing.Size(200, 40);
            this.btCliente.TabIndex = 1;
            this.btCliente.Text = "Cliente";
            this.btCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 87);
            this.panelLogo.TabIndex = 0;
            // 
            // panelExibir
            // 
            this.panelExibir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExibir.Location = new System.Drawing.Point(200, 0);
            this.panelExibir.Name = "panelExibir";
            this.panelExibir.Size = new System.Drawing.Size(600, 450);
            this.panelExibir.TabIndex = 7;
            // 
            // MenuTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelExibir);
            this.Controls.Add(this.panelMenu);
            this.Name = "MenuTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSeta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSeta)).EndInit();
            this.panelSubVeiculo.ResumeLayout(false);
            this.panelSubCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSubCliente;
        private System.Windows.Forms.Button btCadastrarCli;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel panelSubVeiculo;
        private System.Windows.Forms.Button btCadastrarVeiculo;
        private System.Windows.Forms.Button btVeiculo;
        private System.Windows.Forms.Button btConsultarCliente;
        private System.Windows.Forms.Button btConsultarVeiculo;
        private System.Windows.Forms.PictureBox pictureSeta;
        private System.Windows.Forms.PictureBox pictureSeta2;
        private System.Windows.Forms.PictureBox pictureBoxSair;
        private System.Windows.Forms.Panel panelExibir;
    }
}