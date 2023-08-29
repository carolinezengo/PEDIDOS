using Microsoft.VisualBasic.Logging;
using Pedidos.DAO;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.BLL
{
   public class ClienteBo
    {
        public bool cliente;
        public String mensagem = "";
        private ClienteDAO _clienteDao;

        public String Cadastrar(Cliente cliente) 
        {
          ClienteDAO clienteDAO = new ClienteDAO();
           this.mensagem = clienteDAO.InserirCliente(cliente);
            return mensagem;
        }
        public List<Cliente> ObterTodosOsClientes()
        {
            _clienteDao = new ClienteDAO();
            return _clienteDao.BuscarTodosOsCliente();

        }
      

        public Cliente ObterClientePeloNome(String nome)
        {
            _clienteDao = new ClienteDAO();
            var cliente = _clienteDao.ObterClientePeloNome(nome);

            if (cliente == null)
            {
                MessageBox.Show("Cliente nao encontrado");
            }


            return cliente;

        }
        public void AlterarCliente(Cliente cliente)
        {
            _clienteDao = new ClienteDAO();

           ValidarCliente(cliente); 
            var linhasAfetadas = _clienteDao.AtualizarCliente(cliente);

            if (linhasAfetadas == 0)
            {
                MessageBox.Show("Cliente Nao encontrado");
            }




        }
        public void ValidarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome) ||
                cliente.Id == 0 )
            {
               MessageBox.Show("Cliente nao existe");

            }
        }


       
    }


}
    

