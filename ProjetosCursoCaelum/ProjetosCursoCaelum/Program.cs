using System;
using System.Xml.Schema;

namespace ProjetosCursoCaelum
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula de variáveis
            int idadeAdriana = 31;
            int idadeDiego = 37;
            int idadeLuiza = 11;

            Console.WriteLine("A média das idades é: " + (idadeAdriana +idadeDiego + idadeLuiza) / 3);

            double pi = 3.14;
            int piQuebrado = (int)pi;
            Console.WriteLine(piQuebrado);

            double a = 1;
            double b = -5;
            double c = 6;

            double delta = (b * b) - (4 * a * c);
            double a1 = ((-b + (Math.Sqrt(delta))) / (2 * a));

            Console.WriteLine(delta);
            Console.WriteLine("O Resultado de A1 é:" + a1);
            */
            // Fim

            //Programa caixa eletrônico
            /*double saldo = 100.00;
            double valorSaque = 101.00;
            bool realmentePodeSacar = (saldo >= valorSaque) && (valorSaque > 0);

            if (realmentePodeSacar)
            {
                saldo = saldo - valorSaque;
               Console.WriteLine("Saque Realizado com Sucesso! Seu saldo agora é: " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente! Seu saldo atual é de: " + saldo);
            }

            double tarifa;
            if(saldo < 1000)
            {
                tarifa = 0.01;
            }
            else if (saldo <= 5000)
            {
                tarifa = 0.05;
            }
            else
            {
                tarifa = 0.1;
             }

            if (saldo < 0.0)
            {
                Console.WriteLine("Você está com saldo negativo!");

            }
            else if (saldo < 1000000.00)
            {
                Console.WriteLine("Você é um bom cliente");
            }
            else
            {
                Console.WriteLine("Você é milionário! Aproveite!");
            }
            */
            // FIM

            //Programa Eleições
            /*
            int idadePessoa = 31;
            bool brasileira = false;



            if (idadePessoa > 16 && brasileira == true )
            {
                Console.WriteLine("Você poderá votar nessas eleições!");
            }
            else
            {
                Console.WriteLine("Lamento você não poderá votar!");
            }
            */


            double valorNotaFiscal = 1000;
           
            if (valorNotaFiscal >= 1000 && valorNotaFiscal <= 299)
            {
                double calculoImposto = valorNotaFiscal * 0.025;
                Console.WriteLine("Seu importo será: 2,5%. Valor do imposto: " + calculoImposto);
            }
            else if (valorNotaFiscal >= 3000 && valorNotaFiscal <= 6999)
            {
                double calculoImposto = valorNotaFiscal * 0.028;
                Console.WriteLine("Seu importo será: 2,8%. Valor do imposto: " + calculoImposto);
            }
            else if (valorNotaFiscal > 7000)
            {
                double calculoImposto = valorNotaFiscal * 0.03;
                Console.WriteLine("Seu importo será: 3%.  Valor do imposto: " + calculoImposto);
            }
            else
            {
                double calculoImposto = valorNotaFiscal * 0.02;
                Console.WriteLine("Seu importo será: 2%.  Valor do imposto: " + calculoImposto);
            }


            double valorInvestido = 1000.0;

            /*for (int i = 1; i<=12; i += 1)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            Console.WriteLine("Valor investido agora é :" + valorInvestido);
           */

            /*
            int i = 1;
            while (i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
                Console.WriteLine("Valor investido agora é :" + valorInvestido);
            }
            */

            /*int total = 2;
            for (int i = 1; i <= 5; i += 1)
            {
                total = total * 2;
            }
            Console.WriteLine("O total é: " + total);
            */



            /*int numeros = 0;
            for (int i = 1; i <= 1000; i += 1)
            {
                numeros = numeros + 1;
                Console.WriteLine (numeros);
            }

            int multiplosTres = 1;
            for(int i = 1; i<=100; i+=1)
            {
                if (multiplosTres % 3 == 0)
                {
                    Console.WriteLine(multiplosTres);
                   
                }
                multiplosTres = multiplosTres + 1;
            }
            

                  
            int numero = 1;
            for (int i = 2; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                   continue;
                }

                numero += i;
            }
            Console.WriteLine("Soma = " + numero);
            */


        }


     }
 }

