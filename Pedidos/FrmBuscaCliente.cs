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

           
            var nome = TxtNome.Text;

            SqlCommand command = new SqlCommand("Select * from tabcliente where nome = @nome");
            command.Parameters.AddWithValue("@nome", nome);
            command.Connection = conexao.Conectar();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DgCliente.DataSource = dt;

        }

        private void FrmBuscaCliente_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from tabcliente");
            command.Connection = conexao.Conectar();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            DgCliente.DataSource = dt;

        }

    }


}







