using System;

namespace T12_R1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio y distancia");

            string[] nombres = { "Tanjiro", "Nezuko", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };


            double promedio = (estatura[0] + estatura[1] + estatura[2] + estatura[3] + estatura[4] + estatura[5] + estatura[6]) / 7;
            Console.WriteLine("Valor del promedio: " + promedio);
            
            for (int i=0; i < estatura.Length; i++)
            {
                double distancia = Math.Abs(promedio - estatura[i]);
                Console.WriteLine("Distancia de " + nombres[i] + ", osea dato " + i + " con el promedio: " + distancia);
            }
            
        }
    }
}
