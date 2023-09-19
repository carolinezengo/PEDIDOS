namespace Pedidos
{
    partial class FrmRelatorioCliente
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
            reportViewerCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewerCliente
            // 
            reportViewerCliente.Dock = DockStyle.Fill;
            reportViewerCliente.Location = new Point(0, 0);
            reportViewerCliente.Name = "ReportViewer";
            reportViewerCliente.ServerReport.BearerToken = null;
            reportViewerCliente.Size = new Size(799, 450);
            reportViewerCliente.TabIndex = 0;
            // 
            // FrmRelatorioCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(reportViewerCliente);
            Name = "FrmRelatorioCliente";
            Text = "FrmRelatorioCliente";
            Load += FrmRelatorioCliente_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCliente;
    }
}