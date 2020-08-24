using System;



namespace AulasCursoCSharp
    {
        class Program
        {
            static void Main (string[] args)
            {
                Console.WriteLine("Digite sua idade: ");
                string idade = Console.ReadLine();
                int numeroIdade = Int32.Parse(idade);

            Int32 teste = new Int32();
            teste = 3;

            Int32 testeDie = new Int32();
            testeDie = 4;


            //idade = 30;
            Console.WriteLine(numeroIdade + 20);

               // int copiaIdade = idade;

               // Console.WriteLine($"idade: {idade}");
               //Console.WriteLine($"copiaIdade: {copiaIdade}");

            }
        }
    }

