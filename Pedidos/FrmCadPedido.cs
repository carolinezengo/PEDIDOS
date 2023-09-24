using Pedidos.BLL;
using Pedidos.DAO;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pedidos
{
    public partial class FrmCadPedido : Form
    {
        private string mesagemDeSucesso = "";
        private PedidoBo _pedidoBo;
        private ClienteBo _clienteBo;



        public ProdutoBo _produtoBo;
        double total = 0, total1 = 0;
        int quant = 0;
        double valoruni = 0;
        string operacao = "", operacao1 = "";

        DataTable dt = new DataTable();


        public FrmCadPedido()
        {
            InitializeComponent();
            Carregargrid();
            CarregarDados();
            CarregarClientes();
            Carregarsituacao();

            FrmBuscarPedido pedido = new FrmBuscarPedido();


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
            FrmMenu menu
               = new FrmMenu();
            menu.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void listBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgProduto.SelectedRows.Count >= 0)
                {
                    TxtProduto.Text = DgProduto.SelectedRows[0].Cells[0].Value.ToString();
                    TxtValorUnitario.Text = DgProduto.SelectedRows[0].Cells[3].Value.ToString();
                    LblCodProduto.Text = DgProduto.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campo Invalido");
            }
        }
        public void Carregargrid()
        {
            _produtoBo = new ProdutoBo();
            string strWhere = "";

            List<Produto> listaProduto = new BLL.ProdutoBo().CarregarGrid(strWhere);
            DgProduto.DataSource = listaProduto;


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
            FrmBuscaCliente cliente = new FrmBuscaCliente();
            cliente.Show();
        }
        private void CarregarDados()
        {
            DgPDV.ColumnCount = 4;
            DgPDV.Columns[0].Name = "Produto";
            DgPDV.Columns[1].Name = "Quantidade";
            DgPDV.Columns[2].Name = "Valor Unitario";
            DgPDV.Columns[3].Name = "Valor Total";

            DgPDV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgPDV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgPDV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgPDV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quant > 0)
            {

                quant = Convert.ToInt32(Txtquat.Text);
                valoruni = Convert.ToDouble(TxtValorUnitario.Text);
            }
            else
            {
                MessageBox.Show("Produto sem quantidade");
            }



            if (operacao == "adicionar")
            {
                total1 = (quant * valoruni);
                total = total + total1;
                TxtTotal.Text = total.ToString();
                DgPDV.Rows.Add(TxtProduto.Text, Txtquat.Text, TxtValorUnitario.Text, TxtTotal.Text);
            }
            else

            if (operacao == "deletar")

            {
                DgPDV.Rows.RemoveAt(DgPDV.CurrentRow.Index);
                total = total - total1;
                TxtTotal.Text = total.ToString();
            }





        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }



        private void Rbtnmais_CheckedChanged(object sender, EventArgs e)
        {
            TxtTotal.Text = "";
            operacao = "adicionar";
        }

        private void Rbtnmenos_CheckedChanged(object sender, EventArgs e)
        {
            TxtTotal.Text = "";
            operacao = "deletar";
        }

        private void RbtnFat_CheckedChanged(object sender, EventArgs e)
        {

            TxtSituacao.Text = "";
            operacao1 = "Faturado";
        }

        private void RBtnOrc_CheckedChanged(object sender, EventArgs e)
        {
            TxtSituacao.Text = "";
            operacao1 = "Orcamento";
        }

        private void TxtSituacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
        private void LimparTela()
        {

            TxtNumero.Clear();
            CboCliente.Items.Clear();
            TxtDataCompra.Clear();
            Txtquat.Clear();
            TxtSituacao.Clear();
            TxtTotal.Clear();
            TxtTotal.Clear();
            TxtProduto.Clear();
            DgPDV.Rows.Clear();
            DgProduto.Rows.Clear();

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            string operacao = "";
            operacao = TxtSituacao.Text;
            if (operacao == "Orcamento")
            {
                var pedido = ObterModeloPreenchido();
                _pedidoBo.AlterarPedido(pedido);

                mesagemDeSucesso = "Pedido do cliente alterado com Sucesso!";

                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = mesagemDeSucesso;
            }
            else
            if (operacao == "Faturamento")
            {
                BtnAlterar.Enabled = false;
            }
        }
        private Entities.Pedido ObterModeloPreenchido()
        {
            var pedido = new Entities.Pedido();

            pedido.IdCliente = Convert.ToInt32(CboCliente.SelectedValue);
            pedido.IdProduto = Convert.ToInt32(LblCodProduto.Text);
            pedido.DataCompra = string.IsNullOrWhiteSpace(TxtDataCompra.Text) ? (DateTime?)null : Convert.ToDateTime(TxtDataCompra.Text);
            pedido.Quantidade = Convert.ToInt32(Txtquat.Text);
            pedido.ValorUnitario = Convert.ToDouble(TxtValorUnitario.Text);
            pedido.ValorTotal = Convert.ToDouble(TxtTotal.Text);
            pedido.Situacao = TxtSituacao.Text.ToString();

            return pedido;
        }

        private void TxtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarregarClientes()
        {


            _clienteBo = new ClienteBo();
            List<Cliente> listacliente = new BLL.ClienteBo().ObterClientes();
            CboCliente.DataSource = listacliente;
            CboCliente.DisplayMember = "nome";
            CboCliente.ValueMember = "id";


        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            _pedidoBo = new PedidoBo();
            var pedido = ObterModeloPreenchido();


            try
            {
                _pedidoBo.Cadastrar(pedido);

                mesagemDeSucesso = "Cliente Cadastrado com sucesso!";

                mesagemDeSucesso = "Pedido Cadastrado com sucesso!";

                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = mesagemDeSucesso;
            }
            catch
            {
                MessageBox.Show("Erro ao gravar!");
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            string txt = TxtSituacao.Text;
            if (txt == "Orcamento")
            {
                _pedidoBo.DeletarPedido(Convert.ToInt32(TxtNumero.Text));
            }
            else
            {
                MessageBox.Show("Pedido já foi Faturado");
            }
            LimparTela();

        }

        private void Carregarsituacao()
        {
            if (operacao1 == "Faturado")
            {
                TxtSituacao.ForeColor = System.Drawing.Color.Red;
                TxtSituacao.Text = "Faturado";
            }
            else
          if (operacao1 == "Orcamento")

            {
                TxtSituacao.ForeColor = System.Drawing.Color.Green;
                TxtSituacao.Text = "Orçamento";
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarPedido pedido = new FrmBuscarPedido();
            pedido.Show();

        }

        private void DgPDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
