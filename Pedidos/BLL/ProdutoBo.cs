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
    public class ProdutoBo
    {
        public String mensagem = "";
        public String Cadastrar(Produto produto)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            this.mensagem = produtoDAO.InserirProduto(produto); 
            return mensagem;
        }
    }
}
