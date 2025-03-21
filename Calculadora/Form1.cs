using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double resultado = 0;
        private string operacao = "";
        private bool novaOperacao = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "0";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "0";
            }
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "1";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "2";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "3";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "4";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "5";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "6";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "7";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "8";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (novaOperacao)
            {
                txtOperacao.Text = "9";
                novaOperacao = false;
            }
            else
            {
                txtOperacao.Text += "9";
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (!novaOperacao)
            {
                resultado = double.Parse(txtOperacao.Text);
                operacao = "+";
                novaOperacao = true;
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (!novaOperacao)
            {
                resultado = double.Parse(txtOperacao.Text);
                operacao = "-";
                novaOperacao = true;
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (!novaOperacao)
            {
                resultado = double.Parse(txtOperacao.Text);
                operacao = "*";
                novaOperacao = true;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!novaOperacao)
            {
                resultado = double.Parse(txtOperacao.Text);
                operacao = "/";
                novaOperacao = true;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (!novaOperacao)
            {
                double segundoNumero = double.Parse(txtOperacao.Text);
                switch (operacao)
                {
                    case "+":
                        resultado += segundoNumero;
                        break;
                    case "-":
                        resultado -= segundoNumero;
                        break;
                    case "*":
                        resultado *= segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero != 0)
                        {
                            resultado /= segundoNumero;
                        }
                        else
                        {
                            MessageBox.Show("Divisão por zero não é permitida.");
                            return;
                        }
                        break;
                }
                txtOperacao.Text = resultado.ToString();
                novaOperacao = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "0";
            resultado = 0;
            operacao = "";
            novaOperacao = true;
        }

        private void txtOperacao_TextChanged(object sender, EventArgs e)
        {
            // Este evento pode ser usado para validação ou outras operações quando o texto muda.
        }
    }
}