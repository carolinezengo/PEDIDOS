using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.DAO
{
    public class ProdutoDAO
    {
        SqlCommand command = new SqlCommand();
        ConexaoDAO conexao = new ConexaoDAO();
        SqlDataReader reader;
        public String mensagem = "";

        public String InserirProduto(Produto produto)
        {
            if (produto.Equals(produto))
            {
                command.CommandText = @"INSERT INTO[dbo].[tabproduto]
                                       ([descricao]
                                       ,[quantidade]
                                       ,[codfornecedor],
                                            [valor_unitario])
                                  VALUES
                                      (@descricao, 
                                       @quantidade
                                      ,@codfornecedor
                                       ,@valor_unitario)";
                command.Parameters.AddWithValue("@descricao", produto.Nome);
                command.Parameters.AddWithValue("@quantidade", produto.quantida);
                command.Parameters.AddWithValue("@codfornecedor", produto.codFornecedor);
                command.Parameters.AddWithValue("@valor_unitario", produto.valor_unitario);

                try
                {

                    command.Connection = conexao.Conectar();
                    command.ExecuteNonQuery();
                    conexao.Desconectar();


                    this.mensagem = "Cadastrado com sucesso";

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro Banco de dados";
                }

            }
            else
            {
                this.mensagem = "Produto nao corresponde!";
            }

            return mensagem;

        }

        public int AtualizarProduto(Produto produto)
        {
            try
            {

                command.CommandText = @"UPDATE[dbo].[tabproduto]
                                        SET [descricao] = @descricao
                                       ,[quantidade] = @quantidade
                                       ,[codfornecedor] = @codfornecedor )
                                       WHERE id = @id";


                command.Parameters.AddWithValue("@id", produto.Id);
                command.Parameters.AddWithValue("@descricao", produto.Nome);
                command.Parameters.AddWithValue("@data_nasc", produto.quantida);
                command.Parameters.AddWithValue("@endereco", produto.codFornecedor);
                             

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
        public List<Produto> CarregarGrid(string strWhere)
        {
            List<Produto> listaproduto = new List<Produto>();
            Produto produto = null;


            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            StringBuilder sb = new StringBuilder();
            sb.Append("Select * from tabproduto ")
             .Append("" + strWhere + " ")
             .Append("ORDER BY descricao");
            SqlCommand cmd = new SqlCommand(sb.ToString());

            try
            {
                cmd.Connection = conexao.Conectar();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    produto = new Produto();

                    produto.Id = Convert.ToInt32(reader["id"]);
                    produto.Nome = reader["descricao"].ToString();
                    produto.quantida = Convert.ToInt32(reader["quantidade"]);
                    produto.codFornecedor = Convert.ToInt32(reader["codfornecedor"]);


                    if (listaproduto == null)
                        listaproduto = new List<Produto>();

                    listaproduto.Add(produto);

                }

                return listaproduto;

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
        public Produto ObterProdutoPeloNome(String nome)
        {
            try
            {
                command.CommandText = "Select * FROM tabproduto where descricao = @descricao";
                command.Parameters.AddWithValue("@descricao", nome);

                command.Connection = conexao.Conectar();
                var reader = command.ExecuteReader();

                Produto produto = null;


                while (reader.Read())
                {
                    produto = new Produto();

                    produto.Id = Convert.ToInt32(reader["id"]);
                    produto.Nome = reader["descricao"].ToString();
                    produto.quantida = Convert.ToInt32(reader["quantidade"]);
                    produto.codFornecedor = Convert.ToInt32(reader["codfornecedor"]);
                }

                return produto;


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


        public void DeletarProduto(int id)
        {
            try
            {



                command.CommandText = @"Delete from tabproduto                 
                                      WHERE id = @id";

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

        public List<Produto> SelecionarProdutoPorNome(string nome)
        {
            try
            {
                command.CommandText = "Select * FROM tabproduto where descricao = @descricao";
                command.Parameters.AddWithValue("@descricao", nome);

                command.Connection = conexao.Conectar();
                var reader = command.ExecuteReader();

                List<Produto> listaProduto = new List<Produto>();


                while (reader.Read())
                {
                    Produto produto = new Produto();

                    produto.Id = Convert.ToInt32(reader["id"]);
                    produto.Nome = reader["nome"].ToString();
                    produto.quantida= Convert.ToInt32(reader["quantidade"]);
                    produto.codFornecedor = Convert.ToInt32(reader["codfornecedir"]);
                    
                    listaProduto.Add(produto);

                }

                return listaProduto;


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
