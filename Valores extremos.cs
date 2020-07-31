using System;

namespace Valores_extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 0;
            string usuarioMayor = "";
            string usuarioMenor = "";
            double total = 0;

            while (i < n){
                Console.WriteLine("Nombre de usuario: ");
                string usuario = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (i == 0){
                    max = edad;
                    min = edad;
                }
                if (edad > max){
                    max = edad;
                    usuarioMayor = usuario;
                }
                if (edad < min){
                    min = edad;
                    usuarioMenor = usuario;
                }
                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.WriteLine("La edad promedio es: " + promedio);
            Console.WriteLine("Nombre de usuario: " + usuarioMayor + ". La edad maxima es: " + max);
            Console.WriteLine("Nombre de usuario: " + usuarioMenor + ". La edad minima es: " + min);
            Console.WriteLine("...Fin del programa...");
        }
    }
}
