using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.DAO
{
    public class UsuarioDAO
    {
        public Usuario ObterUsuarioPeloUsuarioESenha(string nomeUsuario, string senha)
        {
            try
            {

                var command = new SqlCommand();
                command.Connection = ConexaoDAO.connection;
                command.CommandText = "SELECT * FROM tablogin WHERE usuario = @USUARIO AND senha = @SENHA";
                command.Parameters.AddWithValue("@USUARIO", nomeUsuario);
                command.Parameters.AddWithValue("@SENHA", senha);

               ConexaoDAO.Conectar();


                var reader = command.ExecuteReader();

                Usuario usuarios = null;

                while (reader.Read())
                {
                    usuarios = new Usuario();
                    usuarios.Id = Convert.ToInt32(reader["id"]);
                    usuarios.NomeUsuario = reader["usuario"].ToString();
                    usuarios.Senha = reader["senha"].ToString();
                    usuarios.Perfil = Convert.ToChar(reader["perfil"]);
                }
                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConexaoDAO.Desconectar();
            }
        }
    }
}

