using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
   public class Cliente : IntId
    {
       
        public string Nome { get; set; }
        public DateTime? DataNasc { get; set; }
        public string CPF { get; set; }

        public  string tel { get; set; }
        public Endereco Endereco { get; set; }

    }
}
