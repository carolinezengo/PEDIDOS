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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pedidos
{
    public partial class FrmCadClientes : Form
    {
        public String mesagemDeSucesso = "";
        private ClienteBo _clienteBo;
        public FrmCadClientes()
        {
            InitializeComponent();
        }

        //Botao Limpar Dados
        private void button1_Click(object sender, EventArgs e)
        {
            LimparTela();
            BtnNovo.Enabled = false;

        }
        // Botao Sair
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }
        //Botao Gravar
        private void BtnGrava_Click(object sender, EventArgs e)
        {
            _clienteBo = new ClienteBo();
            var cliente = ObterModeloPreenchido();


            try
            {

                _clienteBo.Cadastrar(cliente);
                mesagemDeSucesso = "Cliente Cadastrado com sucesso!";

                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = mesagemDeSucesso;
            }
            catch
            {
                MessageBox.Show("Erro ao gravar!");
            }

        }

        // Preenchimento de dados dos componetes com a classe
        private Cliente ObterModeloPreenchido()
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(TxtCodigo.Text);
            cliente.Nome = TxtNome.Text;
            cliente.DataNasc = string.IsNullOrWhiteSpace(TxtDataNasc.Text) ? (DateTime?)null : Convert.ToDateTime(TxtDataNasc.Text);
            cliente.Rua = TxtEndereco.Text;
            cliente.Bairro = TxtBairro.Text;
            cliente.Complemento = TxtComp.Text;
            cliente.Cidade = TxtCidade.Text;
            cliente.CEP = TxtCep.Text;
            cliente.CPF = TxtCpf.Text;
            cliente.tel = TxtTel.Text;

            return cliente;
        }
        //Carregar os componetes com as informacoes para alterar o Cadastro
        public void CarregarDadosParaEdicao()
        {
            _clienteBo = new ClienteBo();

            var nome = TxtNome.Text;
            var cliente = _clienteBo.ObterClientePeloNome(nome);
            TxtCodigo.Text = cliente.Id.ToString();
            TxtNome.Text = cliente.Nome;
            TxtDataNasc.Text = cliente.DataNasc.HasValue ? cliente.DataNasc.Value.ToString("yyy-MM-dd") : string.Empty;
            TxtEndereco.Text = cliente.Rua;
            TxtBairro.Text = cliente.Bairro;
            TxtComp.Text = cliente.Complemento;
            TxtCidade.Text = cliente.Cidade;
            TxtCep.Text = cliente.CEP;
            TxtCpf.Text = cliente.CPF;
            TxtTel.Text = cliente.tel;

        }

        // Botao Buscar Cadastro Cliente pelo Nome
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            _clienteBo = new ClienteBo();
            var nome = TxtNome.Text;

            if (nome != null)
            {
                _clienteBo.ObterClientePeloNome(nome);
                CarregarDadosParaEdicao();
                mesagemDeSucesso = "Cadastro de Cliente encontrado";
                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = mesagemDeSucesso;
            }
            else
            {
                MessageBox.Show("Deu erro");
            }

        }

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {
            FrmMenu menu
                = new FrmMenu();
            menu.Close();
        }
        //Botao Alterar cliente
        private void button3_Click(object sender, EventArgs e)

        {
            var cliente = ObterModeloPreenchido();
            _clienteBo.AlterarCliente(cliente);

            mesagemDeSucesso = "Cadastro de cliente alterado com Sucesso!";

            lblMensagem.ForeColor = System.Drawing.Color.Green;
            lblMensagem.Text = mesagemDeSucesso;
        }
        // Botao deletar cliente

        private void BtnDeletar_Click(object sender, EventArgs e)
        {


            _clienteBo.DeletarCliente(Convert.ToInt32(TxtCodigo.Text));
            LimparTela();



        }
        // Limpar dados na tela 
        private void LimparTela()
        {

            TxtCodigo.Clear();
            TxtNome.Clear();
            TxtDataNasc.Clear();
            TxtEndereco.Clear();
            TxtBairro.Clear();
            TxtComp.Clear();
            TxtCidade.Clear();
            TxtCep.Clear();
            TxtCpf.Clear();
            TxtTel.Clear();

        }

    }

}
