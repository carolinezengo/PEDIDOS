using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.DAO
{
   public class PedidosDAO

    {
        SqlCommand command = new SqlCommand();
        ConexaoDAO conexao = new ConexaoDAO();
        SqlDataReader reader;
        public String mensagem = "";
        public int AtualizarPedido(Pedido pedido)
        {
            try
            {

                command.CommandText = @"UPDATE[dbo].[tabpedido]
                                        SET [data_comp] = @data_comp
                                       ,[produto] = @produto
	                                   ,[quantidade] = @quantidade
                                       ,[valortotal] = @valortotal
                                       ,[situacao] = @situacao
                                         WHERE id = @id";


                command.Parameters.AddWithValue("@id", pedido.Id);
                command.Parameters.AddWithValue("@data_comp", pedido.DataCompra);
                command.Parameters.AddWithValue("@produto", pedido.Produto);
                command.Parameters.AddWithValue("@quantidade", pedido.Quantidade);
                command.Parameters.AddWithValue("@valortotal", pedido.ValorTotal);
                command.Parameters.AddWithValue("@situacao", pedido.Situacao);
             

                command.Connection = conexao.Conectar();
                return command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }


    }
}
