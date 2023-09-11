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

        public void AlterarPedido(Pedido pedido)
        {
            _pedidoDao = new PedidosDAO();

            ValidarPedido(pedido);
            var linhasAfetadas = _pedidoDao.AtualizarPedido(pedido);

            if (linhasAfetadas == 0)
            {
                MessageBox.Show("Pedido Nao encontrado");
            }




        }
        public void ValidarPedido(Pedido pedido)
        {
            if (string.IsNullOrWhiteSpace(pedido.NomeCliente) ||
                pedido.Id == 0)
            {
                MessageBox.Show("Pedido nao existe");

            }
        }

    }
}
