using System;

namespace Triangulo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables de entrada de t
            double t = 3.61;

            // Variables de entrada de a
            double a = 33.69;

            // Operaciones
            double arad = a * (Math.PI / 180);
            double y = t * Math.Sin(arad);
            double z = t * Math.Cos(arad);
            double c = Math.Atan(z / y);
            double cgrados = c * (180 / Math.PI);

            //Valores de salida; c, y, z
            Console.WriteLine("Valor de a y: " + y);
            Console.WriteLine("Valor de c z: " + z);
            Console.WriteLine("Valor de c en grados: " + cgrados);
        }
    }
}
