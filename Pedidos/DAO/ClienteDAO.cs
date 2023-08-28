using Microsoft.VisualBasic.Logging;
using Pedidos.BLL;
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
        public bool nome;
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
        public String AtualizarCliente(Cliente cliente)
        {
            if (cliente.Equals(cliente.Id))
            {
                command.CommandText = @"UPDATE INTO[dbo].[tabcliente]
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


                    this.mensagem = "Atualizado com sucesso!";

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
        //public List<Cliente> BuscarNomeCliente(String nome)
        //{
        //  command.CommandText = "Select * FROM tabcliente WHERE Nome = @Nome";
        // command.Parameters.AddWithValue("@Nome", nome);




        //   command.Connection = conexao.Conectar();
        // reader = command.ExecuteReader();

        //var  clientes = new List<Cliente>();

        //while (reader.Read())
        //{
        //var cliente = new Cliente();

        //cliente.Id = Convert.ToInt32(reader["id"]);
        //cliente.Nome = reader["titulo"].ToString();
        //cliente.DataNasc = reader["data_compra"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_compra"]);
        // cliente.Rua = reader["titulo"].ToString();
        // cliente.Bairro = reader["titulo"].ToString();
        //cliente.Complemento = reader["titulo"].ToString();
        //cliente.Cidade = reader["titulo"].ToString();
        //cliente.CEP = reader["titulo"].ToString();
        //cliente.CPF = reader["titulo"].ToString();
        //cliente.tel = reader["titulo"].ToString();
        //  }

        //return clientes;
        //   }


        public bool cliente;
        public bool BuscarPorNomeCliente(String nome)
        {
            command.Connection = conexao.Conectar();
            command.CommandText = "Select * FROM tabcliente WHERE nome = @nome";
            command.Parameters.AddWithValue("@nome", nome);


            try
            {                
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    cliente = true;

                }
            }

            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }

            return cliente;
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


    }


}
    



