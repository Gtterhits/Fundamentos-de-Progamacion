using System;

namespace Sin_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sin(x)");
            int n = 100;
            double sumatoria = 0;

            Console.WriteLine("Ingrese el valor de x: ");
            double x = 0.5;

            for (int i = 0; i < n; i++)
            {
                double resultado = Factorial(2 * i + 1);

                static double Factorial(double valor)
                {
                    if (valor <= 1) return 1;
                    return valor * Factorial(valor - 1);
                }

                double sin = (Math.Pow(-1, i) / Factorial(2 * i + 1)) * Math.Pow(x, 2 * i + 1);
                sumatoria += sin;
            }
            Console.WriteLine("Valor de Sin(" + x + ") es: " + sumatoria);
        }
    }
}