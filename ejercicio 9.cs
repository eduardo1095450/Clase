using System;
class HelloWorld {
  static void Main() {
    int numeros = 1;
    int total = 0;
    while (numeros>0)
    {
        Console.WriteLine("Cuales numeros vas a sumar");
        numeros = Convert.ToInt32(Console.ReadLine());
        total = total + numeros;
    }
    Console.WriteLine("El total de la suma es: "+total );
  }
}
