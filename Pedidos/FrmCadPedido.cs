using Pedidos.BLL;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class FrmCadPedido : Form
    {

        private ProdutoBo _produtoBo;
        public FrmCadPedido()
        {
            InitializeComponent();
            Carregargrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBuscaProduto produto = new FrmBuscaProduto();
            produto.Show(this);

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void FrmCadPedido_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void listBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

       

           
        }

        public void Carregargrid()
        {
            _produtoBo = new ProdutoBo();
            string strWhere = "";

            List<Produto> listaProduto = new BLL.ProdutoBo().CarregarGrid(strWhere);
            GDProdutos.DataSource = listaProduto;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
            FrmBuscaCliente cliente = new FrmBuscaCliente();
            cliente.Show();
        }

        public void CarregarDadosParaEdicao()
        {
            _produtoBo = new ProdutoBo();
            string nome = TxtProduto.Text;

            var produto = _produtoBo.ObterprodutoPeloNome(nome);

            TxtProduto.Text = produto.Nome;
           
            Txtquat.Text = Convert.ToString(produto.quantida);
            TxtValorUnitario.Text = Convert.ToString(produto.valor_unitario);
            

        }
    }
}
