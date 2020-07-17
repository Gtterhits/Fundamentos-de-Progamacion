using System;

namespace Calculo_de_cuota_moderadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular el tipo de tarifa y el valor de la cuota moderadora dependiendo de su SMMLV.");

            // Entradas de variables 
            Console.WriteLine("Ingrese su salario: ");
            double s = double.Parse(Console.ReadLine());

            // Calculo de tarifa y valor de cuota moderadora
            double smmlv = 877803;
            double numSmmlv = s / smmlv;

            // Calculo de valor de cuota moderadora 
            // cm = smmlv diario * porcentaje de un smmlv dependiendo de su rango
            // smmlv diario = smmlv / 30 dias
            double smmlvd = smmlv / 30;

            if (numSmmlv < 2)
            {
                Console.WriteLine("Su tipo de tarife es A que es menor a 2 SMMLV: " + numSmmlv);
                Console.WriteLine("Su porcentaje de cuota moderadora es del 11.7% de un SMMLV.");
                double cm = smmlvd * 0.117;
                Console.WriteLine("El valor de la cuota moderadura es: " + cm + " COP");
            }
            else if (2 <= numSmmlv && numSmmlv < 5)
            {
                Console.WriteLine("Su tipo de tarife es B que es entre 2 y menor a 5 SMMLV: " + numSmmlv);
                Console.WriteLine("Su porcentaje de cuota moderadora es del 46.1% de un SMMLV.");
                double cm = smmlvd * 0.461;
                Console.WriteLine("El valor de la cuota moderadura es: " + cm + " COP");
            }
            else if (numSmmlv >= 5)
            {
                Console.WriteLine("Su tipo de tarife es C que es mayor o igual a 5 SMMLV: " + numSmmlv);
                Console.WriteLine("Su porcentaje de cuota moderadora es del 121.5% de un SMMLV.");
                double cm = smmlvd * 1.215;
                Console.WriteLine("El valor de la cuota moderadura es: " + cm + " COP");
            }
        }
    }
}
