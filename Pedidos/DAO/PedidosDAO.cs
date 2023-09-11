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

                command.CommandText = @"UPDATE[dbo].[tabpedidos]
                                        SET [data_comp] = @data_comp
                                       ,[codproduto] = @codproduto
	                                   ,[quantidade] = @quantidade
                                       ,[valortotal] = @valortotal
                                       ,[situacao] = @situacao
                                         WHERE id = @id";


                command.Parameters.AddWithValue("@id", pedido.Id);
                command.Parameters.AddWithValue("@data_comp", pedido.DataCompra);
                command.Parameters.AddWithValue("@codproduto", pedido.IdProduto);
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
        public List<Pedido> CarregarGrid(string strWhere)
        {
            List<Pedido> listapedido = new List<Pedido>();
            Pedido pedido = null;


            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            StringBuilder sb = new StringBuilder();
            sb.Append("Select * from tabpedidos ")
             .Append("" + strWhere + " ")
             .Append("ORDER BY nomecliente");
            SqlCommand cmd = new SqlCommand(sb.ToString());

            try
            {
                cmd.Connection = conexao.Conectar();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pedido = new Pedido();

                    pedido.Id = Convert.ToInt32(reader["id"]);
                    pedido.IdCliente = Convert.ToInt32(reader["codcliente"]);
                    pedido.IdProduto = Convert.ToInt32(reader["codproduto"]);
                    pedido.DataCompra = reader["data_comp"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_comp"]);
                    pedido.Quantidade = Convert.ToInt32(reader["quantidade"]);
                    pedido.ValorUnitario = Convert.ToDouble(reader["valorunitario"]);
                    pedido.ValorTotal = Convert.ToDouble(reader["valortotal"]);
                    pedido.Situacao = reader["situacao"].ToString();

                    if (listapedido == null)
                        listapedido = new List<Pedido>();

                    listapedido.Add(pedido);

                }

                return listapedido;

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

        public String InserirPedido(Pedido pedido)
        {
            if (pedido.Equals(pedido))
            {
                command.CommandText = @"INSERT INTO[dbo].[tabpedidos]
                                       ([codcliente]
                                        ,[codproduto]
                                        ,[quantidade]
                                        ,[valorunitario]
                                        ,[valortotal]
                                        ,[situacao]
                                        ,[data_comp])
                                  VALUES
                                      (@codcliente, 
                                      @codproduto
                                      ,@quantidade
                                      ,@valorunitario
                                      ,@valortotal
                                      ,@situacao
                                      ,@data_comp)";
                command.Parameters.AddWithValue("@codcliente", pedido.IdCliente);
                command.Parameters.AddWithValue("@data_comp", pedido.DataCompra);
                command.Parameters.AddWithValue("@codproduto", pedido.IdProduto);
                command.Parameters.AddWithValue("@quantidade", pedido.Quantidade);
                command.Parameters.AddWithValue("@valorunitario", pedido.ValorUnitario);
                command.Parameters.AddWithValue("@valortotal", pedido.ValorTotal);
                command.Parameters.AddWithValue("@situacao", pedido.Situacao);
               
                try
                {

                    command.Connection = conexao.Conectar();
                    command.ExecuteNonQuery();
                    conexao.Desconectar();


                    this.mensagem = "Pedido cadastrado com sucesso";

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro Banco de dados";
                }

            }
            else
            {
                this.mensagem = "Pedido nao corresponde!";
            }

            return mensagem;



        }

    }
}
