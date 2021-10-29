using System;
using System.Threading;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = 0;
            int minutos = 0;
            int segundos = 0;
            Console.WriteLine("Segundos");
            segundos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minutos");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Horas");
            horas = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i > -1; i++)
            {
                if (segundos>=0)
                {
                    segundos--;
                    Thread.Sleep(1000);
                }
                if (minutos > 0 && segundos == 0)
                {
                    minutos--;
                    segundos = 59;
                }
                if (horas > 0 && minutos == 0 && segundos == 0)
                {
                    horas--;
                    minutos = 59;
                    segundos = 59;
                }
                if (horas == 0 && minutos == 0 && segundos == 0)
                {
                    Console.WriteLine("Ya termino el tiempo");

                    i = -3;
                }
                Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            }
        }
    }
}
