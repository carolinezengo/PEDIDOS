using Pedidos.BLL;
using Pedidos.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Login : Form
    {

        public String menssagem = "";
        public Login()
        {
            InitializeComponent();
        }

        private void BntEntrar_Click(object sender, EventArgs e)
        {
            UsuarioBo usuario = new UsuarioBo();
            usuario.acessar(TxtUsuario.Text, TxtSenha.Text);

            if (usuario.login)
            {
                this.Hide();
                MessageBox.Show("Logado com sucesso", "Entrando",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu tela = new Menu();
                // Cria um objeto do Form2, chamado tela
                tela.Show();

            }
            else
            {
                MessageBox.Show("Verificar usuario e senha", "Erro", MessageBoxButtons.OK);
                //todo : Login ou Senha Invalida
            }
            // command.Close();




        }

        private void BntSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
