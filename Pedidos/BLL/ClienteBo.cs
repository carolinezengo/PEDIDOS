using Pedidos.DAO;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.BLL
{
   public class ClienteBo
    {
        public String mensagem = "";
        public String Cadastrar(Cliente cliente) 
        {
          ClienteDAO clienteDAO = new ClienteDAO();
           this.mensagem = clienteDAO.InserirCliente(cliente);
            return mensagem;
        }
    }
}
