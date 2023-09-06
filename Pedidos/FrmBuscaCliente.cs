using Pedidos.BLL;
using Pedidos.DAO;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Reflection;
using System.Data.Common;

namespace Pedidos
{
    public partial class FrmBuscaCliente : Form
    {

        ConexaoDAO conexao = new ConexaoDAO();
        private ClienteBo _clienteBo;
        public FrmBuscaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _clienteBo = new ClienteBo();
           

            

                Carregargrid();
          

            


        }
        public void Carregargrid()
        {
            var nome = TxtNome.Text;

            List<Cliente> listacliente = new BLL.ClienteBo().SelecionarClientePorNome(nome);
            DgCliente.DataSource = listacliente;


        }


        private void FrmBuscaCliente_Load(object sender, EventArgs e)
        {
            string strWhere = "";
            List<Cliente> listacliente = new BLL.ClienteBo().CarregarGrid(strWhere);
            DgCliente.DataSource = listacliente;


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenu tela = new FrmMenu();   
            tela.Show();
        }
    }


}







