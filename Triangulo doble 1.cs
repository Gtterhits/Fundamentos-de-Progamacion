using System;
using System.Security.Cryptography.X509Certificates;

namespace Triangulo_doble_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Valores de entrada de b, y, z
            Console.Write("Ingrese valor de b en grados: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de z: ");
            double z = double.Parse(Console.ReadLine());
            // Angulo b de grados a radianes
            double brad = b * (Math.PI / 180);

            // Calculos
            double t = Math.Sqrt(y * y + z * z);
            double a = Math.Atan(y / z);
            double d = Math.PI - (brad + a) - (Math.PI/2);
            // Ley de seno
            double x = (t * Math.Sin(brad)) / Math.Sin(d);

            // Resultados
            Console.WriteLine("El valor de x es: " + x);

        }
    }
}
