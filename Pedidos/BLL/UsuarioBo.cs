using Pedidos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.BLL
{
   public class UsuarioBo

    {
        public bool login;
        public String mensagem = "";
        
        public bool acessar(string usuario, string senha)

        {
            UsuarioDAO loginDAO = new UsuarioDAO(); 
           login = loginDAO.verficarLogin(usuario, senha);

           if(!loginDAO.mensagem.Equals(""))
           {
               this.mensagem = loginDAO.mensagem;
            }
            return login;
        }
    }
}
