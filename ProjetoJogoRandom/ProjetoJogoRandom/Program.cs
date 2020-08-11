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

            Console.WriteLine($"Rodada de dados: {rodada1} + {rodada2} + {rodada3} = {total}");
            if ((rodada1 == rodada2) || (rodada2 == rodada3) || (rodada1 == rodada3))
            {
                if ((rodada1 == rodada2) && (rodada2 == rodada3))
                {
                    total += 6;
                    Console.WriteLine("3 Dados Iguais!  +6 bonus to total! Seus pontos foram: " + total);
                    
                }
                else
                {
                    total += 2;
                    Console.WriteLine("2 Dados Iguais!  +2 bonus no total!  Seus pontos foram: " + total);
                   
                }            
            }
            
            if (total >= 16)
            {
                Console.WriteLine("Você acaba de ganhar um carro zero!");
            }

            else if (total >= 10)
            {
                Console.WriteLine("Você acaba de ganhar um laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("Você ganhou uma viagem!");
            }
            else
            {
                Console.WriteLine("Você acaba de ganhar um gatinho!");
            }
        }
    }
}
