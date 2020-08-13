using System;

namespace ProjetoSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string tamanhoPeca = "01-MN-L";

            string[] produto = tamanhoPeca.Split('-');

            string tipo = "01";
            string cor = "MN";
            string tamanho = "L";

            switch (tipo)
            {
                case "01":

                    tipo = "Sweat shirt";
                    break;

                case "02":

                    tipo = "T-Shirt";
                    break;

                case "03":

                    tipo = "Sweat pants";
                    break;

                default:

                    tipo = "Other";
                    break;

            }
            switch (cor)
            {
                case "BL":

                    cor = "Black";
                    break;

                case "MN":

                    cor = "Maroon";
                    break;

                default:

                    cor = "White";
                    break;

            }
            switch (tamanho)
            {
                case "S":

                    tamanho = "Small";
                    break;

                case "M":

                    tamanho = "Medium";
                    break;

                case "L":

                    tamanho = "Large";
                    break;

                default:

                    tamanho = "One Size Fits All";
                    break;

            }
            Console.WriteLine($"Product: {tamanho} {cor} {tipo}");

        }
    }
}
