using Pedidos.BLL;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
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

        public int AtualizarPedido(Entities.Pedido pedido)
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
        public List<Entities.Pedidos> CarregarGrid(string strWhere)
        {

            List<Entities.Pedidos> listapedido = new List<Entities.Pedidos>();
            Entities.Pedidos pedido = null;


            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            StringBuilder sb = new StringBuilder();
            sb.Append(@"SELECT tp.idpedido, tc.nome,tp.codcliente, tp.codproduto, tp.valorunitario, tp.valortotal, tp.situacao, tp.data_comp, tpp.descricao, tp.quantidade 
               FROM tabpedido As tp INNER JOIN tabcliente As tc ON codcliente = id INNER JOIN tabproduto AS tpp ON codproduto = idproduto")
               .Append("" + strWhere + " ")
               .Append("ORDER BY nome");


            SqlCommand cmd = new SqlCommand(sb.ToString());



            try
            {
                cmd.Connection = conexao.Conectar();
                reader =  cmd.ExecuteReader();



                while (reader.Read())
                {
                    pedido = new Entities.Pedidos();
                   

                    pedido.NumeroPedido = Convert.ToInt32(reader["idpedido"]);
                    pedido.DataCompra = reader["data_comp"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_comp"]);
                    pedido.Situacao = reader["situacao"].ToString();
                    pedido.NomeCliente = reader["nome"].ToString();
                    pedido.ValorUnitario = Convert.ToDouble(reader["valorunitario"]);
                    pedido.ValorTotal = Convert.ToDouble(reader["valortotal"]);
                    pedido.Quantidade = Convert.ToInt32(reader["quantidade"]);
                    pedido.NDescricaoProduto = reader["descricao"].ToString();
                    pedido.codproduto = Convert.ToInt32(reader["codproduto"]);
                    pedido.codcliente = Convert.ToInt32(reader["codcliente"]);

                    if (listapedido == null)
                        listapedido = new List<Entities.Pedidos>();


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

        public String InserirPedido(Entities.Pedido pedido)
        {
            if (pedido.Equals(pedido))
            {
                command.CommandText = @"INSERT INTO[dbo].[tabpedido]
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


        public List<Entities.Pedidos> SelecionarClientePorNome(string nome)
        {


            Entities.Pedidos pedido = null;
            try
            {
                command.CommandText = @"SELECT tp.idpedido, tc.nome, tp.valortotal, tp.situacao, tp.data_comp  
               FROM tabpedido As tp INNER JOIN tabcliente As tc ON codcliente = id where tc.nome = @nome";
                command.Parameters.AddWithValue("@nome", nome);

                command.Connection = conexao.Conectar();
                var reader = command.ExecuteReader();

                List<Entities.Pedidos> listapedido = new List<Entities.Pedidos>();


                while (reader.Read())
                {
                    pedido = new Entities.Pedidos();


                    pedido.NumeroPedido = Convert.ToInt32(reader["idpedido"]);
                    pedido.DataCompra = reader["data_comp"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_comp"]);
                    pedido.Situacao = reader["situacao"].ToString();
                    pedido.NomeCliente = reader["nome"].ToString();
                    pedido.ValorTotal = Convert.ToDouble(reader["valortotal"]);
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

            public List<Entities.Pedidos> SelecionarClientePorNumero(int numero)
            {


                Entities.Pedidos pedido = null;
                try
                {
                    command.CommandText = @"SELECT tp.idpedido, tc.nome, tp.valortotal, tp.situacao, tp.data_comp  
               FROM tabpedido As tp INNER JOIN tabcliente As tc ON codcliente = id where tp.idpedido = @id";
                    command.Parameters.AddWithValue("@id", numero);

                    command.Connection = conexao.Conectar();
                    var reader = command.ExecuteReader();

                    List<Entities.Pedidos> listapedido = new List<Entities.Pedidos>();


                    while (reader.Read())
                    {
                        pedido = new Entities.Pedidos();


                        pedido.NumeroPedido = Convert.ToInt32(reader["idpedido"]);
                        pedido.DataCompra = reader["data_comp"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_comp"]);
                        pedido.Situacao = reader["situacao"].ToString();
                        pedido.NomeCliente = reader["nome"].ToString();
                        pedido.ValorTotal = Convert.ToDouble(reader["valortotal"]);
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

        public void DeletarPedido(int id)
        {
            try
            {



                command.CommandText = @"Delete from tabpedido                 
                                      WHERE idpedido = @id";

                command.Parameters.AddWithValue("@id", id);
                command.Connection = conexao.Conectar();

                command.ExecuteNonQuery();



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
