namespace Pedidos
{
    partial class FrmCadFornecedor
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
            label10 = new Label();
            TxtComp = new TextBox();
            BtnSair = new Button();
            BtnDeletar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtTel = new TextBox();
            TxtCnpj = new TextBox();
            TxtCidade = new TextBox();
            TxtBairro = new TextBox();
            TxtCep = new TextBox();
            TxtDataComp = new TextBox();
            TxtEndereco = new TextBox();
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
            BtnBuscar.Location = new Point(156, 468);
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
            BtnGravar.Location = new Point(88, 468);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new Size(69, 73);
            BtnGravar.TabIndex = 52;
            BtnGravar.UseVisualStyleBackColor = true;
            BtnGravar.Click += BtnGravar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(196, 214);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 51;
            label10.Text = "Complemento:";
            // 
            // TxtComp
            // 
            TxtComp.Location = new Point(286, 211);
            TxtComp.Name = "TxtComp";
            TxtComp.Size = new Size(275, 23);
            TxtComp.TabIndex = 50;
            // 
            // BtnSair
            // 
            BtnSair.BackgroundImage = Properties.Resources.exit_door;
            BtnSair.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSair.Location = new Point(348, 468);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(69, 73);
            BtnSair.TabIndex = 49;
            BtnSair.UseVisualStyleBackColor = true;
            // 
            // BtnDeletar
            // 
            BtnDeletar.BackgroundImage = Properties.Resources.Delete;
            BtnDeletar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDeletar.Location = new Point(284, 468);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(69, 73);
            BtnDeletar.TabIndex = 48;
            BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackgroundImage = Properties.Resources.alterar;
            BtnAlterar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAlterar.Location = new Point(222, 468);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(69, 73);
            BtnAlterar.TabIndex = 47;
            BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            BtnNovo.BackgroundImage = Properties.Resources.New_File_36861;
            BtnNovo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNovo.ImageKey = "New_File_36861.png";
            BtnNovo.Location = new Point(22, 468);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(69, 73);
            BtnNovo.TabIndex = 46;
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 408);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 45;
            label9.Text = "TEL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 352);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 44;
            label8.Text = "CNPJ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 298);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 43;
            label7.Text = "CEP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 251);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 42;
            label6.Text = "Cidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 211);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 41;
            label5.Text = "Bairro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 176);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 40;
            label4.Text = "Rua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 133);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 39;
            label3.Text = "Data Compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 82);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 38;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 37;
            label1.Text = "Codigo:";
            // 
            // TxtTel
            // 
            TxtTel.Location = new Point(78, 400);
            TxtTel.Name = "TxtTel";
            TxtTel.Size = new Size(149, 23);
            TxtTel.TabIndex = 36;
            // 
            // TxtCnpj
            // 
            TxtCnpj.Location = new Point(78, 344);
            TxtCnpj.Name = "TxtCnpj";
            TxtCnpj.Size = new Size(190, 23);
            TxtCnpj.TabIndex = 35;
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(78, 251);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(182, 23);
            TxtCidade.TabIndex = 34;
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(78, 211);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(100, 23);
            TxtBairro.TabIndex = 33;
            // 
            // TxtCep
            // 
            TxtCep.Location = new Point(78, 295);
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(100, 23);
            TxtCep.TabIndex = 32;
            // 
            // TxtDataComp
            // 
            TxtDataComp.Location = new Point(131, 133);
            TxtDataComp.Name = "TxtDataComp";
            TxtDataComp.Size = new Size(137, 23);
            TxtDataComp.TabIndex = 31;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(78, 173);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(350, 23);
            TxtEndereco.TabIndex = 30;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(78, 74);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(350, 23);
            TxtNome.TabIndex = 29;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(78, 24);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(100, 23);
            TxtCodigo.TabIndex = 28;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(22, 550);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 54;
            // 
            // FrmCadFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 574);
            Controls.Add(lblMensagem);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnGravar);
            Controls.Add(label10);
            Controls.Add(TxtComp);
            Controls.Add(BtnSair);
            Controls.Add(BtnDeletar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtTel);
            Controls.Add(TxtCnpj);
            Controls.Add(TxtCidade);
            Controls.Add(TxtBairro);
            Controls.Add(TxtCep);
            Controls.Add(TxtDataComp);
            Controls.Add(TxtEndereco);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Name = "FrmCadFornecedor";
            Text = "Cadastro Fornecedor ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscar;
        private Button BtnGravar;
        private Label label10;
        private TextBox TxtComp;
        private Button BtnSair;
        private Button BtnDeletar;
        private Button BtnAlterar;
        private Button BtnNovo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtTel;
        private TextBox TxtCnpj;
        private TextBox TxtCidade;
        private TextBox TxtBairro;
        private TextBox TxtCep;
        private TextBox TxtDataComp;
        private TextBox TxtEndereco;
        private TextBox TxtNome;
        private TextBox TxtCodigo;
        private Label lblMensagem;
    }
}