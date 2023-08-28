using Microsoft.VisualBasic.Logging;
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
        public bool cliente;
        public String mensagem = "";
        private ClienteDAO _clienteDao;

        public String Cadastrar(Cliente cliente) 
        {
          ClienteDAO clienteDAO = new ClienteDAO();
           this.mensagem = clienteDAO.InserirCliente(cliente);
            return mensagem;
        }
        // public List<Cliente> BuscarporNome(String nome)

        //  {
        //    _clienteDao = new ClienteDAO();
        //   var cliente = _clienteDao.BuscarNomeCliente(nome) ;
        //   if (cliente == null)
        //   {
        //       this.mensagem = ("cliente não existe");
        //   }


        //               return cliente;
        //  }
      //  public bool BuscarPorNome(String nome)

    //    {
      //      ClienteDAO clienteDao = new ClienteDAO();
      //      cliente = clienteDao.BuscarPorNomeCliente(nome);
//
        ///    if (!clienteDao.mensagem.Equals(""))
       //     {
         //       this.mensagem = clienteDao.mensagem;
          //  }

           /// return cliente;
//}

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

    }
    }

