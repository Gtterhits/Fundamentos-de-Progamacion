using System;

namespace Triangulo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables de entrada de y
            double y = 2;

            // Variables de entrada de z
            double z = 3;

            // Operaciones
            double a = Math.Atan(y / z);
            double c = Math.Atan(z / y);
            double t = Math.Sqrt(y * y + z * z);

            // Depurar a y c estan en rad
            double agrados = a*(180 / Math.PI);
            double cgrados = c*(180 / Math.PI);

            //Valores de salida; a, c, t
            Console.WriteLine("Valor de a en grados: " + agrados);
            Console.WriteLine("Valor de c en grados: " + cgrados);
            Console.WriteLine("Valor de t: " + t);


        }
    }
}
