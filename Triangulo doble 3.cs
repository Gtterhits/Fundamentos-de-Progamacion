using System;

namespace Triangulo_doble_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valores de entrada de d, b, y
            Console.Write("Ingrese valor de w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de d en grados: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de x: ");
            double x = double.Parse(Console.ReadLine());
            // Angulo d de grados a radianes
            double drad = d * (Math.PI / 180);

            // Calculos ley de cosenos y funciones trigonometricas
            double t = Math.Sqrt(w * w + x * x - 2 * w * x * Math.Cos(drad));
            double z = w * Math.Sin(drad);
            double a = Math.Acos(z / t);
            double y = t * Math.Sin(a);

            // Resultados
            Console.WriteLine("El valor de y es: " + y);
        }
    }
}
