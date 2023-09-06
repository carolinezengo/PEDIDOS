namespace Pedidos
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            cadastroClienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroFornecedorToolStripMenuItem = new ToolStripMenuItem();
            cadastroProdutoToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            buscaToolStripMenuItem = new ToolStripMenuItem();
            buscarClienteToolStripMenuItem = new ToolStripMenuItem();
            buscarFornecedorToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, cadastroToolStripMenuItem, pedidoToolStripMenuItem, buscaToolStripMenuItem, relatorioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(643, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, sairToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(51, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(180, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroClienteToolStripMenuItem, cadastroFornecedorToolStripMenuItem, cadastroProdutoToolStripMenuItem });
            cadastroToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(71, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            cadastroClienteToolStripMenuItem.Size = new Size(195, 22);
            cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            cadastroClienteToolStripMenuItem.Click += cadastroClienteToolStripMenuItem_Click;
            // 
            // cadastroFornecedorToolStripMenuItem
            // 
            cadastroFornecedorToolStripMenuItem.Name = "cadastroFornecedorToolStripMenuItem";
            cadastroFornecedorToolStripMenuItem.Size = new Size(195, 22);
            cadastroFornecedorToolStripMenuItem.Text = "Cadastro Fornecedor";
            cadastroFornecedorToolStripMenuItem.Click += cadastroFornecedorToolStripMenuItem_Click;
            // 
            // cadastroProdutoToolStripMenuItem
            // 
            cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            cadastroProdutoToolStripMenuItem.Size = new Size(195, 22);
            cadastroProdutoToolStripMenuItem.Text = "Cadastro Produto";
            cadastroProdutoToolStripMenuItem.Click += cadastroProdutoToolStripMenuItem_Click;
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(59, 20);
            pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // buscaToolStripMenuItem
            // 
            buscaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarClienteToolStripMenuItem, buscarFornecedorToolStripMenuItem });
            buscaToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            buscaToolStripMenuItem.Size = new Size(56, 20);
            buscaToolStripMenuItem.Text = "Busca";
            // 
            // buscarClienteToolStripMenuItem
            // 
            buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            buscarClienteToolStripMenuItem.Size = new Size(184, 22);
            buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            buscarClienteToolStripMenuItem.Click += buscarClienteToolStripMenuItem_Click;
            // 
            // buscarFornecedorToolStripMenuItem
            // 
            buscarFornecedorToolStripMenuItem.Name = "buscarFornecedorToolStripMenuItem";
            buscarFornecedorToolStripMenuItem.Size = new Size(184, 22);
            buscarFornecedorToolStripMenuItem.Text = "Buscar Fornecedor";
            buscarFornecedorToolStripMenuItem.Click += buscarFornecedorToolStripMenuItem_Click;
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(70, 20);
            relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.sistemas_de_informacao;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Location = new Point(0, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 336);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 403);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Menu";
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem buscaToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;
        private ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private ToolStripMenuItem buscarClienteToolStripMenuItem;
        private GroupBox groupBox1;
        private ToolStripMenuItem cadastroFornecedorToolStripMenuItem;
        private ToolStripMenuItem buscarFornecedorToolStripMenuItem;
        private ToolStripMenuItem cadastroProdutoToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
    }
}