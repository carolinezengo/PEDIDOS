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
        SqlCommand obj = new SqlCommand();
        ConexaoDAO conexao = new ConexaoDAO();
        SqlDataReader reader ;

        public String mensagem = "";
        public bool login;
        public bool verficarLogin(String usuario, String senha)
        {

            obj.CommandText = "Select * FROM tablogin WHERE Usuario = @Usuario And  Senha= @Senha";
            obj.Parameters.AddWithValue("@Usuario", usuario);
            obj.Parameters.AddWithValue("@Senha", senha);
            
           
            try
            {
                obj.Connection = conexao.Conectar();
                reader = obj.ExecuteReader();

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
