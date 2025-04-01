using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string expressaoCompleta = ""; // Armazena a express�o completa
        private bool novaOperacao = true; // Controla se uma nova opera��o est� come�ando

        public Form1()
        {
            InitializeComponent();
            txtOperacao.ReadOnly = true; // Impede a edi��o manual do TextBox
        }

        // M�todo para adicionar n�meros ao visor
        private void AdicionarNumero(string numero)
        {
            if (novaOperacao)
            {
                expressaoCompleta = ""; // Limpa a express�o anterior
                novaOperacao = false;
            }

            expressaoCompleta += numero; // Adiciona o n�mero � express�o
            txtOperacao.Text = expressaoCompleta; // Mostra a express�o completa no visor
        }

        // M�todo para adicionar operadores ao visor
        private void AdicionarOperador(string operador)
        {
            if (!string.IsNullOrEmpty(expressaoCompleta) && !expressaoCompleta.EndsWith(operador))
            {
                expressaoCompleta += operador; // Adiciona o operador � express�o
                txtOperacao.Text = expressaoCompleta; // Mostra a express�o completa no visor
                novaOperacao = false;
            }
        }

        // Eventos dos bot�es num�ricos
        private void btn0_Click(object sender, EventArgs e) => AdicionarNumero("0");
        private void btn01_Click(object sender, EventArgs e) => AdicionarNumero("1");
        private void btn2_Click(object sender, EventArgs e) => AdicionarNumero("2");
        private void btn3_Click(object sender, EventArgs e) => AdicionarNumero("3");
        private void btn4_Click(object sender, EventArgs e) => AdicionarNumero("4");
        private void btn5_Click(object sender, EventArgs e) => AdicionarNumero("5");
        private void btn6_Click(object sender, EventArgs e) => AdicionarNumero("6");
        private void btn7_Click(object sender, EventArgs e) => AdicionarNumero("7");
        private void btn8_Click(object sender, EventArgs e) => AdicionarNumero("8");
        private void btn9_Click(object sender, EventArgs e) => AdicionarNumero("9");

        // Eventos dos bot�es de opera��o
        private void btnSomar_Click(object sender, EventArgs e) => AdicionarOperador("+");
        private void btnSubtrair_Click(object sender, EventArgs e) => AdicionarOperador("-");
        private void btnMulti_Click(object sender, EventArgs e) => AdicionarOperador("*");
        private void btnDividir_Click(object sender, EventArgs e) => AdicionarOperador("/");

        // Evento do bot�o de resultado (=)
        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                // Usa a fun��o Evaluate para calcular o resultado da express�o no visor
                var dataTable = new System.Data.DataTable();
                var resultadoCalculado = dataTable.Compute(expressaoCompleta, null);

                // Converte o resultado para double e formata corretamente
                double resultado = Convert.ToDouble(resultadoCalculado);
                txtOperacao.Text = resultado.ToString(); // Mostra o resultado no visor
                expressaoCompleta = resultado.ToString(); // Armazena o resultado para opera��es futuras
                novaOperacao = true; // Indica que uma nova opera��o pode come�ar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular: " + ex.Message);
            }
        }

        // Evento do bot�o de limpar (Limpar)
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "0"; // Limpa o visor
            expressaoCompleta = ""; // Limpa a express�o armazenada
            novaOperacao = true; // Indica que uma nova opera��o est� come�ando
        }

        // Evento de mudan�a de texto no TextBox (n�o � necess�rio fazer nada aqui)
        private void txtOperacao_TextChanged(object sender, EventArgs e)
        {
            // vazio
        }
    }
}