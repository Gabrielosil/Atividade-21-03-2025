using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string expressaoCompleta = ""; // Armazena a expressão completa
        private bool novaOperacao = true; // Controla se uma nova operação está começando

        public Form1()
        {
            InitializeComponent();
            txtOperacao.ReadOnly = true; // Impede a edição manual do TextBox
        }

        // Método para adicionar números ao visor
        private void AdicionarNumero(string numero)
        {
            if (novaOperacao)
            {
                expressaoCompleta = ""; // Limpa a expressão anterior
                novaOperacao = false;
            }

            expressaoCompleta += numero; // Adiciona o número à expressão
            txtOperacao.Text = expressaoCompleta; // Mostra a expressão completa no visor
        }

        // Método para adicionar operadores ao visor
        private void AdicionarOperador(string operador)
        {
            if (!string.IsNullOrEmpty(expressaoCompleta) && !expressaoCompleta.EndsWith(operador))
            {
                expressaoCompleta += operador; // Adiciona o operador à expressão
                txtOperacao.Text = expressaoCompleta; // Mostra a expressão completa no visor
                novaOperacao = false;
            }
        }

        // Eventos dos botões numéricos
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

        // Eventos dos botões de operação
        private void btnSomar_Click(object sender, EventArgs e) => AdicionarOperador("+");
        private void btnSubtrair_Click(object sender, EventArgs e) => AdicionarOperador("-");
        private void btnMulti_Click(object sender, EventArgs e) => AdicionarOperador("*");
        private void btnDividir_Click(object sender, EventArgs e) => AdicionarOperador("/");

        // Evento do botão de resultado (=)
        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                // Usa a função Evaluate para calcular o resultado da expressão no visor
                var dataTable = new System.Data.DataTable();
                var resultadoCalculado = dataTable.Compute(expressaoCompleta, null);

                // Converte o resultado para double e formata corretamente
                double resultado = Convert.ToDouble(resultadoCalculado);
                txtOperacao.Text = resultado.ToString(); // Mostra o resultado no visor
                expressaoCompleta = resultado.ToString(); // Armazena o resultado para operações futuras
                novaOperacao = true; // Indica que uma nova operação pode começar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular: " + ex.Message);
            }
        }

        // Evento do botão de limpar (Limpar)
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "0"; // Limpa o visor
            expressaoCompleta = ""; // Limpa a expressão armazenada
            novaOperacao = true; // Indica que uma nova operação está começando
        }

        // Evento de mudança de texto no TextBox (não é necessário fazer nada aqui)
        private void txtOperacao_TextChanged(object sender, EventArgs e)
        {
            // vazio
        }
    }
}