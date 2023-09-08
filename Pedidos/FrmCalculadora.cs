using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class FrmCalculadora : Form
    {
        double valor = 0;
        double valor2 = 0;
        string operacao = "";

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "Soma")
            {
                TxtResultado.Text = Convert.ToString(valor + valor2);
            }
            else
            if (operacao == "Subtracao")
            {
                TxtResultado.Text = Convert.ToString(valor - valor2);
            }
            else
                if (operacao == "Multiplicacao")
            {
                TxtResultado.Text = Convert.ToString(valor * valor2);
            }
            else

                if (operacao == "Divisao")
            {
                TxtResultado.Text = Convert.ToString(valor / valor2);
            }

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0";
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            valor = double.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            TxtResultado.Text = "";
            operacao = "Soma";

        }



        private void btnponto_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += ".";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            valor = double.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            TxtResultado.Text = "";
            operacao = "Subtracao";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            valor = double.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            TxtResultado.Text = "";
            operacao = "Multiplicacao";
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            valor = double.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            TxtResultado.Text = "";
            operacao = "Divisao";

        }

        private void btnmaisoumenos_Click(object sender, EventArgs e)
        {
            valor = double.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            valor2 = double.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            if (valor >= 0)
            {
                valor = (valor * (-1));

                TxtResultado.Text = Convert.ToString(valor);


            }
            else
                if (valor <= 0)
            {
                valor = (valor * (-1));

                TxtResultado.Text = Convert.ToString(valor);

            }

            if (valor2 >= 0)
            {
                valor2 = (valor2 * (-1));

                TxtResultado.Text = Convert.ToString(valor2);


            }
            else
                if (valor2 <= 0)
            {
                valor2 = (valor2 * (-1));

                TxtResultado.Text = Convert.ToString(valor2);

            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            TxtResultado.Clear();
        }

        private void btnquadrado_Click(object sender, EventArgs e)
        {
            valor = double.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            valor = valor * valor;
            TxtResultado.Text = Convert.ToString(valor);

        }

        private void btnraizquarada_Click(object sender, EventArgs e)
        {
            double resultado;
            valor = double.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            resultado = Convert.ToSingle(Math.Sqrt(valor));
            TxtResultado.Text = resultado.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenu menu = new FrmMenu();   
            menu.Show();    
        }
    }
}
