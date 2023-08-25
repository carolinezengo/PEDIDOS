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
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
    }
}
