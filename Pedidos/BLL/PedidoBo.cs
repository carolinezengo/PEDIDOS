using Pedidos.DAO;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.BLL
{
    public class PedidoBo
    {
        private PedidosDAO _pedidoDao;
        private ClienteDAO _clienteDAO;

        public void AlterarPedido(Entities.Pedidos pedido)
        {
          /*  _pedidoDao = new PedidosDAO();

            ValidarPedido(pedido);
            var linhasAfetadas = _pedidoDao.AtualizarPedido(pedido);

            if (linhasAfetadas == 0)
            {
                MessageBox.Show("Pedido Nao encontrado");
            }*/




        }
       public void ValidarPedido(Entities.Pedidos pedido)
        {
            if (string.IsNullOrWhiteSpace(pedido.Situacao) ||
                pedido.NumeroPedido== 0)
            {
                MessageBox.Show("Pedido nao existe");

           }
        }



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

    }

}
