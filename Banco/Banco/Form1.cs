using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.c = new Conta();
            
            Conta c = new Conta();
            textTitular.Text = c.Titular.Nome;
            textNumero.Text = Convert.ToString(c.Numero);
            textSaldo.Text = Convert.ToString(c.Saldo);

            c.Numero = 1;
            Cliente cliente = new Cliente("victor");
            c.Titular = cliente;

        }

        private void textTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDigitado = textValor.Text;
            double valorOperação = Convert.ToDouble(valorDigitado);
            c.Deposita(valorOperação);
            textSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Saca(valorOperacao);
            textSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso");
        }
    }

  
}
