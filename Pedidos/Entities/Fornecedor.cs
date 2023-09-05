using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
  public class Fornecedor : IntId
    {
        public string Nome { get; set; }
        public DateTime? DataComp { get; set; }
        public string CNPJ { get; set; }

        public string tel { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
    }
}
