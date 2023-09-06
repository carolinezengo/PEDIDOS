using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
    public class Produto : IntId
    {
        public string Nome { get; set; }
        public int quantida { get; set; }
        public int codFornecedor { get; set; }

       
    }
}
