using System;

namespace Triangulo_doble_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valores de entrada de d, b, y
            Console.Write("Ingrese valor de d en grados: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de b en grados: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de y: ");
            double y = double.Parse(Console.ReadLine());
            // Angulo (b, d) de grados a radianes
            double drad = d * (Math.PI / 180);
            double brad = b * (Math.PI / 180);

            //Calculos 
            double e = 180 - d - b;
            double c = 180 - e;
            double crad = c * (Math.PI / 180);
            double z = y * Math.Tan(crad);

            //Resultados
            Console.WriteLine("El valor de z es: " + z);


        }
    }
}
