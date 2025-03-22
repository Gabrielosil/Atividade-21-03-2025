namespace Calculadora
{
    partial class Form1
    {
 
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtOperacao = new TextBox();
            btn0 = new Button();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMulti = new Button();
            btnDividir = new Button();
            btnResultado = new Button();
            btnLimpar = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn01 = new Button();
            SuspendLayout();
            // 
            // txtOperacao
            // 
            txtOperacao.Location = new Point(20, 33);
            txtOperacao.Multiline = true;
            txtOperacao.Name = "txtOperacao";
            txtOperacao.Size = new Size(197, 52);
            txtOperacao.TabIndex = 0;
            txtOperacao.TextChanged += txtOperacao_TextChanged;
            // 
            // btn0
            // 
            btn0.Location = new Point(20, 321);
            btn0.Name = "btn0";
            btn0.Size = new Size(53, 52);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(267, 33);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(53, 52);
            btnSomar.TabIndex = 11;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(267, 99);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(53, 52);
            btnSubtrair.TabIndex = 12;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(267, 170);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(53, 52);
            btnMulti.TabIndex = 13;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(267, 242);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(53, 52);
            btnDividir.TabIndex = 14;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(267, 321);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(53, 52);
            btnResultado.TabIndex = 15;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(93, 321);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(124, 52);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(0, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 0;
            // 
            // btn2
            // 
            btn2.Location = new Point(93, 99);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 53);
            btn2.TabIndex = 18;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(168, 99);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 53);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(20, 170);
            btn4.Name = "btn4";
            btn4.Size = new Size(49, 53);
            btn4.TabIndex = 20;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(93, 169);
            btn5.Name = "btn5";
            btn5.Size = new Size(49, 53);
            btn5.TabIndex = 21;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(168, 170);
            btn6.Name = "btn6";
            btn6.Size = new Size(49, 53);
            btn6.TabIndex = 22;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(20, 242);
            btn7.Name = "btn7";
            btn7.Size = new Size(49, 53);
            btn7.TabIndex = 23;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(93, 242);
            btn8.Name = "btn8";
            btn8.Size = new Size(49, 53);
            btn8.TabIndex = 24;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(168, 242);
            btn9.Name = "btn9";
            btn9.Size = new Size(49, 53);
            btn9.TabIndex = 25;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn01
            // 
            btn01.Location = new Point(20, 99);
            btn01.Name = "btn01";
            btn01.Size = new Size(49, 53);
            btn01.TabIndex = 26;
            btn01.Text = "1";
            btn01.UseVisualStyleBackColor = true;
            btn01.Click += btn01_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 409);
            Controls.Add(btn01);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnLimpar);
            Controls.Add(btnResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMulti);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(btn0);
            Controls.Add(txtOperacao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        private TextBox txtOperacao;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btn0;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMulti;
        private Button btnDividir;
        private Button btnResultado;
        private Button btnLimpar;
        private Button btn01;
    }
}