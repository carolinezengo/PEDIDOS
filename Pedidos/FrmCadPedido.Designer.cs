﻿namespace Pedidos
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
            TxtCliente = new TextBox();
            label2 = new Label();
            TxtData = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            BtnBuscar = new Button();
            BtnGravar = new Button();
            BtnSair = new Button();
            BtnDeletar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            Txtquat = new TextBox();
            label6 = new Label();
            GDProdutos = new DataGridView();
            BtnConsultaproduto = new Button();
            TxtSituacao = new TextBox();
            label5 = new Label();
            TxtTotal = new TextBox();
            label7 = new Label();
            TxtValorUnitario = new TextBox();
            label8 = new Label();
            TxtProduto = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)GDProdutos).BeginInit();
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
            // TxtCliente
            // 
            TxtCliente.Location = new Point(72, 67);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(479, 23);
            TxtCliente.TabIndex = 3;
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
            // TxtData
            // 
            TxtData.Location = new Point(547, 12);
            TxtData.Name = "TxtData";
            TxtData.Size = new Size(100, 23);
            TxtData.TabIndex = 5;
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
            label4.Location = new Point(6, 122);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Produto";
            // 
            // button1
            // 
            button1.Location = new Point(567, 177);
            button1.Name = "button1";
            button1.Size = new Size(31, 23);
            button1.TabIndex = 9;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(604, 177);
            button2.Name = "button2";
            button2.Size = new Size(31, 23);
            button2.TabIndex = 10;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackgroundImage = Properties.Resources.pesquisa;
            BtnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBuscar.ImageKey = "pesquisa.png";
            BtnBuscar.Location = new Point(148, 365);
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
            BtnGravar.Location = new Point(80, 365);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new Size(69, 73);
            BtnGravar.TabIndex = 32;
            BtnGravar.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            BtnSair.BackgroundImage = Properties.Resources.exit_door;
            BtnSair.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSair.Location = new Point(340, 365);
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
            BtnDeletar.Location = new Point(276, 365);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(69, 73);
            BtnDeletar.TabIndex = 30;
            BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackgroundImage = Properties.Resources.alterar;
            BtnAlterar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAlterar.Location = new Point(214, 365);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(69, 73);
            BtnAlterar.TabIndex = 29;
            BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            BtnNovo.BackgroundImage = Properties.Resources.New_File_36861;
            BtnNovo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNovo.ImageKey = "New_File_36861.png";
            BtnNovo.Location = new Point(14, 365);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(69, 73);
            BtnNovo.TabIndex = 28;
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // Txtquat
            // 
            Txtquat.Location = new Point(388, 177);
            Txtquat.Name = "Txtquat";
            Txtquat.Size = new Size(42, 23);
            Txtquat.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(310, 181);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 36;
            label6.Text = "Quantidade:";
            // 
            // GDProdutos
            // 
            GDProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GDProdutos.Location = new Point(2, 203);
            GDProdutos.Name = "GDProdutos";
            GDProdutos.ReadOnly = true;
            GDProdutos.RowTemplate.Height = 25;
            GDProdutos.Size = new Size(645, 150);
            GDProdutos.TabIndex = 40;
            GDProdutos.TabStop = false;
            GDProdutos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnConsultaproduto
            // 
            BtnConsultaproduto.Location = new Point(565, 110);
            BtnConsultaproduto.Name = "BtnConsultaproduto";
            BtnConsultaproduto.Size = new Size(75, 39);
            BtnConsultaproduto.TabIndex = 41;
            BtnConsultaproduto.Text = "Consultar  Produto";
            BtnConsultaproduto.UseVisualStyleBackColor = true;
            BtnConsultaproduto.Click += button3_Click;
            // 
            // TxtSituacao
            // 
            TxtSituacao.Location = new Point(555, 425);
            TxtSituacao.Name = "TxtSituacao";
            TxtSituacao.ReadOnly = true;
            TxtSituacao.Size = new Size(95, 23);
            TxtSituacao.TabIndex = 43;
            TxtSituacao.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 407);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 42;
            label5.Text = "Situaçao Pedido";
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(554, 374);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(95, 23);
            TxtTotal.TabIndex = 45;
            TxtTotal.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(600, 356);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 44;
            label7.Text = "Total:";
            // 
            // TxtValorUnitario
            // 
            TxtValorUnitario.Location = new Point(499, 177);
            TxtValorUnitario.Name = "TxtValorUnitario";
            TxtValorUnitario.ReadOnly = true;
            TxtValorUnitario.Size = new Size(62, 23);
            TxtValorUnitario.TabIndex = 47;
            TxtValorUnitario.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(436, 181);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 46;
            label8.Text = "Vl Unitario:";
            // 
            // TxtProduto
            // 
            TxtProduto.Location = new Point(72, 110);
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(479, 23);
            TxtProduto.TabIndex = 48;
            // 
            // button3
            // 
            button3.Location = new Point(567, 58);
            button3.Name = "button3";
            button3.Size = new Size(73, 39);
            button3.TabIndex = 49;
            button3.Text = "Consultar  Cliente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // FrmCadPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 450);
            Controls.Add(button3);
            Controls.Add(TxtProduto);
            Controls.Add(TxtValorUnitario);
            Controls.Add(label8);
            Controls.Add(TxtTotal);
            Controls.Add(label7);
            Controls.Add(TxtSituacao);
            Controls.Add(label5);
            Controls.Add(BtnConsultaproduto);
            Controls.Add(GDProdutos);
            Controls.Add(Txtquat);
            Controls.Add(label6);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnGravar);
            Controls.Add(BtnSair);
            Controls.Add(BtnDeletar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(TxtData);
            Controls.Add(label3);
            Controls.Add(TxtCliente);
            Controls.Add(label2);
            Controls.Add(TxtNumero);
            Controls.Add(label1);
            Name = "FrmCadPedido";
            Text = "Pedido de Venda";
            Load += FrmCadPedido_Load;
            ((System.ComponentModel.ISupportInitialize)GDProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNumero;
        private TextBox TxtCliente;
        private Label label2;
        private TextBox TxtData;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button BtnBuscar;
        private Button BtnGravar;
        private Button BtnSair;
        private Button BtnDeletar;
        private Button BtnAlterar;
        private Button BtnNovo;
        private TextBox Txtquat;
        private Label label6;
        private DataGridView GDProdutos;
        private Button BtnConsultaproduto;
        private TextBox TxtSituacao;
        private Label label5;
        private TextBox TxtTotal;
        private Label label7;
        private TextBox TxtValorUnitario;
        private Label label8;
        private TextBox TxtProduto;
        private Button button3;
    }
}