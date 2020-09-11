using System;

namespace AulaStructsEnums
{

    interface  IGPS
    {
       bool EstaNoHemisferioNorte();
    }

    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;

        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"Latitude = {Latitude}, Longitude = {Longitude}";
        }
    }

    [Flags]
    enum DiasDeTrabalho { Seg = 0, Ter = 1, Qua = 2, Qui = 3, Sex = 4, Sab = 5, Dom = 6 }
    enum DiasDaSemana { Seg = 1, Ter = 2, Qua = 3, Qui = 4, Sex = 5, Sab = 6, Dom = 7}
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoGPS  posicao1;
            posicao1 = new PosicaoGPS(13.78, 29.51);

            Console.WriteLine($"Latitude e Longetude = {posicao1}.");

            DiasDaSemana primeiroDia = DiasDaSemana.Seg;
            DiasDeTrabalho adrianaTrabalho = DiasDeTrabalho.Seg;

         
            Console.WriteLine(primeiroDia);
            Console.WriteLine(adrianaTrabalho);
         
            
        }
    }
}
