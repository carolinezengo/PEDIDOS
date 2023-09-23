namespace Pedidos
{
    partial class FrmBuscarPedido
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
            groupBox1 = new GroupBox();
            RbtNumero = new RadioButton();
            RbtNome = new RadioButton();
            TxtNumero = new TextBox();
            TxtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnSair = new Button();
            BtnPesquisar = new Button();
            DGPDV = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGPDV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RbtNumero);
            groupBox1.Controls.Add(RbtNome);
            groupBox1.Controls.Add(TxtNumero);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnSair);
            groupBox1.Controls.Add(BtnPesquisar);
            groupBox1.Location = new Point(2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // RbtNumero
            // 
            RbtNumero.AutoSize = true;
            RbtNumero.Location = new Point(313, 62);
            RbtNumero.Name = "RbtNumero";
            RbtNumero.Size = new Size(69, 19);
            RbtNumero.TabIndex = 9;
            RbtNumero.TabStop = true;
            RbtNumero.Text = "Numero";
            RbtNumero.UseVisualStyleBackColor = true;
            RbtNumero.CheckedChanged += RbtNumero_CheckedChanged;
            // 
            // RbtNome
            // 
            RbtNome.AutoSize = true;
            RbtNome.Location = new Point(249, 62);
            RbtNome.Name = "RbtNome";
            RbtNome.Size = new Size(58, 19);
            RbtNome.TabIndex = 8;
            RbtNome.TabStop = true;
            RbtNome.Text = "Nome";
            RbtNome.UseVisualStyleBackColor = true;
            RbtNome.CheckedChanged += RbtNome_CheckedChanged;
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(120, 53);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(100, 23);
            TxtNumero.TabIndex = 7;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(50, 19);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(309, 23);
            TxtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 6;
            label2.Text = "Numero do Pedido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(511, 56);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(75, 23);
            BtnSair.TabIndex = 5;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(511, 22);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(75, 23);
            BtnPesquisar.TabIndex = 4;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click_1;
            // 
            // DGPDV
            // 
            DGPDV.BackgroundColor = SystemColors.Control;
            DGPDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPDV.Location = new Point(2, 125);
            DGPDV.Name = "DGPDV";
            DGPDV.RowTemplate.Height = 25;
            DGPDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGPDV.Size = new Size(610, 209);
            DGPDV.TabIndex = 1;
            DGPDV.CellContentClick += DGPDV_CellContentClick;
            DGPDV.CellDoubleClick += DGPDV_CellDoubleClick;
            // 
            // FrmBuscarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 346);
            Controls.Add(DGPDV);
            Controls.Add(groupBox1);
            Name = "FrmBuscarPedido";
            Text = "Pesquisa de Pedido";
            Load += FrmBuscarPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGPDV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnSair;
        private Button BtnPesquisar;
        private TextBox TxtNumero;
        private TextBox TxtNome;
        private Label label2;
        private Label label1;
        private DataGridView DGPDV;
        private RadioButton RbtNumero;
        private RadioButton RbtNome;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn NomeCliente;
    }
}