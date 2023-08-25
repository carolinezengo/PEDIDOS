using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.DAO
{
    public class ClienteDAO
    {
        SqlCommand command = new SqlCommand();
        ConexaoDAO conexao = new ConexaoDAO();
        SqlDataReader reader;
        public String mensagem = "";
        public String InserirCliente(Cliente cliente)
        {
            if (cliente.Equals(cliente))
            {
                command.CommandText = @"INSERT INTO[dbo].[tabcliente]
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
                                      (@nome, 
                                      @data_nasc
                                      ,@endereco
                                      ,@bairro
                                      ,@complemento
                                      ,@cidade
                                      ,@cep
                                     ,@cpf
                                     ,@tel)";
                command.Parameters.AddWithValue("@nome", cliente.Nome);
                command.Parameters.AddWithValue("@data_nasc", cliente.DataNasc);
                command.Parameters.AddWithValue("@endereco", cliente.Rua);
                command.Parameters.AddWithValue("@bairro", cliente.Bairro);
                command.Parameters.AddWithValue("@complemento", cliente.Complemento);
                command.Parameters.AddWithValue("@cidade", cliente.Cidade);
                command.Parameters.AddWithValue("@cep", cliente.CEP);
                command.Parameters.AddWithValue("@cpf", cliente.CPF);
                command.Parameters.AddWithValue("@tel", cliente.tel);

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


