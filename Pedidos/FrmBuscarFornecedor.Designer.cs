namespace Pedidos
{
    partial class FrmBuscarFornecedor
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
            DgFornecedor = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            BtnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgFornecedor).BeginInit();
            SuspendLayout();
            // 
            // DgFornecedor
            // 
            DgFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgFornecedor.Location = new Point(3, 151);
            DgFornecedor.Name = "DgFornecedor";
            DgFornecedor.RowTemplate.Height = 25;
            DgFornecedor.Size = new Size(797, 263);
            DgFornecedor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do Fornecedor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 23);
            textBox1.TabIndex = 2;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(602, 66);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(75, 23);
            BtnPesquisar.TabIndex = 3;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // FrmBuscarFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 418);
            Controls.Add(BtnPesquisar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(DgFornecedor);
            Name = "FrmBuscarFornecedor";
            Text = "Buscar Fornecedor";
            Load += FrmBuscarFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)DgFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgFornecedor;
        private Label label1;
        private TextBox textBox1;
        private Button BtnPesquisar;
    }
}