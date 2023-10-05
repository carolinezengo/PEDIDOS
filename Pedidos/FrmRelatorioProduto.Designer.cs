namespace Pedidos
{
    partial class FrmRelatorioProduto
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
            reportViewerProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewerProduto
            // 
            reportViewerProduto.Dock = DockStyle.Fill;
            reportViewerProduto.Location = new Point(0, 0);
            reportViewerProduto.Name = "ReportViewer";
            reportViewerProduto.ServerReport.BearerToken = null;
            reportViewerProduto.Size = new Size(800, 450);
            reportViewerProduto.TabIndex = 0;
            // 
            // FrmRelatorioProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportViewerProduto);
            Name = "FrmRelatorioProduto";
            Text = "FrmRelatorioProduto";
            Load += FrmRelatorioProduto_Load;
            MouseClick += FrmRelatorioProduto_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProduto;
    }
}