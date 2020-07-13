using System;

namespace Numeros_Binarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables de entrada
            Console.Write("Ingrese b0: ");
            int b0 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese b1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese b2: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese b3: ");
            int b3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese b4: ");
            int b4 = int.Parse(Console.ReadLine());

            // Calculos de binario a entero
            double B0 = b0 * Math.Pow(2, 4);
            double B1 = b1 * Math.Pow(2, 3);
            double B2 = b2 * Math.Pow(2, 2);
            double B3 = b3 * Math.Pow(2, 1);
            double B4 = b4 * Math.Pow(2, 0);

            // Suma del numero para dar el entero
            double Sumaent = B0 + B1 + B2 + B3 + B4;

            // Resultados
            Console.WriteLine("Numero de Binario a Entero es: " + Sumaent);
        }
    }
}
