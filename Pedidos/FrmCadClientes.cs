﻿using Pedidos.BLL;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void BtnGrava_Click(object sender, EventArgs e)
        {
            _clienteBo = new ClienteBo();
            var cliente = ObterModeloPreenchido();

            try
            {

                _clienteBo.Cadastrar(cliente);
                mesagemDeSucesso = "Cliente Cadastrado com sucesso!";
                BtnGrava.Enabled = false;
                label11.Text = mesagemDeSucesso;
            }
            catch
            {
                MessageBox.Show("Erro ao gravar!");
            }

        }


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


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            _clienteBo = new ClienteBo();
            var nome = TxtNome.Text;

            if (nome != null)
            {
                _clienteBo.ObterClientePeloNome(nome);
                CarregarDadosParaEdicao();
                mesagemDeSucesso = "Cadastro de Cliente encontrado";
                label11.Text = mesagemDeSucesso;
            }
            else
            {
                MessageBox.Show("Deu erro");
            }

        }

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {

        }
    }

}