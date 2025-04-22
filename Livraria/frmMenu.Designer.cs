namespace Livraria
{
    partial class frmMenu
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
            this.pneMenu = new System.Windows.Forms.Panel();
            this.lblusuarioLogado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnEditora = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnFone = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.pneLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnllogosa = new System.Windows.Forms.Panel();
            this.principal1 = new Livraria.principal();
            this.frmAtendente1 = new Livraria.frmAtendente();
            this.frmCliente1 = new Livraria.frmCliente();
            this.pneMenu.SuspendLayout();
            this.pneLogo.SuspendLayout();
            this.pnllogosa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pneMenu
            // 
            this.pneMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pneMenu.Controls.Add(this.lblusuarioLogado);
            this.pneMenu.Controls.Add(this.label2);
            this.pneMenu.Controls.Add(this.btnSair);
            this.pneMenu.Controls.Add(this.btnCaixa);
            this.pneMenu.Controls.Add(this.btnPedido);
            this.pneMenu.Controls.Add(this.btnAutor);
            this.pneMenu.Controls.Add(this.btnEditora);
            this.pneMenu.Controls.Add(this.btnCat);
            this.pneMenu.Controls.Add(this.btnLivro);
            this.pneMenu.Controls.Add(this.btnFone);
            this.pneMenu.Controls.Add(this.btnCliente);
            this.pneMenu.Controls.Add(this.btnFunc);
            this.pneMenu.Controls.Add(this.pneLogo);
            this.pneMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pneMenu.Location = new System.Drawing.Point(0, 0);
            this.pneMenu.Name = "pneMenu";
            this.pneMenu.Size = new System.Drawing.Size(220, 1033);
            this.pneMenu.TabIndex = 0;
            this.pneMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pneMenu_Paint);
            // 
            // lblusuarioLogado
            // 
            this.lblusuarioLogado.AutoSize = true;
            this.lblusuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuarioLogado.ForeColor = System.Drawing.Color.Yellow;
            this.lblusuarioLogado.Location = new System.Drawing.Point(23, 533);
            this.lblusuarioLogado.Name = "lblusuarioLogado";
            this.lblusuarioLogado.Size = new System.Drawing.Size(0, 25);
            this.lblusuarioLogado.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(23, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuário Logado:";
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Image = global::Livraria.Properties.Resources.desligar;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 451);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(220, 40);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaixa.Image = global::Livraria.Properties.Resources.caixa01;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(0, 411);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCaixa.Size = new System.Drawing.Size(220, 40);
            this.btnCaixa.TabIndex = 10;
            this.btnCaixa.Text = " Caixa";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPedido.Image = global::Livraria.Properties.Resources.pedido;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(0, 371);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPedido.Size = new System.Drawing.Size(220, 40);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = " Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // btnAutor
            // 
            this.btnAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutor.FlatAppearance.BorderSize = 0;
            this.btnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutor.Image = global::Livraria.Properties.Resources.autor;
            this.btnAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutor.Location = new System.Drawing.Point(0, 331);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAutor.Size = new System.Drawing.Size(220, 40);
            this.btnAutor.TabIndex = 8;
            this.btnAutor.Text = " Autores";
            this.btnAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutor.UseVisualStyleBackColor = true;
            // 
            // btnEditora
            // 
            this.btnEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditora.FlatAppearance.BorderSize = 0;
            this.btnEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditora.Image = global::Livraria.Properties.Resources.editora;
            this.btnEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditora.Location = new System.Drawing.Point(0, 291);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditora.Size = new System.Drawing.Size(220, 40);
            this.btnEditora.TabIndex = 7;
            this.btnEditora.Text = " Editora";
            this.btnEditora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditora.UseVisualStyleBackColor = true;
            // 
            // btnCat
            // 
            this.btnCat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCat.FlatAppearance.BorderSize = 0;
            this.btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCat.Image = global::Livraria.Properties.Resources.categoria;
            this.btnCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat.Location = new System.Drawing.Point(0, 251);
            this.btnCat.Name = "btnCat";
            this.btnCat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCat.Size = new System.Drawing.Size(220, 40);
            this.btnCat.TabIndex = 6;
            this.btnCat.Text = " Categoria";
            this.btnCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCat.UseVisualStyleBackColor = true;
            // 
            // btnLivro
            // 
            this.btnLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivro.FlatAppearance.BorderSize = 0;
            this.btnLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLivro.Image = global::Livraria.Properties.Resources.livro;
            this.btnLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivro.Location = new System.Drawing.Point(0, 211);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLivro.Size = new System.Drawing.Size(220, 40);
            this.btnLivro.TabIndex = 5;
            this.btnLivro.Text = " Livros";
            this.btnLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLivro.UseVisualStyleBackColor = true;
            // 
            // btnFone
            // 
            this.btnFone.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFone.FlatAppearance.BorderSize = 0;
            this.btnFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFone.Image = global::Livraria.Properties.Resources.telefone;
            this.btnFone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFone.Location = new System.Drawing.Point(0, 171);
            this.btnFone.Name = "btnFone";
            this.btnFone.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFone.Size = new System.Drawing.Size(220, 40);
            this.btnFone.TabIndex = 4;
            this.btnFone.Text = " Telefone";
            this.btnFone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFone.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCliente.Image = global::Livraria.Properties.Resources.cliente01;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 131);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(220, 40);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = " Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFunc.Image = global::Livraria.Properties.Resources.funcionario01;
            this.btnFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.Location = new System.Drawing.Point(0, 91);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFunc.Size = new System.Drawing.Size(220, 40);
            this.btnFunc.TabIndex = 2;
            this.btnFunc.Text = " Funcionário";
            this.btnFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // pneLogo
            // 
            this.pneLogo.BackColor = System.Drawing.SystemColors.Desktop;
            this.pneLogo.Controls.Add(this.label1);
            this.pneLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pneLogo.Location = new System.Drawing.Point(0, 0);
            this.pneLogo.Name = "pneLogo";
            this.pneLogo.Size = new System.Drawing.Size(220, 91);
            this.pneLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "SA Livraria";
            // 
            // pnllogosa
            // 
            this.pnllogosa.Controls.Add(this.frmCliente1);
            this.pnllogosa.Controls.Add(this.frmAtendente1);
            this.pnllogosa.Controls.Add(this.principal1);
            this.pnllogosa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnllogosa.Location = new System.Drawing.Point(220, 0);
            this.pnllogosa.Name = "pnllogosa";
            this.pnllogosa.Size = new System.Drawing.Size(1682, 1033);
            this.pnllogosa.TabIndex = 1;
            // 
            // principal1
            // 
            this.principal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principal1.Location = new System.Drawing.Point(0, 0);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(1682, 1033);
            this.principal1.TabIndex = 0;
            // 
            // frmAtendente1
            // 
            this.frmAtendente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmAtendente1.Location = new System.Drawing.Point(0, 0);
            this.frmAtendente1.Name = "frmAtendente1";
            this.frmAtendente1.Size = new System.Drawing.Size(1711, 1048);
            this.frmAtendente1.TabIndex = 1;
            // 
            // frmCliente1
            // 
            this.frmCliente1.Location = new System.Drawing.Point(0, 3);
            this.frmCliente1.Name = "frmCliente1";
            this.frmCliente1.Size = new System.Drawing.Size(1711, 1048);
            this.frmCliente1.TabIndex = 2;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnllogosa);
            this.Controls.Add(this.pneMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pneMenu.ResumeLayout(false);
            this.pneMenu.PerformLayout();
            this.pneLogo.ResumeLayout(false);
            this.pneLogo.PerformLayout();
            this.pnllogosa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pneMenu;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel pneLogo;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnEditora;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnFone;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnllogosa;
        private principal principal1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblusuarioLogado;
        private System.Windows.Forms.Label label2;
        private frmCliente frmCliente1;
        private frmAtendente frmAtendente1;
    }
}