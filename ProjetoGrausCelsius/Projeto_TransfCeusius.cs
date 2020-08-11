using System;

namespace Aulas_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * 3m / 9m;
            Console.WriteLine("O resultado foi " + celsius + " graus Celsius.");

           //Random dice = new Random();
           //int roll = dice.Next(1, 7);
           //Console.WriteLine(" Sua jogada de dado foi: " + roll);
        }
    }
}
