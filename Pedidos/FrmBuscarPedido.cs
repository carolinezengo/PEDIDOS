using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
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
            MakeReadOnly();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmBuscarPedido_Load(object sender, EventArgs e)
        {

            FrmMenu menu
               = new FrmMenu();
            menu.Close();
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
            try
            {
                string pedido = DGPDV.CurrentRow.Cells[0].Value.ToString();

                FrmCadPedido frmImagem = new FrmCadPedido();
                frmImagem.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void FormatDG()
        {
            DGPDV.Columns[0].HeaderText = "Numero Pedido";
            DGPDV.Columns[1].HeaderText = "Nome Cliente";
            DGPDV.Columns[2].HeaderText = "Valor Total";
            DGPDV.Columns[3].HeaderText = "Data Compra";
            DGPDV.Columns[4].HeaderText = "Situacao";
            DGPDV.Columns[5].HeaderText = "Produto";
            DGPDV.Columns[6].HeaderText = "Quantidade";

            DGPDV.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGPDV.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGPDV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGPDV.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGPDV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGPDV.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGPDV.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void BtnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (operacao == "Numero")
            {
                int numero = Convert.ToInt32(TxtNumero.Text);
                List<Entities.Pedidos> listapedido = new BLL.PedidoBo().SelecionarClientePorNumero(numero);
                DGPDV.DataSource = listapedido;
                FormatDG();
            }
            else
     if (operacao == "Nome")
            {
                var nome = TxtNome.Text;
                List<Entities.Pedidos> listapedido = new BLL.PedidoBo().SelecionarClientePorNome(nome);
                DGPDV.DataSource = listapedido;
                FormatDG();
            }
        }

        private void MakeReadOnly()
        {
            DGPDV.AllowUserToAddRows = false;
            DGPDV.AllowUserToDeleteRows = false;
            DGPDV.ReadOnly = true;
        }

       

        private void DGPDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCadPedido pedido = new FrmCadPedido();
            pedido.TxtNumero.Text = this.DGPDV.CurrentRow.Cells[0].Value.ToString();
            pedido.CboCliente.Text = this.DGPDV.CurrentRow.Cells[1].Value.ToString();
            pedido.TxtTotal.Text =  this.DGPDV.CurrentRow.Cells[2].Value.ToString();
            pedido.TxtDataCompra.Text = this.DGPDV.CurrentRow.Cells[3].Value.ToString();
            pedido.TxtSituacao.Text = this.DGPDV.CurrentRow.Cells[4].Value.ToString();
            pedido.TxtProduto.Text = this.DGPDV.CurrentRow.Cells[5].Value.ToString();
            pedido.Txtquat.Text = this.DGPDV.CurrentRow.Cells[6].Value.ToString();
            pedido.ShowDialog();
        
        
        
        }
    }
}
