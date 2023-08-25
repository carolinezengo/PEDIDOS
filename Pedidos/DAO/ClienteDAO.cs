using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.DAO
{
    public class ClienteDAO
    {
        SqlCommand command = new SqlCommand();
        ConexaoDAO conexao = new ConexaoDAO();
        public int InserirCliente(Cliente cliente)
        {
            try
            {

                command.Connection = conexao.Conectar();
                command.CommandText = @"INSERT INTO[dbo].[cliente]
                                       ([nome]
                                       ,[data_nasc]
                                       ,[endereco]
                                       ,[bairro]
                                       ,[complemento]
                                       ,[cidade]
                                       ,[cep]
                                       ,[cpf]
                                       ,[tel])
                                  VALUES
                                      (nome, 
                                      data_nasc
                                      ,endereco
                                      ,bairro
                                      ,complemento
                                      ,cidade
                                      ,cep
                                     ,cpf
                                     ,tel)";
                command.Parameters.AddWithValue("@nome", cliente.Nome);
                command.Parameters.AddWithValue("@data_nasc", cliente.DataNasc);
                command.Parameters.AddWithValue("@endereco", cliente.Endereco.Rua);
                command.Parameters.AddWithValue("@bairro", cliente.Endereco.Bairro);
                command.Parameters.AddWithValue("@complemento", cliente.Endereco.Complemento);
                command.Parameters.AddWithValue("@cidade", cliente.Endereco.Cidade);
                command.Parameters.AddWithValue("@cep", cliente.Endereco.CEP);
                command.Parameters.AddWithValue("@cpf", cliente.CPF);
                command.Parameters.AddWithValue("@tel", cliente.tel);

             

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


