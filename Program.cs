using System;

namespace calculadoraDeSueldos
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, st;
            Console.WriteLine("Bienvenido a la calculadora de sueldos con comision, por favor inserte el monto a cobrar:");
            s = int.Parse(Console.ReadLine());
            st = ((s * 5) / 100)+ s;
            Console.WriteLine("El monto a cobrar con la suma del 5% de comisión es de: " + st + " pesos");
            Console.WriteLine("Gracias por utilizar la calculadora de sueldos con comsión");
        }
    }
}
