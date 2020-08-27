using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObj
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereço;
    }
    class Conta
    {
        private double saldo = 100.0;
        private int numero;
        private Cliente titular;
        public double PegaSaldo()
        {
            return this.saldo;
        }
        
        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
            
        }

        public void Deposita (double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if(this.saldo >= (valor))
            {
                destino.Deposita(valor);
                this.saldo = this.saldo - (valor);
            }
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();

            MessageBox.Show("saldo: " + conta.PegaSaldo());

            /*Conta c = new Conta();
            c.numero = 1;
            Cliente Victor = new Cliente();
            Victor.nome = "Victor";
            Conta umaConta = new Conta();
            umaConta.titular = Victor;

            umaConta.titular.rg = "23.456.789-10";
            MessageBox.Show(umaConta.titular.nome);
            MessageBox.Show(Victor.rg);

            c.saldo = 100;
           if( c.Saca(10))
            {
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente!");
            }
            c.Deposita(100);

            //Conta Victor = new Conta();
            //Victor.saldo = 1000.0;

            //Conta Guilherme = new Conta();

            //Victor.Transfere(100.0, Guilherme);
            //MessageBox.Show(" Seu saldo ficou em: " + Victor.saldo);
           */

        }
    }
}
