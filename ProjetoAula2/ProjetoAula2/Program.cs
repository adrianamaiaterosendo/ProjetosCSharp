using System;

namespace ProjetoAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente adriana = new Cliente();
            adriana.nome = "Adriana";
            Conta adrianaConta = new Conta();
            adrianaConta.titular = adriana;
            adrianaConta.Numero(); ;
            adrianaConta.PegaSaldo();

            Cliente victor = new Cliente();
            victor.nome = "Victor";
            Conta victorConta = new Conta();
            victorConta.titular = victor;
            victorConta.Numero(2);
            victorConta.PegaSaldo ();
            victorConta.titular.rg = "76.999.876-63";
            victorConta.titular.idade = 15;

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
                    Console.WriteLine(victorConta.titular.nome + ", você precisa de autorização para abrir a conta.");
                }
                
            }


        }
    }
}
