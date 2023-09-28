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
        //Botao Buscar
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            _fornecedorBo = new FornecedorBo();
            var nome = TxtNome.Text;

            if (nome != null || nome == "")
            {
                _fornecedorBo.ObterFornecedorPeloNome(nome);
                ObterModeloPesquisa();
                mesagemDeSucesso = "Cadastro de Fornecedor encontrado";
                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = mesagemDeSucesso;
            }
            else
            {
                MessageBox.Show("Deu erro");
            }
        }
        // Botao novo apagando Limpando tela
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
        // Limpar a tela 
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
        // Botao Salvar Fornecedor
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
            catch (Exception ex)
            {
                mesagemDeSucesso = "Erro ao Salvar!";
                lblMensagem.ForeColor = System.Drawing.Color.Red;
                lblMensagem.Text = mesagemDeSucesso;
            }

        }

        // Preencher dados dos Classse com os campos
        private Fornecedor ObterModeloPreenchido()
        {
            var fornecedor = new Fornecedor();

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
       
      

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void FrmCadFornecedor_Load(object sender, EventArgs e)
        {
            FrmMenu menu
               = new FrmMenu();
            menu.Close();
        }
        // Carregar as informacoes Campos com a Classe
        private Fornecedor ObterModeloPreenchidoAlterar()
        {
            var fornecedor = new Fornecedor();
            fornecedor.Id = Convert.ToInt32(TxtCodigo.Text);
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

        // Carrega dados dos campos com informacação do banco de dados
        private void ObterModeloPesquisa()
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
        //Botao alterar dados do cliente
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var fornecedor = ObterModeloPreenchidoAlterar();
            _fornecedorBo.Alterarfornecedor(fornecedor);

            mesagemDeSucesso = "Cadastro de fornecedor alterado com Sucesso!";

            lblMensagem.ForeColor = System.Drawing.Color.Green;
            lblMensagem.Text = mesagemDeSucesso;




        }
        //Botao deletar

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtCodigo.Text);
            _fornecedorBo.Deletarfornecedor(id);
        }
    }
}
