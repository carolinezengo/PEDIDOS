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
    public partial class FrmBuscarFornecedor : Form
    {
        private Fornecedor _fornecedorBo;

        public FrmBuscarFornecedor()
        {
            InitializeComponent();
        }

        private void FrmBuscarFornecedor_Load(object sender, EventArgs e)
        {

            FrmMenu menu
               = new FrmMenu();
            menu.Close();
            string strWhere = "";
            //Carregar a GriView do Cadastro de Fornecedores
            List<Fornecedor> listafornecedor = new BLL.FornecedorBo().CarregarGrid(strWhere);

            DgFornecedor.DataSource = listafornecedor;
        }
        // Carregar a GridView Com Nome Solicitado do Fornecedor
        public void Carregargrid()
        {
            string nome = TxtFornecedor.Text;

           FornecedorBo _fornecedorBo = new FornecedorBo();

            List<Fornecedor> listafornecedor = new List<Fornecedor>();
            listafornecedor = _fornecedorBo.SelecionarFornecedorPorNome(nome);  
            DgFornecedor.DataSource = listafornecedor;


        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Carregargrid();
        }
    }
}
