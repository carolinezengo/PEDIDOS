using Microsoft.VisualBasic.Logging;
using Pedidos.BLL;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
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
        public int AtualizarCliente(Cliente cliente)
        {
            try
            {

                command.CommandText = @"UPDATE[dbo].[tabcliente]
                                        SET[nome] = @nome
                                       ,[data_nasc] = @data_nasc
                                       ,[endereco] = @endereco
	                                   ,[bairro] = @bairro
                                       ,[complemento] = @complemento
                                       ,[cidade] = @cidade
                                       ,[cep] = @cep
                                       ,[cpf] = @cpf
                                       ,[tel] = @tel
                                      WHERE id = @id";


                command.Parameters.AddWithValue("@id", cliente.Id);
                command.Parameters.AddWithValue("@nome", cliente.Nome);
                command.Parameters.AddWithValue("@data_nasc", cliente.DataNasc);
                command.Parameters.AddWithValue("@endereco", cliente.Rua);
                command.Parameters.AddWithValue("@bairro", cliente.Bairro);
                command.Parameters.AddWithValue("@complemento", cliente.Complemento);
                command.Parameters.AddWithValue("@cidade", cliente.Cidade);
                command.Parameters.AddWithValue("@cep", cliente.CEP);
                command.Parameters.AddWithValue("@cpf", cliente.CPF);
                command.Parameters.AddWithValue("@tel", cliente.tel);

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
        public List<Cliente> CarregarGrid(string strWhere)
        {
            List<Cliente> listacliente = new List<Cliente>();
            Cliente cliente = null;


            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            StringBuilder sb = new StringBuilder();
            sb.Append("Select * from tabcliente ")
             .Append("" + strWhere + " ")
             .Append("ORDER BY nome");
            SqlCommand cmd = new SqlCommand(sb.ToString());

            try
            {
                cmd.Connection = conexao.Conectar();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cliente = new Cliente();

                    cliente.Id = Convert.ToInt32(reader["id"]);
                    cliente.Nome = reader["nome"].ToString();
                    cliente.DataNasc = reader["data_nasc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_nasc"]);
                    cliente.Rua = reader["endereco"].ToString();
                    cliente.Bairro = reader["bairro"].ToString();
                    cliente.Complemento = reader["complemento"].ToString();
                    cliente.Cidade = reader["cidade"].ToString();
                    cliente.CEP = reader["cep"].ToString();
                    cliente.CPF = reader["cpf"].ToString();
                    cliente.tel = reader["tel"].ToString();

                    if (listacliente == null)
                        listacliente = new List<Cliente>();

                    listacliente.Add(cliente);

                }

                return listacliente;

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
        public Cliente ObterClientePeloNome(String nome)
        {
            try
            {
                command.CommandText = "Select * FROM tabcliente where nome = @nome";
                command.Parameters.AddWithValue("@nome", nome);

                command.Connection = conexao.Conectar();
                var reader = command.ExecuteReader();

                Cliente cliente = null;


                while (reader.Read())
                {
                    cliente = new Cliente();

                    cliente.Id = Convert.ToInt32(reader["id"]);
                    cliente.Nome = reader["nome"].ToString();
                    cliente.DataNasc = reader["data_nasc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_nasc"]);
                    cliente.Rua = reader["endereco"].ToString();
                    cliente.Bairro = reader["bairro"].ToString();
                    cliente.Complemento = reader["complemento"].ToString();
                    cliente.Cidade = reader["cidade"].ToString();
                    cliente.CEP = reader["cep"].ToString();
                    cliente.CPF = reader["cpf"].ToString();
                    cliente.tel = reader["tel"].ToString();

                }

                return cliente;


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


        public void DeletarCliente(int id)
        {
            try
            {



                command.CommandText = @"Delete from tabcliente                  
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

        public List<Cliente> SelecionarClientePorNome(string nome)
        {
            try
            {
                command.CommandText = "Select * FROM tabcliente where nome = @nome";
                command.Parameters.AddWithValue("@nome", nome);

                command.Connection = conexao.Conectar();
                var reader = command.ExecuteReader();

                List<Cliente> listaCliente = new List<Cliente>();


                while (reader.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Id = Convert.ToInt32(reader["id"]);
                    cliente.Nome = reader["nome"].ToString();
                    cliente.DataNasc = reader["data_nasc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_nasc"]);
                    cliente.Rua = reader["endereco"].ToString();
                    cliente.Bairro = reader["bairro"].ToString();
                    cliente.Complemento = reader["complemento"].ToString();
                    cliente.Cidade = reader["cidade"].ToString();
                    cliente.CEP = reader["cep"].ToString();
                    cliente.CPF = reader["cpf"].ToString();
                    cliente.tel = reader["tel"].ToString();
                    listaCliente.Add(cliente);

                }

                return listaCliente;


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
        public List<Cliente> ObterTodosNomesClientes()

        {
            List<Cliente> listacliente = new List<Cliente>();
            listacliente = null;
            Cliente cliente = null;


           

            StringBuilder sb = new StringBuilder();
            sb.Append("Select nome from tabcliente");
              
            SqlCommand cmd = new SqlCommand(sb.ToString());

            try
            {

                cmd.Connection = conexao.Conectar();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {    if (listacliente == null)
                    { 
                    listacliente= new List<Cliente>();  
                    }
                    cliente = new Cliente();

                    if (reader["nome"] != DBNull.Value) 
                    cliente.Nome = reader["nome"].ToString();
                    

                    

                    listacliente.Add(cliente);

                }
                

                return listacliente;

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