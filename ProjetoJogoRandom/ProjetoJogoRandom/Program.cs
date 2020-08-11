using System;

namespace ProjetoJogoRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int rodada1 = dice.Next(1, 7);
            int rodada2 = dice.Next(1, 7);
            int rodada3 = dice.Next(1, 7);

            int total = rodada1 + rodada2 + rodada3;

            Console.WriteLine($"Dice roll: {rodada1} + {rodada2} + {rodada3} = {total}");
            if ((rodada1 == rodada2) || (rodada2 == rodada3) || (rodada1 == rodada3))
            {
                Console.WriteLine("2 Dados Iguais!  +2 bonus no total!");
                total += 2;
            }
            if ((rodada1 == rodada2) && (rodada2 == rodada3))
            {
                Console.WriteLine("3 Dados Iguais!  +6 bonus to total!");
                total += 6;
            }
            if (total > 15)
            {
                Console.WriteLine("Você venceu, Parabéns!");
            }

            if (total <= 15)
            {
                Console.WriteLine("Você perdeu, tente outra vez!");
            }
        }
    }
}
