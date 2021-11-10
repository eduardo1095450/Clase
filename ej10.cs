using System;


namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros = -1;
            int cantidad = 0;
            int total = 0;
            int promedio;
            int primos = 0;
            int contador = 0;
            string lista = "";
            while (numeros != 0)
            {
                Console.WriteLine("Ingresa los numeros que vas a sumar (para terminar ingresa 0)");
                numeros = Convert.ToInt32(Console.ReadLine());
                if (numeros > 0)
                {
                    cantidad++;
                }
                total = total + numeros;
                for (int i = 1; i <= numeros; i++)
                {
                    if (numeros % i == 0)
                    {
                        contador += 1;
                    }
                }
                lista = lista + numeros.ToString() + ", ";
                if (contador == 2)
                {
                    primos++;
                }
                contador = 0;
            }
            promedio = total / cantidad;
            if (total % 2 == 0)
            {
                Console.WriteLine("la suma es par");
            }
            else
            {
                Console.WriteLine("la suma no es par");
            }
            Console.WriteLine("El total de la suma es: " + total + ", hay " + primos + " numeros primos, el promedio es: " + promedio);
            Console.WriteLine("La lista de numeros es: " + lista);
        }
    }
}
