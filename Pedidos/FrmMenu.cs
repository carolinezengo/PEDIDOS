﻿using System;
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

        private void buscarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarFornecedor fornecedor = new FrmBuscarFornecedor();
            fornecedor.Show();
            Close();
        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadProduto produto = new FrmCadProduto();
            produto.Show();
            Close();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculadora calc = new FrmCalculadora();
            calc.Show();
            Close();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadPedido pedido = new FrmCadPedido();
            pedido.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarPedido pedido = new FrmBuscarPedido();
            pedido.Show();

        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatorioDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = GerarRelatorioCliente();
            using (var frm = new FrmRelatorioCliente(dt))
            {
                frm.ShowDialog();
            }

        }


        private DataTable GerarRelatorioCliente()
        {
            var dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Nome");
            dt.Columns.Add("CPF");


            return dt;
        }

        private DataTable GerarRelatorioFornecedor()
        {
            var dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Nome");
            dt.Columns.Add("CNPJ");
            dt.Columns.Add("tel");



            return dt;
        }

        private void relatorioDeFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var dt = GerarRelatorioFornecedor();
            using (var frm = new FrmRelatorioFornecedor(dt))
            {
                frm.ShowDialog();
            }

        }
        private DataTable GerarRelatorioProduto()
        {
            var dt = new DataTable();
            dt.Columns.Add("idproduto", typeof(int));
            dt.Columns.Add("descricao");
            dt.Columns.Add("quantidade");
            dt.Columns.Add("valor_unitario");



            return dt;
        }

        private void relatorioDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = GerarRelatorioProduto();
            using (var frm = new FrmRelatorioProduto(dt))
            {
                frm.ShowDialog();
            }
        }
    }
}
