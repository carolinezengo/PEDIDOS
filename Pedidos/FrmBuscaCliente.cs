using Pedidos.BLL;
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
    public partial class FrmBuscaCliente : Form
    {
        private ClienteBo _clienteBo;
        public FrmBuscaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //  {
            //      _clienteBo = new ClienteBo();
            //
            //    String nome = TxtNome.Text;

            //     if (_clienteBo.cliente)
            //    {
            //       MessageBox.Show("Cleinte Encontrado!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     FrmMenu menu = new FrmMenu();
            //        dgCliente.DataSource = _clienteBo.BuscarPorNome(nome);


            //    }
            //     else
            //    {
            //         MessageBox.Show("Não ha cadastro desse cliente!", "Atenção", MessageBoxButtons.OK);
            //      }
            //
            // }
            // catch (Exception erro)
            //  {

            //     throw erro;
            // }

            _clienteBo = new ClienteBo();
          
       
        }


      
        //    private void textBox1_TextChanged(object sender, EventArgs e)
        // {

        // }
    }
}
