using System;
using System.Runtime.CompilerServices;

namespace Indice_de_masa_corporal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de variables
            Console.WriteLine("Programa para calcular indice de masa corporal(IMC)");
            Console.Write("Ingrese altura en m: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese peso en kilogramos: ");
            int p = int.Parse(Console.ReadLine());
            // Calculos con if
            double imc = p / Math.Pow(a,2);
            if (imc < 18.5){
                Console.WriteLine("Según su IMC su peso es inferior al normal");
            }
            else if (18.5 <= imc && imc <= 24.9){
                Console.WriteLine("Según su IMC su peso es normal: "+imc);
            }
            else if(25 <= imc && imc <= 29.9){
                Console.WriteLine("Según su IMC su peso es superior al normal: "+imc);
            }
            else if(imc >= 30){
                Console.WriteLine("Según su IMC usted tiene sobrepeso: "+imc);
            }
            Console.WriteLine("...Fin del programa...");
        }
    }
}
