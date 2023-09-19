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
        SqlDataReader reader;
        public String mensagem = "";

        public DataTable Relatorio()
        {

            DataTable dt = new DataTable();
            command.Connection = conexao.Conectar();
            SqlDataAdapter relatorio = new SqlDataAdapter("Select id, nome, data_nasc, cpf, tel from tabcliente",command.Connection);
                           
                       
            relatorio.Fill(dt); 
            relatorio.Dispose();        
            return dt;



        }

    }
}
