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
                                       ,[codfornecedor])
                                  VALUES
                                      (@descricao, 
                                       @quantidade
                                      ,@codfornecedor)";
                command.Parameters.AddWithValue("@descricao", produto.Nome);
                command.Parameters.AddWithValue("@quantidade", produto.quantida);
                command.Parameters.AddWithValue("@codfornecedor", produto.codFornecedor);


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
                this.mensagem = "Cliente nao corresponde!";
            }

            return mensagem;

        }
    }
    }
