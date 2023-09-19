using Pedidos.Entities;
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
    public partial class FrmBuscarFornecedor : Form
    {
        public FrmBuscarFornecedor()
        {
            InitializeComponent();
        }

        private void FrmBuscarFornecedor_Load(object sender, EventArgs e)
        {

            FrmMenu menu
               = new FrmMenu();
            menu.Close();
            string strWhere = "";
            List<Fornecedor> listafornecedor = new BLL.FornecedorBo().CarregarGrid(strWhere);

                DgFornecedor.DataSource = listafornecedor;
        }
    }
}
