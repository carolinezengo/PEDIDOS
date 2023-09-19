namespace Pedidos
{
    partial class FrmCadProduto
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
            BtnBuscar = new Button();
            BtnGravar = new Button();
            BtnSair = new Button();
            BtnDeletar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            label9 = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtCodFornec = new TextBox();
            Txtquant = new TextBox();
            TxtNome = new TextBox();
            TxtCodigo = new TextBox();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackgroundImage = Properties.Resources.pesquisa;
            BtnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBuscar.ImageKey = "pesquisa.png";
            BtnBuscar.Location = new Point(136, 335);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(69, 73);
            BtnBuscar.TabIndex = 53;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnGravar
            // 
            BtnGravar.BackgroundImage = Properties.Resources.save_file_disk_open_searsh_loading_clipboard_1513;
            BtnGravar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGravar.ImageKey = "save_file_disk_open_searsh_loading_clipboard_1513.png";
            BtnGravar.Location = new Point(68, 335);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new Size(69, 73);
            BtnGravar.TabIndex = 52;
            BtnGravar.UseVisualStyleBackColor = true;
            BtnGravar.Click += BtnGravar_Click;
            // 
            // BtnSair
            // 
            BtnSair.BackgroundImage = Properties.Resources.exit_door;
            BtnSair.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSair.Location = new Point(328, 335);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(69, 73);
            BtnSair.TabIndex = 49;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnDeletar
            // 
            BtnDeletar.BackgroundImage = Properties.Resources.Delete;
            BtnDeletar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDeletar.Location = new Point(264, 335);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(69, 73);
            BtnDeletar.TabIndex = 48;
            BtnDeletar.UseVisualStyleBackColor = true;
            BtnDeletar.Click += BtnDeletar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackgroundImage = Properties.Resources.alterar;
            BtnAlterar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAlterar.Location = new Point(202, 335);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(69, 73);
            BtnAlterar.TabIndex = 47;
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.BackgroundImage = Properties.Resources.New_File_36861;
            BtnNovo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNovo.ImageKey = "New_File_36861.png";
            BtnNovo.Location = new Point(2, 335);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(69, 73);
            BtnNovo.TabIndex = 46;
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 214);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 45;
            label9.Text = "Cod Fornecedor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 172);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 43;
            label7.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 134);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 38;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 84);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 37;
            label1.Text = "Codigo:";
            // 
            // TxtCodFornec
            // 
            TxtCodFornec.Location = new Point(109, 214);
            TxtCodFornec.Name = "TxtCodFornec";
            TxtCodFornec.Size = new Size(59, 23);
            TxtCodFornec.TabIndex = 36;
            // 
            // Txtquant
            // 
            Txtquant.Location = new Point(92, 169);
            Txtquant.Name = "Txtquant";
            Txtquant.Size = new Size(76, 23);
            Txtquant.TabIndex = 32;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(81, 134);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(334, 23);
            TxtNome.TabIndex = 29;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(68, 76);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(100, 23);
            TxtCodigo.TabIndex = 28;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(2, 412);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 54;
            // 
            // FrmCadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 436);
            Controls.Add(lblMensagem);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnGravar);
            Controls.Add(BtnSair);
            Controls.Add(BtnDeletar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtCodFornec);
            Controls.Add(Txtquant);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Name = "FrmCadProduto";
            Text = "Cadastro de Produto";
            Load += FrmCadProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscar;
        private Button BtnGravar;
        private Button BtnSair;
        private Button BtnDeletar;
        private Button BtnAlterar;
        private Button BtnNovo;
        private Label label9;
        private Label label7;
        private Label label2;
        private Label label1;
        private TextBox TxtCodFornec;
        private TextBox Txtquant;
        private TextBox TxtNome;
        private TextBox TxtCodigo;
        private Label lblMensagem;
    }
}