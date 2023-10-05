using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.DAO
{
   
    public class RelatorioDAO
    {
        SqlCommand command = new SqlCommand();
        ConexaoDAO conexao = new ConexaoDAO();
       
        public String mensagem = "";

        public DataTable RelatorioRelacaoCliente()
        {

            DataTable dt = new DataTable();
            command.Connection = conexao.Conectar();
            SqlDataAdapter relatorio = new SqlDataAdapter("Select id, nome, data_nasc, cpf, tel from tabcliente",command.Connection);
                           
                       
            relatorio.Fill(dt); 
            relatorio.Dispose();        
            return dt;



        }
           public DataTable RelatorioFornecedor()
        {

            DataTable dt = new DataTable();
            command.Connection = conexao.Conectar();
            SqlDataAdapter relatorio = new SqlDataAdapter("Select id, nome, cnpj,  tel from tabfornecedor", command.Connection);


            relatorio.Fill(dt);
            relatorio.Dispose();
            return dt;



        }
        public DataTable RelatorioProduto()
        {

            DataTable dt = new DataTable();
            command.Connection = conexao.Conectar();
            SqlDataAdapter relatorio = new SqlDataAdapter("Select idproduto, descricao, quantidade, valor_unitario from tabproduto", command.Connection);


            relatorio.Fill(dt);
            relatorio.Dispose();
            return dt;



        }

    }
}
