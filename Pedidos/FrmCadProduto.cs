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
    public partial class FrmCadProduto : Form
    {
        public String mesagemDeSucesso = "";
        private ProdutoBo _produtoBo;
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
        private void LimparTela()
        {

            TxtCodigo.Clear();
            TxtNome.Clear();
            Txtquant.Clear();
            TxtCodFornec.Clear();

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            _produtoBo = new ProdutoBo();
            var produto = ObterModeloPreenchido();


            try
            {

                _produtoBo.Cadastrar(produto);
                mesagemDeSucesso = "Produto Cadastrado com sucesso!";

                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = mesagemDeSucesso;
            }
            catch
            {
                MessageBox.Show("Erro ao gravar!");
            }
        }

        private Produto ObterModeloPreenchido()
        {
            var produto = new Produto();
            produto.Nome = TxtNome.Text;
            produto.quantida = Convert.ToInt32(Txtquant.Text);
            produto.codFornecedor = Convert.ToInt32(TxtCodFornec.Text);



            return produto;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();

        }
    }
}
