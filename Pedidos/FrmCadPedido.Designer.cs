namespace Pedidos
{
    partial class FrmCadPedido
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
            label1 = new Label();
            TxtNumero = new TextBox();
            label2 = new Label();
            TxtDataCompra = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            BtnBuscar = new Button();
            BtnGravar = new Button();
            BtnSair = new Button();
            BtnDeletar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            Txtquat = new TextBox();
            label6 = new Label();
            DgProduto = new DataGridView();
            TxtSituacao = new TextBox();
            label5 = new Label();
            TxtTotal = new TextBox();
            label7 = new Label();
            TxtValorUnitario = new TextBox();
            label8 = new Label();
            TxtProduto = new TextBox();
            button3 = new Button();
            DgPDV = new DataGridView();
            Rbtnmais = new RadioButton();
            Rbtnmenos = new RadioButton();
            RbtnFat = new RadioButton();
            RBtnOrc = new RadioButton();
            lblMensagem = new Label();
            CboCliente = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DgProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgPDV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(75, 6);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.ReadOnly = true;
            TxtNumero.Size = new Size(88, 23);
            TxtNumero.TabIndex = 1;
            TxtNumero.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // TxtDataCompra
            // 
            TxtDataCompra.Location = new Point(547, 12);
            TxtDataCompra.Name = "TxtDataCompra";
            TxtDataCompra.Size = new Size(100, 23);
            TxtDataCompra.TabIndex = 5;
            TxtDataCompra.TextChanged += TxtData_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 15);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 4;
            label3.Text = "Data Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 131);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Produto";
            // 
            // button1
            // 
            button1.Location = new Point(591, 264);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 9;
            button1.Text = "Prencher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackgroundImage = Properties.Resources.pesquisa;
            BtnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBuscar.ImageKey = "pesquisa.png";
            BtnBuscar.Location = new Point(140, 477);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(69, 73);
            BtnBuscar.TabIndex = 33;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnGravar
            // 
            BtnGravar.BackgroundImage = Properties.Resources.save_file_disk_open_searsh_loading_clipboard_1513;
            BtnGravar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGravar.ImageKey = "save_file_disk_open_searsh_loading_clipboard_1513.png";
            BtnGravar.Location = new Point(72, 477);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new Size(69, 73);
            BtnGravar.TabIndex = 32;
            BtnGravar.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            BtnSair.BackgroundImage = Properties.Resources.exit_door;
            BtnSair.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSair.Location = new Point(332, 477);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(69, 73);
            BtnSair.TabIndex = 31;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnDeletar
            // 
            BtnDeletar.BackgroundImage = Properties.Resources.Delete;
            BtnDeletar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDeletar.Location = new Point(268, 477);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(69, 73);
            BtnDeletar.TabIndex = 30;
            BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackgroundImage = Properties.Resources.alterar;
            BtnAlterar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAlterar.Location = new Point(206, 477);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(69, 73);
            BtnAlterar.TabIndex = 29;
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.BackgroundImage = Properties.Resources.New_File_36861;
            BtnNovo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNovo.ImageKey = "New_File_36861.png";
            BtnNovo.Location = new Point(6, 477);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(69, 73);
            BtnNovo.TabIndex = 28;
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // Txtquat
            // 
            Txtquat.Location = new Point(341, 264);
            Txtquat.Name = "Txtquat";
            Txtquat.Size = new Size(42, 23);
            Txtquat.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 268);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 36;
            label6.Text = "Quantidade:";
            // 
            // DgProduto
            // 
            DgProduto.BackgroundColor = SystemColors.Control;
            DgProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduto.Location = new Point(12, 155);
            DgProduto.Name = "DgProduto";
            DgProduto.ReadOnly = true;
            DgProduto.RowTemplate.Height = 25;
            DgProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgProduto.Size = new Size(638, 103);
            DgProduto.TabIndex = 40;
            DgProduto.TabStop = false;
            DgProduto.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TxtSituacao
            // 
            TxtSituacao.Location = new Point(588, 528);
            TxtSituacao.Name = "TxtSituacao";
            TxtSituacao.ReadOnly = true;
            TxtSituacao.Size = new Size(95, 23);
            TxtSituacao.TabIndex = 43;
            TxtSituacao.TabStop = false;
            TxtSituacao.TextChanged += TxtSituacao_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(588, 510);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 42;
            label5.Text = "Situaçao Pedido";
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(587, 477);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(95, 23);
            TxtTotal.TabIndex = 45;
            TxtTotal.TabStop = false;
            TxtTotal.TextChanged += TxtTotal_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 459);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 44;
            label7.Text = "Total:";
            // 
            // TxtValorUnitario
            // 
            TxtValorUnitario.Location = new Point(452, 264);
            TxtValorUnitario.Name = "TxtValorUnitario";
            TxtValorUnitario.ReadOnly = true;
            TxtValorUnitario.Size = new Size(62, 23);
            TxtValorUnitario.TabIndex = 47;
            TxtValorUnitario.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 268);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 46;
            label8.Text = "Vl Unitario:";
            // 
            // TxtProduto
            // 
            TxtProduto.Location = new Point(62, 123);
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(447, 23);
            TxtProduto.TabIndex = 48;
            // 
            // button3
            // 
            button3.Location = new Point(577, 58);
            button3.Name = "button3";
            button3.Size = new Size(73, 39);
            button3.TabIndex = 49;
            button3.Text = "Consultar  Cliente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // DgPDV
            // 
            DgPDV.BackgroundColor = SystemColors.Control;
            DgPDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPDV.Location = new Point(12, 293);
            DgPDV.Name = "DgPDV";
            DgPDV.ReadOnly = true;
            DgPDV.RowTemplate.Height = 25;
            DgPDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgPDV.Size = new Size(638, 152);
            DgPDV.TabIndex = 50;
            DgPDV.TabStop = false;
            DgPDV.CellContentClick += DgPDV_CellContentClick;
            // 
            // Rbtnmais
            // 
            Rbtnmais.AutoSize = true;
            Rbtnmais.Location = new Point(520, 265);
            Rbtnmais.Name = "Rbtnmais";
            Rbtnmais.Size = new Size(33, 19);
            Rbtnmais.TabIndex = 51;
            Rbtnmais.TabStop = true;
            Rbtnmais.Text = "+";
            Rbtnmais.UseVisualStyleBackColor = true;
            Rbtnmais.CheckedChanged += Rbtnmais_CheckedChanged;
            // 
            // Rbtnmenos
            // 
            Rbtnmenos.AutoSize = true;
            Rbtnmenos.Location = new Point(559, 266);
            Rbtnmenos.Name = "Rbtnmenos";
            Rbtnmenos.Size = new Size(30, 19);
            Rbtnmenos.TabIndex = 52;
            Rbtnmenos.TabStop = true;
            Rbtnmenos.Text = "-";
            Rbtnmenos.UseVisualStyleBackColor = true;
            Rbtnmenos.CheckedChanged += Rbtnmenos_CheckedChanged;
            // 
            // RbtnFat
            // 
            RbtnFat.AutoSize = true;
            RbtnFat.Location = new Point(206, 10);
            RbtnFat.Name = "RbtnFat";
            RbtnFat.Size = new Size(72, 19);
            RbtnFat.TabIndex = 53;
            RbtnFat.TabStop = true;
            RbtnFat.Text = "Faturado";
            RbtnFat.UseVisualStyleBackColor = true;
            RbtnFat.CheckedChanged += RbtnFat_CheckedChanged;
            // 
            // RBtnOrc
            // 
            RBtnOrc.AutoSize = true;
            RBtnOrc.Location = new Point(284, 10);
            RBtnOrc.Name = "RBtnOrc";
            RBtnOrc.Size = new Size(85, 19);
            RBtnOrc.TabIndex = 54;
            RBtnOrc.TabStop = true;
            RBtnOrc.Text = "Orçamento";
            RBtnOrc.UseVisualStyleBackColor = true;
            RBtnOrc.CheckedChanged += RBtnOrc_CheckedChanged;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(12, 459);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 55;
            // 
            // CboCliente
            // 
            CboCliente.FormattingEnabled = true;
            CboCliente.Location = new Point(62, 67);
            CboCliente.Name = "CboCliente";
            CboCliente.Size = new Size(460, 23);
            CboCliente.TabIndex = 56;
            // 
            // FrmCadPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 562);
            Controls.Add(CboCliente);
            Controls.Add(lblMensagem);
            Controls.Add(RBtnOrc);
            Controls.Add(RbtnFat);
            Controls.Add(Rbtnmenos);
            Controls.Add(Rbtnmais);
            Controls.Add(DgPDV);
            Controls.Add(button3);
            Controls.Add(TxtProduto);
            Controls.Add(TxtValorUnitario);
            Controls.Add(label8);
            Controls.Add(TxtTotal);
            Controls.Add(label7);
            Controls.Add(TxtSituacao);
            Controls.Add(label5);
            Controls.Add(DgProduto);
            Controls.Add(Txtquat);
            Controls.Add(label6);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnGravar);
            Controls.Add(BtnSair);
            Controls.Add(BtnDeletar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(TxtDataCompra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtNumero);
            Controls.Add(label1);
            Name = "FrmCadPedido";
            Text = "Pedido de Venda";
            Load += FrmCadPedido_Load;
            ((System.ComponentModel.ISupportInitialize)DgProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgPDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNumero;
        private Label label2;
        private TextBox TxtDataCompra;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button BtnBuscar;
        private Button BtnGravar;
        private Button BtnSair;
        private Button BtnDeletar;
        private Button BtnAlterar;
        private Button BtnNovo;
        private TextBox Txtquat;
        private Label label6;
        private DataGridView DgProduto;
        private TextBox TxtSituacao;
        private Label label5;
        private TextBox TxtTotal;
        private Label label7;
        private TextBox TxtValorUnitario;
        private Label label8;
        private TextBox TxtProduto;
        private Button button3;
        private DataGridView DgPDV;
        private RadioButton Rbtnmais;
        private RadioButton Rbtnmenos;
        private RadioButton RbtnFat;
        private RadioButton RBtnOrc;
        private Label lblMensagem;
        private ComboBox CboCliente;
    }
}