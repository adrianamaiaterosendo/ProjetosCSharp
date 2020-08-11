using System;

namespace TaxadeAssinaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int diasVencimento = random.Next(12);
            int descontoPorcentagem = 0;
            Console.WriteLine(diasVencimento);
           
            if (diasVencimento  == 0)
            {
                Console.WriteLine("Sua assinatura venceu.");
            }
            else if (diasVencimento == 1)
            {
                Console.WriteLine("Sua assinatura irá vencer em 1 dia!");
                descontoPorcentagem = 20;
            }
            else if (diasVencimento <= 5)
            {
                Console.WriteLine($"Sua assinatura vencerá em {diasVencimento} dias.");
                descontoPorcentagem = 10;
            }
            else if (diasVencimento <= 10)
            {
                Console.WriteLine("Sua assinatura está vencendo, renove agora!");
            }

            if (descontoPorcentagem > 0)
            {
                Console.WriteLine($"Renove sua assinatura com {descontoPorcentagem}%.");
            }
          
        }
    }
}
