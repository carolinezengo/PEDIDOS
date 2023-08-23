namespace Pedidos
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProdutoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeClienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeFornecedorToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            faturarToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            relatorioDeFornecedorToolStripMenuItem = new ToolStripMenuItem();
            relatorioDeClienteToolStripMenuItem = new ToolStripMenuItem();
            relatorioDeProdutoToolStripMenuItem = new ToolStripMenuItem();
            relatorioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, cadastroToolStripMenuItem, pedidosToolStripMenuItem, relatoriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(509, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeProdutoToolStripMenuItem, cadastroDeClienteToolStripMenuItem, cadastroDeFornecedorToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            cadastroDeProdutoToolStripMenuItem.Size = new Size(203, 22);
            cadastroDeProdutoToolStripMenuItem.Text = "Cadastro de Produto";
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            cadastroDeClienteToolStripMenuItem.Size = new Size(203, 22);
            cadastroDeClienteToolStripMenuItem.Text = "Cadastro de Cliente";
            cadastroDeClienteToolStripMenuItem.Click += cadastroDeClienteToolStripMenuItem_Click;
            // 
            // cadastroDeFornecedorToolStripMenuItem
            // 
            cadastroDeFornecedorToolStripMenuItem.Name = "cadastroDeFornecedorToolStripMenuItem";
            cadastroDeFornecedorToolStripMenuItem.Size = new Size(203, 22);
            cadastroDeFornecedorToolStripMenuItem.Text = "Cadastro de Fornecedor ";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { faturarToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // faturarToolStripMenuItem
            // 
            faturarToolStripMenuItem.Name = "faturarToolStripMenuItem";
            faturarToolStripMenuItem.Size = new Size(111, 22);
            faturarToolStripMenuItem.Text = "Faturar";
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatorioDeFornecedorToolStripMenuItem, relatorioDeClienteToolStripMenuItem, relatorioDeProdutoToolStripMenuItem, relatorioDeVendasToolStripMenuItem });
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(71, 20);
            relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // relatorioDeFornecedorToolStripMenuItem
            // 
            relatorioDeFornecedorToolStripMenuItem.Name = "relatorioDeFornecedorToolStripMenuItem";
            relatorioDeFornecedorToolStripMenuItem.Size = new Size(200, 22);
            relatorioDeFornecedorToolStripMenuItem.Text = "Relatorio de Fornecedor";
            // 
            // relatorioDeClienteToolStripMenuItem
            // 
            relatorioDeClienteToolStripMenuItem.Name = "relatorioDeClienteToolStripMenuItem";
            relatorioDeClienteToolStripMenuItem.Size = new Size(200, 22);
            relatorioDeClienteToolStripMenuItem.Text = "Relatorio de Cliente ";
            // 
            // relatorioDeProdutoToolStripMenuItem
            // 
            relatorioDeProdutoToolStripMenuItem.Name = "relatorioDeProdutoToolStripMenuItem";
            relatorioDeProdutoToolStripMenuItem.Size = new Size(200, 22);
            relatorioDeProdutoToolStripMenuItem.Text = "Relatorio de Produto";
            // 
            // relatorioDeVendasToolStripMenuItem
            // 
            relatorioDeVendasToolStripMenuItem.Name = "relatorioDeVendasToolStripMenuItem";
            relatorioDeVendasToolStripMenuItem.Size = new Size(200, 22);
            relatorioDeVendasToolStripMenuItem.Text = "Relatorio de Vendas";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 320);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Pedidos";
            Load += Menu_Load;
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
        private ToolStripMenuItem cadastroDeProdutoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeClienteToolStripMenuItem;
        private ToolStripMenuItem cadastroDeFornecedorToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem faturarToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem relatorioDeFornecedorToolStripMenuItem;
        private ToolStripMenuItem relatorioDeClienteToolStripMenuItem;
        private ToolStripMenuItem relatorioDeProdutoToolStripMenuItem;
        private ToolStripMenuItem relatorioDeVendasToolStripMenuItem;
    }
}