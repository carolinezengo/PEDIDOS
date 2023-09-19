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
    public partial class FrmBuscaProduto : Form
    {
        public FrmBuscaProduto()
        {
            InitializeComponent();
        }

        private void FrmBuscaProduto_Load(object sender, EventArgs e)
        {
            FrmMenu menu
               = new FrmMenu();
            menu.Close();
        }
    }
}
