using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.DAO
{

    public class ConexaoDAO
    {
       
        SqlConnection connection = new SqlConnection();


        public ConexaoDAO()
        {
           connection.ConnectionString = @"Data Source=desktop-k3imdmf\sqlexpress;Initial Catalog=Faturamento;Persist Security Info=True;User ID=sa;Password=050404";

        }
        public SqlConnection  Conectar()
        {

            if (connection.State == System.Data.ConnectionState.Closed)
            {

                connection.Open();

            }
            return connection;
        }
        public  void Desconectar()
        {

            if (connection.State == System.Data.ConnectionState.Open)
            {

                connection.Close();

            }
        }
    }
}
