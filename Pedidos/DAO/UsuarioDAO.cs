using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos.DAO
{
     class UsuarioDAO
    {
        SqlCommand command = new SqlCommand();
        ConexaoDAO conexao = new ConexaoDAO();
        SqlDataReader reader ;

        public String mensagem = "";
        public bool login;
        public bool verficarLogin(String usuario, String senha)
        {

           command.CommandText = "Select * FROM tablogin WHERE Usuario = @Usuario And  Senha= @Senha";
            command.Parameters.AddWithValue("@Usuario", usuario);
           command.Parameters.AddWithValue("@Senha", senha);
            
           
            try
            {
               command.Connection = conexao.Conectar();
                reader = command.ExecuteReader();

                if(reader.HasRows ) 
                {
                login = true;
                }
            }

            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }

            return login;
        }

       
    }
}
