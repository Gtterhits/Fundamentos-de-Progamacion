using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euler");
            int n = 100;
            double sumatoria = 0;

            Console.WriteLine("Ingrese el valor de x: ");
            double x = 3;

            for (int i = 0; i < n; i++)
            {
                double resultado = Factorial(i);

                static double Factorial(double valor)
                {
                    if (valor <= 1) return 1;
                    return valor * Factorial(valor - 1);
                }

                double euler = Math.Pow(x, i)/Factorial(i);
                sumatoria += euler;
            }
            Console.WriteLine("Valor de Euler es: " + sumatoria);

        }
    }
}
