using System;
class HelloWorld {
  static void Main() {
    int suma;
    int numeros = -1;
    int total = 0;
    for (int i = 0; i>numeros; i++)
    {
        Console.WriteLine("Cuales numeros vas a sumar");
        suma = Convert.ToInt32(Console.ReadLine());
        if (suma == 0) {
            i = -2;
        }
        total = total + suma;
    }
    Console.WriteLine("El total de la suma es: "+total );
  }
}
