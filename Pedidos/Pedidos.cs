namespace Pedidos
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClientes tela = new CadClientes();
            // Cria um objeto do Form2, chamado tela
            tela.Show();
        }
    }
}