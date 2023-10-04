using Pedidos.DAO;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos.BLL
{
    public class PedidoBo
    {
        private PedidosDAO _pedidoDao;
        private ClienteDAO _clienteDAO;
        private string mensagem = "";
        public void AlterarPedido(Entities.Pedidos pedido)
        {
            _pedidoDao = new PedidosDAO();

            //ValidarPedidos(pedido);
            var linhasAfetadas = _pedidoDao.AtualizarPedido(pedido);

            if (linhasAfetadas == 0)
            {
                MessageBox.Show("Pedido Nao encontrado");
            }




        }
        public void DeletarPedido(int id)
        {
            PedidosDAO pedidoDAO = new PedidosDAO();
            pedidoDAO.DeletarPedido(id);

        }
      //  public void ValidarPedidos(Entities.Pedidos pedido)
     //   {
            
      //          if (string.IsNullOrWhiteSpace(pedido.codcliente == 0))

       //         {
              //      MessageBox.Show("Pedido nao existe");
////
         //  }
      //  }



        public List<Entities.Pedidos> CarregarGrid(string strWhere)
        {
           
            try
            {
                _pedidoDao = new PedidosDAO();
                return _pedidoDao.CarregarGrid(strWhere);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Entities.Pedidos> SelecionarClientePorNome(string nome)
        {
            try
            {
                _pedidoDao = new PedidosDAO();
                return _pedidoDao.SelecionarClientePorNome(nome);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<Entities.Pedidos> SelecionarClientePorNumero(int numero)
        {
            try
            {
                _pedidoDao = new PedidosDAO();
                return _pedidoDao.SelecionarClientePorNumero(numero);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public String Cadastrar(Entities.Pedidos pedido)
        {
            PedidosDAO pedidoDAO = new PedidosDAO();
            //ValidarPedidos(pedido);
            this.mensagem = pedidoDAO.InserirPedido(pedido);
            return mensagem;
        }

       

    }

}
