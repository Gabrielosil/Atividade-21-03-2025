namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTela = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnClear = new Button();
            btnResultado = new Button();
            btnMais = new Button();
            btnMulti = new Button();
            btnMenos = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // txtTela
            // 
            txtTela.Location = new Point(154, 86);
            txtTela.Name = "txtTela";
            txtTela.Size = new Size(154, 23);
            txtTela.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(154, 124);
            btn1.Name = "btn1";
            btn1.Size = new Size(46, 23);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(206, 124);
            btn2.Name = "btn2";
            btn2.Size = new Size(46, 23);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(262, 124);
            btn3.Name = "btn3";
            btn3.Size = new Size(46, 23);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(154, 163);
            btn4.Name = "btn4";
            btn4.Size = new Size(46, 23);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(206, 163);
            btn5.Name = "btn5";
            btn5.Size = new Size(46, 23);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(262, 163);
            btn6.Name = "btn6";
            btn6.Size = new Size(46, 23);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(154, 201);
            btn7.Name = "btn7";
            btn7.Size = new Size(46, 23);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(206, 201);
            btn8.Name = "btn8";
            btn8.Size = new Size(46, 23);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(262, 201);
            btn9.Name = "btn9";
            btn9.Size = new Size(46, 23);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(206, 239);
            btn0.Name = "btn0";
            btn0.Size = new Size(46, 23);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(154, 239);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(46, 23);
            btnClear.TabIndex = 11;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(262, 239);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(46, 23);
            btnResultado.TabIndex = 12;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            // 
            // btnMais
            // 
            btnMais.Location = new Point(327, 86);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(46, 23);
            btnMais.TabIndex = 13;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(327, 201);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(46, 23);
            btnMulti.TabIndex = 14;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(327, 124);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(46, 23);
            btnMenos.TabIndex = 14;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(327, 163);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(46, 23);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(btnDiv);
            Controls.Add(btnMenos);
            Controls.Add(btnMulti);
            Controls.Add(btnMais);
            Controls.Add(btnResultado);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTela);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTela;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnClear;
        private Button btnResultado;
        private Button btnMais;
        private Button btnMulti;
        private Button btnMenos;
        private Button btnDiv;
    }
}
