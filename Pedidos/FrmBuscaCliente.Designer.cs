namespace Pedidos
{
    partial class FrmBuscaCliente
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            button1 = new Button();
            TxtNome = new TextBox();
            label1 = new Label();
            BtnSair = new Button();
            BtnPesquisar = new Button();
            clienteDAOBindingSource = new BindingSource(components);
            clienteDAOBindingSource1 = new BindingSource(components);
            DgCliente = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgCliente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnSair);
            groupBox1.Controls.Add(BtnPesquisar);
            groupBox1.Location = new Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(642, 95);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(551, 37);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(60, 33);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(414, 23);
            TxtNome.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "NOME";
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(551, 66);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(75, 23);
            BtnSair.TabIndex = 3;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(551, 10);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(75, 23);
            BtnPesquisar.TabIndex = 2;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += button1_Click;
            // 
            // clienteDAOBindingSource
            // 
            clienteDAOBindingSource.DataSource = typeof(DAO.ClienteDAO);
            // 
            // clienteDAOBindingSource1
            // 
            clienteDAOBindingSource1.DataSource = typeof(DAO.ClienteDAO);
            // 
            // DgCliente
            // 
            DgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCliente.Location = new Point(4, 115);
            DgCliente.Name = "DgCliente";
            DgCliente.RowTemplate.Height = 25;
            DgCliente.Size = new Size(642, 216);
            DgCliente.TabIndex = 1;
            DgCliente.CellContentClick += DgCliente_CellContentClick;
            // 
            // FrmBuscaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 331);
            Controls.Add(DgCliente);
            Controls.Add(groupBox1);
            Name = "FrmBuscaCliente";
            Text = "Buscar Cliente";
            Load += FrmBuscaCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnPesquisar;
        private Button BtnSair;
        private TextBox TxtNome;
        private Label label1;
        private BindingSource clienteDAOBindingSource;
        private BindingSource clienteDAOBindingSource1;
        public DataGridView DgCliente;
        private Button button1;
    }
}