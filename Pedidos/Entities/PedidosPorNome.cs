using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
   public class PedidosPorNome :IntId
    {
        public DateTime? DataCompra { get; set; }
        public int Quantidade { get; set; }
        public Double ValorUnitario { get; set; }
        public Double ValorTotal { get; set; }
        public string Situacao { get; set; }
        public string DescricaoProduto { get; set; }
        public Produto Produto { get; set; }
        public string NomeCliente { get; set; }
        public Cliente Cliente { get; set; }
    }
}
