namespace Pedidos
{
    public partial class Menu : Form
    {
        
        
        public Menu()
        {
       
            InitializeComponent();
           
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClientes tela = new CadClientes();
            // Cria um objeto do Form2, chamado tela
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}