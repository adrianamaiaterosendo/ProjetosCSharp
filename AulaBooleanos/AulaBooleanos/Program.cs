using System;

namespace AulaBooleanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias = DateTime.Now.Day;
            Console.WriteLine($"dia: {dias}");

            bool diasPar = (dias % 2 == 0);
            if(diasPar)
            {
                Console.WriteLine("O dia é par");
            }
            else
            {
                Console.WriteLine("Dia impar");
            }
        }
    }
}
