﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
   public class Pedidos 

    {
        public int NumeroPedido { get; set; }
        public int codcliente { get; set; }
        public string NomeCliente { get; set; }
        public int Quantidade { get; set; }
        public int codproduto { get; set; }

        public string NDescricaoProduto { get; set; }

        public Double ValorUnitario { get; set; }
        public Double ValorTotal { get; set; }
        public DateTime? DataCompra { get; set; }
       
        public string Situacao { get; set; }
        public Produto Produto { get; set; }
     
        public Cliente Cliente { get; set; }





    }
}
