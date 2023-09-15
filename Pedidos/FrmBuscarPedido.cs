using Pedidos.DAO;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class FrmBuscarPedido : Form
    {
        string operacao = "";
        public FrmBuscarPedido()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmBuscarPedido_Load(object sender, EventArgs e)
        {
            string strWhere;
            strWhere = "";

            List<Entities.Pedidos> listapedido = new BLL.PedidoBo().CarregarGrid(strWhere);

            DGPDV.DataSource = listapedido;
            FormatDG();


        }

        private void RbtNome_CheckedChanged(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            operacao = "Nome";
        }

        private void RbtNumero_CheckedChanged(object sender, EventArgs e)
        {
            TxtNumero.Text = "";
            operacao = "Numero";
        }

        private void DGPDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* private void BtnPesquisar_Click(object sender, EventArgs e)
         {
             if(operacao == "Numero")
             {
                 var nome = TxtNumero.Text;
                 List<Pedido> listapedido = new BLL.PedidoBo().SelecionarPedidoClientePorNome(nome);
                 DGPDV.DataSource = listapedido;
             }
             else
                 if(operacao == "Nome")
             {
                 var nome = TxtNome.Text;
                 List<Pedido> listapedido = new BLL.PedidoBo().SelecionarPedidoClientePorNome(nome);
                DGPDV.DataSource = listapedido;
             }

         }*/

        private void FormatDG()
        {
            DGPDV.Columns[0].HeaderText = "Numero Pedido";
            DGPDV.Columns[1].HeaderText = "Nome Cliente";
            DGPDV.Columns[2].HeaderText = "Valor Total";
            DGPDV.Columns[3].HeaderText = "Data Compra";
            DGPDV.Columns[4].HeaderText = "Situacao";
               

        }

    }
}
