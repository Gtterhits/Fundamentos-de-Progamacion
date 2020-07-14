using System;
using System.Security.Cryptography.X509Certificates;

namespace Triangulo_doble_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de las variables w, t, c
            Console.Write("Ingrese el valor de w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de t: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de c en grados: ");
            double c = double.Parse(Console.ReadLine());
            // Angulo c de grados a radianes
            double crad = c * (Math.PI / 180);

            // Calculos 
            double e = 180 - c;
            double erad = e * (Math.PI / 180);
            double a = 180 - 90- c;
            double arad = a * (Math.PI / 180);
            double z = t * Math.Sin(crad);
            double brad = Math.Acos(z / w) - arad;
            // Ley de senos
            double x = (w * Math.Sin(brad)) / Math.Sin(erad);

            // Resultados
            Console.WriteLine("EL valor de x es: " + x);
        }
    }
}
