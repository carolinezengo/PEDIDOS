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
        public void AlterarPedido(Entities.Pedido pedido)
        {
            _pedidoDao = new PedidosDAO();

            ValidarPedido(pedido);
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

        public String Cadastrar(Pedido pedido)
        {
            PedidosDAO pedidoDAO = new PedidosDAO();
            ValidarPedido(pedido);
            this.mensagem = pedidoDAO.InserirPedido(pedido);
            return mensagem;
        }

        public void ValidarPedido(Pedido pedido)
        {
            if (string.IsNullOrWhiteSpace(pedido.Situacao) || pedido.IdCliente == 0)
            {
                MessageBox.Show("Erro ao Validar");
            }
        }

    }

}
