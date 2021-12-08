using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operação = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            resultText.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultText.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            resultText.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resultText.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultText.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultText.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultText.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultText.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultText.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultText.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultText.Text += ".";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultText.Text = "";
        }

        private void resultText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(resultText.Text, CultureInfo.InvariantCulture);
            } catch
            {

            }
            resultText.Text = "";
            operação = "SOMA";
            label1.Text = $"{valor1}+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(resultText.Text, CultureInfo.InvariantCulture);
            } catch
            {

            }
            resultText.Text = "";
            operação = "MULTIPLICAÇÂO";
            label1.Text = $"{valor1}x";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(resultText.Text, CultureInfo.InvariantCulture);
            } catch
            {

            }
            resultText.Text = "";
            operação = "SUBTRAÇÂO";
            label1.Text = $"{valor1}-";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(resultText.Text, CultureInfo.InvariantCulture);
            } catch
            {

            }
            resultText.Text = "";
            operação = "DIVISÂO";
            label1.Text = $"{valor1}/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultText.Text = "";
            valor1 = 0;
            valor2 = 0;
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                valor2 = decimal.Parse(resultText.Text, CultureInfo.InvariantCulture);
            } catch
            {

            }

            if (operação == "SOMA")
            {
                resultText.Text = Convert.ToString(valor1 + valor2);
            } else if (operação == "SUBTRAÇÂO")
            {
                resultText.Text = Convert.ToString(valor1 - valor2);
            } else if (operação == "MULTIPLICAÇÂO")
            {
                resultText.Text = Convert.ToString(valor1 * valor2);
            } else if (operação == "DIVISÂO")
            {
                try
                {
                    resultText.Text = Convert.ToString(valor1 / valor2);
                } catch
                {

                }
            }
            else
            {
                label1.Text = "Nenhuma Operação foi feita.";
            }
        }
    }
}
