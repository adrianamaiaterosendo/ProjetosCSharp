namespace Banco
{
    public class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; internal set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; internal set; }
    }
}