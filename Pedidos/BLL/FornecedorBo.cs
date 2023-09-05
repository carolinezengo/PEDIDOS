using Pedidos.DAO;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.BLL
{
    public class FornecedorBo
    {
        public bool fornecedor;
        public String mensagem = "";
        private FornecedorDao _fornecedorDao;

        public String Cadastrar(Fornecedor fornecedor)
        {
            FornecedorDao fornecedorDao = new FornecedorDao();
            this.mensagem = fornecedorDao.InserirFornecedor(fornecedor);
            return mensagem;
        }

        public void Deletarfornecedor(int id)
        {
            FornecedorDao fornecedorDao = new FornecedorDao();
            fornecedorDao.DeletarFornecedor(id);

        }


        public Fornecedor ObterFornecedorPeloNome(String nome)
        {
            _fornecedorDao = new FornecedorDao();
            var fornecedor = _fornecedorDao.ObterFornecedorPeloNome(nome);
            if (fornecedor == null)
            {
                MessageBox.Show("Fornecedor nao encontrado");

            }
            return fornecedor;

        }

        
            public void Alterarfornecedor(Fornecedor fornecedor)
        {
            _fornecedorDao = new FornecedorDao();

            Validarfornecedor(fornecedor);
            var linhasAfetadas = _fornecedorDao.AtualizarFornecedor(fornecedor);

            if (linhasAfetadas == 0)
            {
                MessageBox.Show("fornecedor Nao encontrado");
            }




        }
        public void Validarfornecedor(Fornecedor fornecedor)
        {
            if (string.IsNullOrWhiteSpace(fornecedor.Nome) ||
                fornecedor.Id == 0)
            {
                MessageBox.Show("fornecedor nao existe");

            }
        }


        public List<Fornecedor> CarregarGrid(string strWhere)
        {
            try
            {
                _fornecedorDao = new FornecedorDao();
                return _fornecedorDao.CarregarGrid(strWhere);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}

