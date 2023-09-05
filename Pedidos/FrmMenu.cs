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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            Close();


        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCadClientes cliente = new FrmCadClientes();
            cliente.Show();
            Close();

        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscaCliente cliente = new FrmBuscaCliente();
            cliente.Show();
            Close();
        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor fornecedor = new FrmCadFornecedor();
            fornecedor.Show();

            Close();
        }
    }
}
