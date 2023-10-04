using Microsoft.Reporting.WinForms;
using Pedidos.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class FrmRelatorioFornecedor : Form
    {
        DataTable dt = new DataTable();
        public FrmRelatorioFornecedor(DataTable dt)
        {
            InitializeComponent();
            reportViewerFornecedor.LocalReport.ReportEmbeddedResource =
             "Pedidos.RelatorioFornecedor.rdlc";

            reportViewerFornecedor.RefreshReport();
        }

        private void FrmRelatorioFornecedor_Load(object sender, EventArgs e)
        {
            RelatorioBo relatorioBo = new RelatorioBo();
            reportViewerFornecedor.LocalReport.DataSources.Clear();

            ReportDataSource dsReport = new ReportDataSource();
            dt = relatorioBo.RelatorioFornecedor();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);

            reportViewerFornecedor.LocalReport.DataSources.Add(source);
            reportViewerFornecedor.RefreshReport();
        }
    }
}
