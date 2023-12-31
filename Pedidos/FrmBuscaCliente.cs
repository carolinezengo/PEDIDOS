﻿using Pedidos.BLL;
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

    
        private ClienteBo _clienteBo;
        public FrmBuscaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Carregargrid();


        }
        //Carregar a Gridview Pelo Nome do Cliente
        public void Carregargrid()
        {
            var nome = TxtNome.Text;

            List<Cliente> listacliente = new BLL.ClienteBo().SelecionarClientePorNome(nome);
            DgCliente.DataSource = listacliente;


        }


        private void FrmBuscaCliente_Load(object sender, EventArgs e)
        {
            FrmMenu menu
               = new FrmMenu();
            menu.Close();
            string strWhere = "";
            //Carregar a Gridview de Cadastro Cliente
            List<Cliente> listacliente = new BLL.ClienteBo().CarregarGrid(strWhere);
            DgCliente.DataSource = listacliente;


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenu tela = new FrmMenu();
            tela.Show();
        }

        private void DgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmCadClientes cliente = new FrmCadClientes();
            cliente.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


}







