using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
   public class Pedido : IntId

    {

        public string NomeCliente { get; set; }
        public DateTime? DataCompra { get; set; }
        public string Produto { get; set; }

        public int Quantidade { get; set; }
        public Double ValorUnitario { get; set; }
        public Double ValorTotal { get; set; }
        public string Situacao { get; set; }
       

    }
}
