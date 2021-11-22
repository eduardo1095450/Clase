using System;


namespace Clase
{
    class Ejercicio11_2
    {
        static void Main(string[] args)
        {
            int numeros;
            Console.WriteLine("Ingresa la cantidad de veces");
            numeros = Convert.ToInt32(Console.ReadLine());
            Sucesion(numeros);
        }

        static private int Sucesion(int num)
        {
            int a = 0, b = 1, c = 1;
            for (int i = 0; i < num; i++)
            {
                c = a;
                a = b;
                b = a + c;
                Console.WriteLine(b);
            }
            return b;

        }
    }
}


