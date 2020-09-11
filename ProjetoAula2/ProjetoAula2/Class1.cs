using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ProjetoAula2
{
    public class Conta
    {
        private Cliente titular;
        private double saldo { get; set; }
        private int numero;

     
     
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

        public void Transfere (double valor, Conta destino)
        {
            if (this.Saca (valor))
            {
                destino.Deposita (valor);
            }
        }
    }
}
