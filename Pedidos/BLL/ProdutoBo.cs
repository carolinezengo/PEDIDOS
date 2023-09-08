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
        private ProdutoDAO _produtoDao;
        public String Cadastrar(Produto produto)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            this.mensagem = produtoDAO.InserirProduto(produto); 
            return mensagem;
        }
        public void Deletarproduto(int id)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.DeletarProduto(id);

        }


        public Produto ObterprodutoPeloNome(String nome)
        {
            _produtoDao = new ProdutoDAO();
            var produto = _produtoDao.ObterProdutoPeloNome(nome);

            if (produto == null)
            {
                MessageBox.Show("produto nao encontrado");
            }


            return produto;

        }
        public void Alterarproduto(Produto produto)
        {
            _produtoDao = new ProdutoDAO();

            Validarproduto(produto);
            var linhasAfetadas = _produtoDao.AtualizarProduto(produto);

            if (linhasAfetadas == 0)
            {
                MessageBox.Show("produto Nao encontrado");
            }




        }
        public void Validarproduto(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.Nome) ||
                produto.Id == 0)
            {
                MessageBox.Show("produto nao existe");

            }
        }


        public List<Produto> CarregarGrid(string strWhere)
        {
            try
            {
                _produtoDao = new ProdutoDAO();
                return _produtoDao.CarregarGrid(strWhere);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Produto> SelecionarProdutoPorNome(string nome)
        {
            try
            {
                _produtoDao = new ProdutoDAO();
                return _produtoDao.SelecionarProdutoPorNome(nome);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
