using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Pedidos.BLL;
using Pedidos.FaturamentoDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Pedidos
{
    public partial class FrmRelatorioCliente : Form
    {
        DataTable dt = new DataTable();
        public FrmRelatorioCliente(DataTable dt)



        {

            InitializeComponent();


            reportViewerCliente.LocalReport.ReportEmbeddedResource =
             "Pedidos.RelatorioCliente.rdlc";
            
            // reportViewerCliente.RefreshReport();
        }

        private void btnrelatorio_Click(object sender, EventArgs e)
        {

        }

        private void FrmRelatorioCliente_Load(object sender, EventArgs e)
        {


            
           RelatorioBo relatorioBo = new RelatorioBo();
            reportViewerCliente.LocalReport.DataSources.Clear();
           
            ReportDataSource dsReport = new ReportDataSource();
            dt = relatorioBo.Relatorio();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            
            reportViewerCliente.LocalReport.DataSources.Add(source);
            reportViewerCliente.RefreshReport();
        }

        private void reportViewerCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
