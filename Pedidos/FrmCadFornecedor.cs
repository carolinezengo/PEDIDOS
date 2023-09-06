using Pedidos.BLL;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class FrmCadFornecedor : Form
    {
        public String mesagemDeSucesso = "";
        private FornecedorBo _fornecedorBo;

       

        public FrmCadFornecedor()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            _fornecedorBo = new FornecedorBo();
            var nome = TxtNome.Text;

            if (nome != null)
            {
                _fornecedorBo.ObterFornecedorPeloNome(nome);
                CarregarDadosParaEdicao();
                mesagemDeSucesso = "Cadastro de Fornecedor encontrado";
                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = mesagemDeSucesso;
            }
            else
            {
                MessageBox.Show("Deu erro");
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void LimparTela()
        {

            TxtCodigo.Text = "";
            TxtNome.Text = "";
            TxtDataComp.Text = "";
            TxtEndereco.Text = "";
            TxtBairro.Text = "";
            TxtComp.Text = "";
            TxtCidade.Text = "";
            TxtCep.Text = "";
            TxtCnpj.Text = "";
            TxtTel.Text = "";

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            _fornecedorBo = new FornecedorBo();
            var fornecedor = ObterModeloPreenchido();
      
            try
            {

                _fornecedorBo.Cadastrar(fornecedor);
                mesagemDeSucesso = "Fornecedor Cadastrado com sucesso!";

                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = mesagemDeSucesso;
            }
            catch
            {
                MessageBox.Show("Erro ao gravar!");
            }

        }
        private Fornecedor ObterModeloPreenchido()
        {
            var fornecedor = new Fornecedor();
           // fornecedor.Id = Convert.ToInt32(TxtCodigo.Text);
            fornecedor.Nome = TxtNome.Text;
            fornecedor.DataComp = string.IsNullOrWhiteSpace(TxtDataComp.Text) ? (DateTime?)null : Convert.ToDateTime(TxtDataComp.Text);
            fornecedor.Rua = TxtEndereco.Text;
            fornecedor.Bairro = TxtBairro.Text;
            fornecedor.Complemento = TxtComp.Text;
            fornecedor.Cidade = TxtCidade.Text;
            fornecedor.CEP = TxtCep.Text;
            fornecedor.CNPJ = TxtCnpj.Text;
            fornecedor.tel = TxtTel.Text;

            return fornecedor;
        }
        public void CarregarDadosParaEdicao()
        {
            _fornecedorBo = new FornecedorBo();

            var nome = TxtNome.Text;
            var fornecedor = _fornecedorBo.ObterFornecedorPeloNome(nome);
            TxtCodigo.Text = fornecedor.Id.ToString();
            TxtNome.Text = fornecedor.Nome;
            TxtDataComp.Text = fornecedor.DataComp.HasValue ? fornecedor.DataComp.Value.ToString("yyy-MM-dd") : string.Empty;
            TxtEndereco.Text = fornecedor.Rua;
            TxtBairro.Text = fornecedor.Bairro;
            TxtComp.Text = fornecedor.Complemento;
            TxtCidade.Text = fornecedor.Cidade;
            TxtCep.Text = fornecedor.CEP;
            TxtCnpj.Text = fornecedor.CNPJ;
            TxtTel.Text = fornecedor.tel;

        }
    }
}
