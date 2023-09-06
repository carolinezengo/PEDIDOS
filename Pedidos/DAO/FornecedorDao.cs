using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.DAO
{
   public class FornecedorDao
    {
        SqlCommand command = new SqlCommand();
        ConexaoDAO conexao = new ConexaoDAO();
        SqlDataReader reader;
        public String mensagem = "";

        public String InserirFornecedor(Fornecedor fornecedor)
        {
            if (fornecedor.Equals(fornecedor))
            {
                command.CommandText = @"INSERT INTO [dbo].[tabfornecedor]
                                                ([nome]
                                                ,[data_comp]
                                                ,[cnpj]
                                                ,[tel]
                                                ,[rua]
                                                ,[cidade]
                                                ,[cep]
                                                ,[bairro]
                                                ,[compl])
                                        VALUES
                                           (@nome
                                           ,@data_comp
                                           ,@cnpj
                                           ,@tel
                                           ,@rua
                                           ,@cidade
                                           ,@cep
                                           ,@bairro
                                           ,@compl)";
                command.Parameters.AddWithValue("@nome", fornecedor.Nome);
                command.Parameters.AddWithValue("@data_comp", fornecedor.DataComp);
                command.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
                command.Parameters.AddWithValue("@tel", fornecedor.tel);
                command.Parameters.AddWithValue("@rua", fornecedor.Rua);
                command.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                command.Parameters.AddWithValue("@cep", fornecedor.CEP);
                command.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                command.Parameters.AddWithValue("@compl", fornecedor.Complemento);
                                        

                try
                {

                    command.Connection = conexao.Conectar() ;
                    command.ExecuteNonQuery();
                   


                    this.mensagem = "Cadastrado com sucesso";

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro Banco de dados";
                }
                finally 
                { conexao.Desconectar();
                } 

            }
            else
            {
                this.mensagem = "Fornecedor nao corresponde!";
            }

            return mensagem;



        }
        public int AtualizarFornecedor(Fornecedor fornecedor)
        {
            try
            {

                command.CommandText = @"UPDATE[dbo].[tabfornecedor]
                                        SET[nome] = @nome
                                       ,[data_comp] = @data_comp
                                       ,[endereco] = @endereco
	                                   ,[bairro] = @bairro
                                       ,[complemento] = @complemento
                                       ,[cidade] = @cidade
                                       ,[cep] = @cep
                                       ,[cnpj] = @cnpj
                                       ,[tel] = @tel
                                      WHERE id = @id";


                command.Parameters.AddWithValue("@id", fornecedor.Id);
                command.Parameters.AddWithValue("@nome", fornecedor.Nome);
                command.Parameters.AddWithValue("@data_nasc", fornecedor.DataComp);
                command.Parameters.AddWithValue("@endereco", fornecedor.Rua);
                command.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                command.Parameters.AddWithValue("@complemento", fornecedor.Complemento);
                command.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                command.Parameters.AddWithValue("@cep", fornecedor.CEP);
                command.Parameters.AddWithValue("@cpf", fornecedor.CNPJ);
                command.Parameters.AddWithValue("@tel", fornecedor.tel);

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
        public List<Fornecedor> CarregarGrid(string strWhere)
        {
            List<Fornecedor> listaFornecedor = new List<Fornecedor>();
            Fornecedor fornecedor = null;


            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE " + strWhere;

            StringBuilder sb = new StringBuilder();
            sb.Append("Select * from tabfornecedor ")
             .Append("" + strWhere + " ")
             .Append("ORDER BY nome");
            SqlCommand cmd = new SqlCommand(sb.ToString());

            try
            {
                cmd.Connection = conexao.Conectar();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    fornecedor = new Fornecedor();

                    fornecedor.Id = Convert.ToInt32(reader["id"]);
                    fornecedor.Nome = reader["nome"].ToString();
                    fornecedor.DataComp = reader["data_comp"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_comp"]);
                    fornecedor.Rua = reader["rua"].ToString();
                    fornecedor.Bairro = reader["bairro"].ToString();
                    fornecedor.Complemento = reader["compl"].ToString();
                    fornecedor.Cidade = reader["cidade"].ToString();
                    fornecedor.CEP = reader["cep"].ToString();
                    fornecedor.CNPJ = reader["cnpj"].ToString();
                    fornecedor.tel = reader["tel"].ToString();

                    if (listaFornecedor == null)
                      listaFornecedor = new List<Fornecedor>();

                    listaFornecedor.Add(fornecedor);

                }

                return listaFornecedor;

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
        public Fornecedor ObterFornecedorPeloNome(String nome)
        {
            try
            {
                command.CommandText = "Select * FROM tabfornecedor where nome = @nome";
                command.Parameters.AddWithValue("@nome", nome);

                command.Connection = conexao.Conectar();
                var reader = command.ExecuteReader();

                Fornecedor fornecedor = null;


                while (reader.Read())
                {
                    fornecedor = new Fornecedor();

                    fornecedor.Id = Convert.ToInt32(reader["id"]);
                    fornecedor.Nome = reader["nome"].ToString();
                    fornecedor.DataComp = reader["data_comp"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_comp"]);
                    fornecedor.Rua = reader["rua"].ToString();
                    fornecedor.Bairro = reader["bairro"].ToString();
                    fornecedor.Complemento = reader["compl"].ToString();
                    fornecedor.Cidade = reader["cidade"].ToString();
                    fornecedor.CEP = reader["cep"].ToString();
                    fornecedor.CNPJ = reader["cnpj"].ToString();
                    fornecedor.tel = reader["tel"].ToString();

                }

                return fornecedor;


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


        public void DeletarFornecedor(int id)
        {
            try
            {



                command.CommandText = @"Delete from tabfornecedor                 
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


        public List<Fornecedor> SelecionarfornecedorPorNome(string nome)
        {
            try
            {
                command.CommandText = "Select * FROM tabfornecedor where nome = @nome";
                command.Parameters.AddWithValue("@nome", nome);

                command.Connection = conexao.Conectar();
                var reader = command.ExecuteReader();

                List<Fornecedor> listafornecedor = new List<Fornecedor>();


                while (reader.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();

                    fornecedor.Id = Convert.ToInt32(reader["id"]);
                    fornecedor.Nome = reader["nome"].ToString();
                    fornecedor.DataComp = reader["data_comp"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_comp"]);
                    fornecedor.Rua = reader["endereco"].ToString();
                    fornecedor.Bairro = reader["bairro"].ToString();
                    fornecedor.Complemento = reader["compl"].ToString();
                    fornecedor.Cidade = reader["cidade"].ToString();
                    fornecedor.CEP = reader["cep"].ToString();
                    fornecedor.CNPJ = reader["cnpj"].ToString();
                    fornecedor.tel = reader["tel"].ToString();
                    listafornecedor.Add(fornecedor);

                }

                return listafornecedor;


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

