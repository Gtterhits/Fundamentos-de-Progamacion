using System;

namespace Triangulo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables de entrada de t
            double c = 56.31;

            // Variables de entrada de a
            double z = 3;

            // Operaciones
            double crad = c * (Math.PI / 180);
            double y = z/Math.Tan(crad);
            double t = y / Math.Cos(crad);
            double a = Math.Atan(y / z);
            double agrados = a * (180 / Math.PI);

            //Valores de salida; c, y, z
            Console.WriteLine("Valor de t: " + t);
            Console.WriteLine("Valor de y: " + y);
            Console.WriteLine("Valor de a en grados: " + agrados);
        }
    }
}
