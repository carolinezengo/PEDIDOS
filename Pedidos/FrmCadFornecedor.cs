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
            LimparTela();

            BtnNovo.Enabled = true;
            try
            {

                _fornecedorBo.Cadastrar(fornecedor);
                mesagemDeSucesso = "fornecedor Cadastrado com sucesso!";

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
            fornecedor.Id = Convert.ToInt32(TxtCodigo.Text);
            fornecedor.Nome = TxtNome.Text;
            fornecedor.DataComp = string.IsNullOrWhiteSpace(TxtComp.Text) ? (DateTime?)null : Convert.ToDateTime(TxtComp.Text);
            fornecedor.Rua = TxtEndereco.Text;
            fornecedor.Bairro = TxtBairro.Text;
            fornecedor.Complemento = TxtComp.Text;
            fornecedor.Cidade = TxtCidade.Text;
            fornecedor.CEP = TxtCep.Text;
            fornecedor.CNPJ = TxtCnpj.Text;
            fornecedor.tel = TxtTel.Text;

            return fornecedor;
        }
    }
}
