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
            buscaDeProdutoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            relatorioDeClienteToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            relatorioDeFornecedorToolStripMenuItem = new ToolStripMenuItem();
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
            menuToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(54, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(151, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(151, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroClienteToolStripMenuItem, cadastroFornecedorToolStripMenuItem, cadastroProdutoToolStripMenuItem });
            cadastroToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(75, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            cadastroClienteToolStripMenuItem.Size = new Size(207, 22);
            cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            cadastroClienteToolStripMenuItem.Click += cadastroClienteToolStripMenuItem_Click;
            // 
            // cadastroFornecedorToolStripMenuItem
            // 
            cadastroFornecedorToolStripMenuItem.Name = "cadastroFornecedorToolStripMenuItem";
            cadastroFornecedorToolStripMenuItem.Size = new Size(207, 22);
            cadastroFornecedorToolStripMenuItem.Text = "Cadastro Fornecedor";
            cadastroFornecedorToolStripMenuItem.Click += cadastroFornecedorToolStripMenuItem_Click;
            // 
            // cadastroProdutoToolStripMenuItem
            // 
            cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            cadastroProdutoToolStripMenuItem.Size = new Size(207, 22);
            cadastroProdutoToolStripMenuItem.Text = "Cadastro Produto";
            cadastroProdutoToolStripMenuItem.Click += cadastroProdutoToolStripMenuItem_Click;
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(64, 20);
            pedidoToolStripMenuItem.Text = "Pedido";
            pedidoToolStripMenuItem.Click += pedidoToolStripMenuItem_Click;
            // 
            // buscaToolStripMenuItem
            // 
            buscaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarClienteToolStripMenuItem, buscarFornecedorToolStripMenuItem, buscaDeProdutoToolStripMenuItem, pedidosToolStripMenuItem });
            buscaToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            buscaToolStripMenuItem.Size = new Size(57, 20);
            buscaToolStripMenuItem.Text = "Busca";
            // 
            // buscarClienteToolStripMenuItem
            // 
            buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            buscarClienteToolStripMenuItem.Size = new Size(147, 22);
            buscarClienteToolStripMenuItem.Text = "Cliente";
            buscarClienteToolStripMenuItem.Click += buscarClienteToolStripMenuItem_Click;
            // 
            // buscarFornecedorToolStripMenuItem
            // 
            buscarFornecedorToolStripMenuItem.Name = "buscarFornecedorToolStripMenuItem";
            buscarFornecedorToolStripMenuItem.Size = new Size(147, 22);
            buscarFornecedorToolStripMenuItem.Text = "Fornecedor";
            buscarFornecedorToolStripMenuItem.Click += buscarFornecedorToolStripMenuItem_Click;
            // 
            // buscaDeProdutoToolStripMenuItem
            // 
            buscaDeProdutoToolStripMenuItem.Name = "buscaDeProdutoToolStripMenuItem";
            buscaDeProdutoToolStripMenuItem.Size = new Size(147, 22);
            buscaDeProdutoToolStripMenuItem.Text = "Produto";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(147, 22);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatorioDeClienteToolStripMenuItem, relatorioDeFornecedorToolStripMenuItem });
            relatorioToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(77, 20);
            relatorioToolStripMenuItem.Text = "Relatorio";
            relatorioToolStripMenuItem.Click += relatorioToolStripMenuItem_Click;
            // 
            // relatorioDeClienteToolStripMenuItem
            // 
            relatorioDeClienteToolStripMenuItem.Name = "relatorioDeClienteToolStripMenuItem";
            relatorioDeClienteToolStripMenuItem.Size = new Size(229, 22);
            relatorioDeClienteToolStripMenuItem.Text = "Relatorio de Cliente";
            relatorioDeClienteToolStripMenuItem.Click += relatorioDeClienteToolStripMenuItem_Click;
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
            // relatorioDeFornecedorToolStripMenuItem
            // 
            relatorioDeFornecedorToolStripMenuItem.Name = "relatorioDeFornecedorToolStripMenuItem";
            relatorioDeFornecedorToolStripMenuItem.Size = new Size(229, 22);
            relatorioDeFornecedorToolStripMenuItem.Text = "Relatorio de Fornecedor";
            relatorioDeFornecedorToolStripMenuItem.Click += relatorioDeFornecedorToolStripMenuItem_Click;
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
        private ToolStripMenuItem buscaDeProdutoToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem relatorioDeClienteToolStripMenuItem;
        private ToolStripMenuItem relatorioDeFornecedorToolStripMenuItem;
    }
}