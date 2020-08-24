using System;

namespace ProjetoCaraOuCoroa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random moeda = new Random();
            int giro = moeda.Next(0, 2);
            Console.WriteLine((giro == 0) ? "cara" : "coroa");
        }
    }
}
