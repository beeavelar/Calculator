using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "9";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += ",";
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {

            if (txt_resultado.Text != "")
            {
                valor2 = double.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txt_resultado.Text = Convert.ToString(valor1 + valor2);
                }

                else if (operacao == "SUBTRACAO")
                {
                    txt_resultado.Text = Convert.ToString(valor1 - valor2);
                }

                else if (operacao == "MULT")
                {
                    txt_resultado.Text = Convert.ToString(valor1 * valor2);
                }

                else if (operacao == "DIVISAO")
                {
                    txt_resultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular.");
            }
        }

        private void btn_subt_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = double.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "SUBTRACAO";
                lbl_operacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração.");
            }
        }

        private void btn_multip_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = double.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "MULT";
                lbl_operacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação.");
            }

        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = double.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "DIVISAO";
                lbl_operacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão.");
            }

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbl_operacao.Text = "";
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = double.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "SOMA";
                lbl_operacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma.");
            }
        }
    }
}
