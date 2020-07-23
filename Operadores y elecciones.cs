using System;

namespace Operadores_y_elecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de variables,
            Console.WriteLine("Programa de evaluacion y elecciones (Boole)");
            Console.WriteLine("Número de votos por el partido 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos por el partido 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Número total de la población de todas las edades: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje (de 0 a 100%) de la población que es mayor de edad: ");
            double p = double.Parse(Console.ReadLine());

            //Calculos
            int numeroVotosTotales = a + b + blancos + anulados;
            int poblacionMayorEdad = (int) (n * (p / 100));
            int abstencion = poblacionMayorEdad - numeroVotosTotales;

            Console.WriteLine("Población que es mayor de edad: " + poblacionMayorEdad);
            Console.WriteLine("Total de votantes: " + numeroVotosTotales);
            Console.WriteLine("Numero de personas abstenidas: " + abstencion);

            //Condiciones
            bool A = anulados < (a + b) * 0.3;
            bool B = (a + b) > blancos;
            bool C = abstencion < numeroVotosTotales;

            if ((A || B) && C)
            {
                if (a > b)
                {
                    string ganadorElecciones = "A";
                    Console.WriteLine("Las votaciones fueron exitosas.");
                    Console.WriteLine("El ganador de las elecciones es: " + ganadorElecciones);
                }
                else
                {
                    string ganadorElecciones = "B";
                    Console.WriteLine("Las votaciones fueron exitosas.");
                    Console.WriteLine("El ganador de las elecciones es: " + ganadorElecciones);
                }
            }
            else
            {
                Console.WriteLine("Lo sentimos. Las elecciones deben ser realizadas nuevamente. ");
            }

        }
    }
}

