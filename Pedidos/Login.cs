using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BntEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu tela = new Menu();
            // Cria um objeto do Form2, chamado tela
            tela.Show();


        }
      

    }
}
