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
    public partial class CadClientes : Form
    {
        private ClienteBo _clienteBo;
        public CadClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGrava_Click(object sender, EventArgs e)
        {
            _clienteBo = new ClienteBo();
            var cliente = ObterModeloPreenchido();

            try
            {
                var mesagemDeSucesso = "";
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

        // public int ObterIdDoCliente()
        // {
        //    var id = 0;
        //   var idQueryString =
        //       Request.QueryString["id"];
        ////  if (int.TryParse(idQueryString, out id))
        //  {
        //     if (id <= 0)
        //     {
        //        throw new Exception("ID invalido");
        //   }

        //     return id;
        // }
        //    else
        //   {
        //    throw new Exception("ID invalido");
        // }
        //}

    }

}
