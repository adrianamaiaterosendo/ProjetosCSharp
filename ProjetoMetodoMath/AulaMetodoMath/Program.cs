using System;

namespace AulaMetodoMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine("O maior número entre " + firstValue + " e " + secondValue + " é " + largerValue);
        }
    }
}
