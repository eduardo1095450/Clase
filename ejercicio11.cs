using System;


namespace Clase
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            int numeros = -1;
            int cantidad = 0;
            int total = 0;
            int promedio;
            string lista = "";
            int primos = 0;
            while (numeros != 0)
            {
                Console.WriteLine("Ingresa los numeros que vas a sumar (para terminar ingresa 0)");
                numeros = Convert.ToInt32(Console.ReadLine());
                Suma(total, numeros);
                Lista(lista, numeros);
                Primo(numeros, 0, 0);
                Total(numeros, 0);
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

        static private int Suma(int num1, int num2)
        {
            int suma = num1 + num2;
            num1 = num2;
            num2 = suma;
            return suma;
        }
        static private string Lista(string num1, int num2)
        {
            string listanum = num1 + num2 + ", ";
            return listanum;
        }
        static private int Primo(int num1, int primos, int contador)
        {
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 2 && num1 != 0)
            {
                primos++;
            }
            contador = 0;
            return primos;
        }
        static private int Total(int num1, int cantidad)
        {
            if (num1 > 0)
            {
                cantidad++;
            }
            return cantidad;
        }
    }
}


