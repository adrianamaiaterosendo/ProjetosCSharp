namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(311, 74);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(219, 26);
            this.textTitular.TabIndex = 3;
            this.textTitular.TextChanged += new System.EventHandler(this.textTitular_TextChanged);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(311, 132);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(219, 26);
            this.textNumero.TabIndex = 4;
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(311, 195);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(219, 26);
            this.textSaldo.TabIndex = 5;
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(345, 321);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(114, 39);
            this.botaoDeposito.TabIndex = 6;
            this.botaoDeposito.Text = "Deposito";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(311, 254);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(219, 26);
            this.textValor.TabIndex = 7;
            this.textValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(178, 320);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(114, 40);
            this.botaoSaque.TabIndex = 8;
            this.botaoSaque.Text = "Saque";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botaoSaque);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.botaoDeposito);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.textTitular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Label label4;
    }
}

