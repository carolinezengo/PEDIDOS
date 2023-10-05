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
    public partial class FrmRelatorioProduto : Form
    {
        DataTable dt = new DataTable();
        public FrmRelatorioProduto(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            reportViewerProduto.LocalReport.ReportEmbeddedResource =
             "Pedidos.RelatorioProduto.rdlc";
        }

        private void FrmRelatorioProduto_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void FrmRelatorioProduto_Load(object sender, EventArgs e)
        {

            RelatorioBo relatorioBo = new RelatorioBo();
            reportViewerProduto.LocalReport.DataSources.Clear();

            ReportDataSource dsReport = new ReportDataSource();
            dt = relatorioBo.RelatorioProduto();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);

            reportViewerProduto.LocalReport.DataSources.Add(source);
            reportViewerProduto.RefreshReport();
        }
    }
}
