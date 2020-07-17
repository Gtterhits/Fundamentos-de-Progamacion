using System;

namespace Calculo_de_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular la tarifa apartir de su salario.");

            // Entrada de variables
            Console.WriteLine("Ingrese su salario: ");
            double s = double.Parse(Console.ReadLine());

            // Calculo de tarifa
            double smmlv = 877803;
            double numSmmlv = s / smmlv;

            if (numSmmlv < 2)
            {
                Console.WriteLine("Su tipo de tarife es A que es menor a 2 SMMLV: " + numSmmlv);
            }
            else if (2 <= numSmmlv && numSmmlv < 4)
            {
                Console.WriteLine("Su tipo de tarife es B que es entre 2 y menor a 4 SMMLV: " + numSmmlv);
            }
            else if (numSmmlv >= 4)
            {
                Console.WriteLine("Su tipo de tarife es C que es mayor o igual a 4 SMMLV: " + numSmmlv);
            }

        }
    }
}
