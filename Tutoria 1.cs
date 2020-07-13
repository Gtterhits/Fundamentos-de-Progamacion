using System;

namespace Tutoria_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada del usuario de la variable X1
            Console.Write("Ingrese X1: ");
            double x1 = double.Parse(Console.ReadLine());

            // Entrada del usuario de la variable Y1
            Console.Write("Ingrese Y1: ");
            double y1 = double.Parse(Console.ReadLine());

            // Entrada del usuario de la variable X2
            Console.Write("Ingrese X1: ");
            double x2 = double.Parse(Console.ReadLine());

            // Entrada del usuario de la variable Y2
            Console.Write("Ingrese Y1: ");
            double y2 = double.Parse(Console.ReadLine());

            // Calculos de la pentiente
            double m = (y2 - y1) / (x2 - x1);
            // Calculo del intercepto en y=m*x+b despejando queda b=y1-m*x1
            double b = y1 - (m * x1);
            // Calculo de la distancia
            double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            // Salidas
            Console.WriteLine("La pendiente es: "+m);
            Console.WriteLine("El intercepto es: "+b);
            Console.WriteLine("La distancias: "+d);
        }
    }
}
