using System;

namespace Sln_ecuacion_cuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcula la solucion de un ecuacion cuadratica de tipo ax^2 + bx + c.
            Console.WriteLine("Programa que calcula la solucion de un ecuacion cuadratica de tipo ax^2+bx+c.");
            // Entrada de variables a, b, c.
            Console.WriteLine("Ingrese valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor de c: ");
            double c = double.Parse(Console.ReadLine());

            // Calculos
            double dis = (b*b)-(4*a*c);
            if (dis == 0) {
                double x = -b / 2 * a;
                Console.WriteLine("La solucion existe y es unica: " + x);
            }
            else if (dis>0){
                double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                Console.WriteLine("Existen 2 posibles soluciones.");
                Console.WriteLine("x1 es: " + x1);
                Console.WriteLine("x2 es: " + x2);
            }
            else if (dis < 0){
                Console.WriteLine("No es posible calcular la solucion.");
            }
            Console.WriteLine("...Fin del programa...");
        }
    }
}
