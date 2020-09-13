using System;

namespace ProjetoAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente adriana = new Cliente("Adriana", 24)
            {
                cpf = "123.456.778-64",
                rg = "33.770.876-87",
                
            };
            Conta adrianaConta = new Conta();
            adrianaConta.PegaSaldo();

            Cliente victor = new Cliente("Victor", 25);
            Conta victorConta = new Conta();
            victorConta.PegaSaldo ();
         
            Console.WriteLine(victor.rg);


            bool deuCerto = victorConta.Saca(300.0);
           if(deuCerto == true)
            {
                Console.WriteLine("Saque efetuado com sucesso! Seu novo saldo é de: R$ " + victorConta.PegaSaldo());
            }
            else
            {
                Console.WriteLine("Valor superior ao saldo da conta, saldo atual da conta é: R$ " + victorConta.PegaSaldo());
            }

            victorConta.Transfere(100.0, adrianaConta);

            Console.WriteLine("Seu saldo ficou em R$: " + adrianaConta.PegaSaldo());

            int MaiorDeIdade = 18;
            {
                if (victor.idade <= MaiorDeIdade)
                {
                    Console.WriteLine(victor.nome + ", você precisa de autorização para abrir a conta.");
                }
                
            }


        }
    }
}
