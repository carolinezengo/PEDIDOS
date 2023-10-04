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

        //Carregar dados GridView de Pedido
      private void FormatDG()
        {
         
            DGPDV.Columns[0].HeaderText = "Numero Pedido";
            DGPDV.Columns[1].HeaderText = "Codigo Cliente";
            DGPDV.Columns[2].HeaderText = "Nome Cliente";
            DGPDV.Columns[3].HeaderText = "Quantidade";
            DGPDV.Columns[4].HeaderText = "Codigo Do Produto";   
            DGPDV.Columns[5].HeaderText = "NDescricao";
            DGPDV.Columns[6].HeaderText = "Valor Unitario";
            DGPDV.Columns[7].HeaderText = "Valor Total";
            DGPDV.Columns[8].HeaderText = "Data Compra";
            DGPDV.Columns[9].HeaderText = "Situacao";

           DGPDV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGPDV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           DGPDV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           DGPDV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGPDV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGPDV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGPDV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGPDV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGPDV.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGPDV.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           

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
              
            }
            else
     if (operacao == "Nome")
            {
                var nome = TxtNome.Text;
                List<Entities.Pedidos> listapedido = new BLL.PedidoBo().SelecionarClientePorNome(nome);
                DGPDV.DataSource = listapedido;
             
            }
        }


        private void MakeReadOnly()
        {
            DGPDV.AllowUserToAddRows = false;
            DGPDV.AllowUserToDeleteRows = false;
            DGPDV.ReadOnly = true;
        }


        // Ao clicar na linha da GriView envia as  informacoes para Cadastro de Pedido 
        private void DGPDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int b1 = 0;
            double b2 = 0, b3 = 0;
            string situacao;
            FormatDG();
            

            FrmCadPedido pedido = new FrmCadPedido();
            
            pedido.TxtNumero.Text = this.DGPDV.CurrentRow.Cells[0].Value.ToString();
            pedido.lblcodcliente.Text = this.DGPDV.CurrentRow.Cells[1].Value.ToString();
            pedido.CboCliente.Text = this.DGPDV.CurrentRow.Cells[2].Value.ToString();
            pedido.Txtquat.Text = this.DGPDV.CurrentRow.Cells[3].Value.ToString();
            pedido.LblCodProduto.Text = this.DGPDV.CurrentRow.Cells[4].Value.ToString();    
            pedido.TxtProduto.Text = this.DGPDV.CurrentRow.Cells[5].Value.ToString();



            // Precher a Grid no PDV com os produtos Solicitados
           
               // for (int i = 0; i < DGPDV.Rows.Count; i++)
               // {
               int i= 0;
                while (i < DGPDV.Rows.Count)
                {
                    if (DGPDV.Rows[i].Cells[0].Value.ToString() == pedido.TxtNumero.Text)
                    {
                        pedido.DgPDV.Rows[i].Cells[0].Value = DGPDV.Rows[i].Cells[5].Value;
                        pedido.DgPDV.Rows[i].Cells[1].Value = DGPDV.Rows[i].Cells[3].Value;
                        pedido.DgPDV.Rows[i].Cells[2].Value = DGPDV.Rows[i].Cells[6].Value;

                        b1 += Convert.ToInt32(DGPDV.Rows[i].Cells[3].Value);
                        b2 += Convert.ToDouble(DGPDV.Rows[i].Cells[6].Value);
                        b3 += b1 * b2;
                        pedido.DgPDV.Rows[i].Cells[3].Value = b3;
                    }

                  i++;
                }

            

            pedido.TxtTotal.Text = this.DGPDV.CurrentRow.Cells[7].Value.ToString();
            pedido.TxtDataCompra.Text = this.DGPDV.CurrentRow.Cells[8].Value.ToString();
            pedido.TxtSituacao.Text = this.DGPDV.CurrentRow.Cells[9].Value.ToString();

           

            pedido.ShowDialog();


                    }


    }
}
