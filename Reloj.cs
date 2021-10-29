using System;
using System.Threading;

namespace Clase
{
    class Reloj
    {
        static void Main(string[] args)
        {
            int horas = 0;
            int minutos = 0;
            int segundos = 0;
            for (int i = 0; i > -1; i++)
            {
                if (segundos >= 0)
                {
                    segundos++;
                    Thread.Sleep(1000);
                }
                if (segundos == 60 && minutos >= 0)
                {
                    minutos++;
                    segundos = 0;
                    Thread.Sleep(1000);
                }
                if (segundos == 0 && minutos == 60 && horas >= 0)
                {
                    minutos = 0;
                    horas++;
                    Thread.Sleep(1000);
                }
                if (horas == 24)
                {
                    horas = 0;
                }
                Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            }
        }
    }
}

