using Microsoft.VisualBasic;
using Pedidos.BLL;
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

    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioBo usuarioBo = new UsuarioBo();
            usuarioBo.acessar(TxtUsuario.Text, TxtSenha.Text);
            if (usuarioBo.login)
            {
                MessageBox.Show("Logando com Sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmMenu menu = new FrmMenu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Verificar Usuario e Senha!", "Erro", MessageBoxButtons.OK);
            }


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
