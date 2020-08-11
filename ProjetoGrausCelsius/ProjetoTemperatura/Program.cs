using System;

namespace ProjetoTemparatura
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * 3m / 9m;
            Console.WriteLine("O resultado foi: " + celsius + " graus Celsius!");
        }
    }
}
