using Pedidos.BLL;
using Pedidos.Entities;
using System.Data;

namespace Pedidos
{
    public partial class FrmCadPedido : Form
    {
        private string mesagemDeSucesso = "";
        private PedidoBo _pedidoBo;
        private ClienteBo _clienteBo;



        public ProdutoBo _produtoBo;
        double total, total1;
        int quant;
        double valoruni = 0;
        string operacao = "", operacao1 = "";


        DataTable dt = new DataTable();


        public FrmCadPedido()
        {
            InitializeComponent();
            CarregargridProduto();
            CarregarDadosProdutos();
            CarregarClientes();
            MakeReadOnly();


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

            TxtDataCompra.Enabled = false;
            TxtProduto.Enabled = false;
            Txtquat.Enabled = false;
            CboCliente.Enabled = false;
            lblcodcliente.Enabled = false;
            lblcodcliente.Text = "";


            FrmMenu menu
               = new FrmMenu();
            menu.Close();
        }


        // Carregar a gridview de pedido
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

        private Entities.Pedidos ObterModeloPreenchidoGravar()
        {
            var pedido = new Entities.Pedidos();


            pedido.codproduto = Convert.ToInt32(LblCodProduto.Text);
            pedido.codcliente = Convert.ToInt32(lblcodcliente.Text);
            pedido.DataCompra = string.IsNullOrWhiteSpace(TxtDataCompra.Text) ? (DateTime?)null : Convert.ToDateTime(TxtDataCompra.Text);
            pedido.Quantidade = Convert.ToInt32(Txtquat.Text);
            pedido.ValorUnitario = Convert.ToDouble(TxtValorUnitario.Text);
            pedido.ValorTotal = Convert.ToDouble(TxtTotal.Text);
            pedido.Situacao = TxtSituacao.Text.ToString();

            return pedido;
        }
        // Carregar GridView De produto
        public void CarregargridProduto()
        {
            _produtoBo = new ProdutoBo();
            string strWhere = "";

            List<Produto> listaProduto = new BLL.ProdutoBo().CarregarGrid(strWhere);
            DgProduto.DataSource = listaProduto;


        }

        private void MakeReadOnly()
        {
            DgProduto.AllowUserToAddRows = false;
            DgProduto.AllowUserToDeleteRows = false;
            DgProduto.ReadOnly = true;
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
            FrmBuscaCliente cliente = new FrmBuscaCliente();
            cliente.Show();
        }

        // Carregar dados Da GridViiew de Produtos

        private void CarregarDadosProdutos()
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
            testequantuida();


            if (Rbtnmais.Checked == true)
            {
                total1 = (quant * valoruni);
                total = (total + total1);
                TxtTotal.Text = Convert.ToDouble(total).ToString();
                DgPDV.Rows.Add(TxtProduto.Text, Txtquat.Text, TxtValorUnitario.Text, total1);

            }
            else if (Rbtnmenos.Checked == true)

            {
                DgPDV.Rows.RemoveAt(DgPDV.CurrentRow.Index);
                total = total - total1;
                TxtTotal.Text = total.ToString();
            }


        }

        private void testequantuida()
        {
            quant = Convert.ToInt32(Txtquat.Text);
            if (quant > 0)
            {

                quant = Convert.ToInt32(Txtquat.Text);
                valoruni = Convert.ToDouble(TxtValorUnitario.Text);
            }
            else
            {
                MessageBox.Show("Produto sem quantidade");
            }
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)

        {


        }

        private void liberarFormulario()
        {
            if (RBtnOrc.Checked == true)
            {
                TxtDataCompra.Enabled = true;
                TxtProduto.Enabled = true;
                Txtquat.Enabled = true;
                CboCliente.Enabled = true;
               
                TxtSituacao.Text = "Orçamento";
            }
            else if (RbtnFat.Checked == true)
            {

                TxtDataCompra.Enabled = true;
                TxtProduto.Enabled = true;
                Txtquat.Enabled = true;
                CboCliente.Enabled = true;
            
                TxtSituacao.Text = "Faturado";

            }
        }



        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
        //limpar os campos
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

        //Botao de Alterar o pedido
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

        //Preencher os campos com dados da Classe Pedido
        private Entities.Pedidos ObterModeloPreenchido()
        {
            var pedido = new Entities.Pedidos();

            pedido.codcliente = Convert.ToInt32(lblcodcliente.Text);
            pedido.codproduto = Convert.ToInt32(LblCodProduto.Text);
            pedido.DataCompra = string.IsNullOrWhiteSpace(TxtDataCompra.Text) ? (DateTime?)null : Convert.ToDateTime(TxtDataCompra.Text);
            pedido.Quantidade = Convert.ToInt32(Txtquat.Text);
            pedido.ValorUnitario = Convert.ToDouble(TxtValorUnitario.Text);
            pedido.ValorTotal = Convert.ToDouble(TxtTotal.Text);
            pedido.Situacao = TxtSituacao.Text.ToString();

            return pedido;
        }



        // Carregar a lista de Cliente
        private void CarregarClientes()
        {


            _clienteBo = new ClienteBo();
            List<Cliente> listacliente = new BLL.ClienteBo().ObterClientes();
            CboCliente.DataSource = listacliente;
          CboCliente.DisplayMember = "nome";
           CboCliente.ValueMember = "id";

           //string selected =this.CboCliente.SelectedValue.ToString();
          //  lblcodcliente.Text = selected;
             
            // lblcodcliente.Text = CboCliente.ValueMember.ToString();    
            // CboCliente.ValueMember = "id";
            //   for (int item = 0; item < listacliente.Count; item++)
            //{
             //   CboCliente.DataSource = listacliente;
             //  CboCliente.DisplayMember = "nome";

             // lblcodcliente.Text = Convert.ToInt32(listacliente[item].Id).ToString();
//
        //    }
           


        }
        // Botao Salvar o Pedido
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            _pedidoBo = new PedidoBo();

            var pedido = ObterModeloPreenchidoGravar();


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

        // Carregar a situação que o pedido se encontra


        // Botao Buscar por um pedido

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarPedido pedido = new FrmBuscarPedido();
            pedido.Show();

        }

        private void RbtnFat_CheckedChanged(object sender, EventArgs e)
        {
            liberarFormulario();
        }

        private void RBtnOrc_CheckedChanged(object sender, EventArgs e)
        {
            liberarFormulario();
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)

        {
            
            lblcodcliente.Text = CboCliente.SelectedValue.ToString();
        }
    }

}
