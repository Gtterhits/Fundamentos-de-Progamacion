using System;

namespace Validación
{
    class Validación
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validacion Captcha");
            int respuesta = 0, contadorTurnos = 1, turnosrestantes = 2;
            Random aleatorio = new Random();
            int a = aleatorio.Next(1, 11);
            int b = aleatorio.Next(1, 11);
            int suma = a + b;
            Console.WriteLine("¿Eres humano? suma estos numeros correctamente para continuar:");
            Console.WriteLine(a + " + " + b + " = ");
            respuesta = int.Parse(Console.ReadLine());
            
            while (contadorTurnos < 3 && respuesta != suma)
            {
                turnosrestantes -= 1;
                Console.WriteLine("Validación incorrecta.");
                Console.WriteLine("Generando nuevo Captcha, tienes " + turnosrestantes + " turnos restantes.");
                contadorTurnos += 1;
                int c = aleatorio.Next(1, 11);
                int d = aleatorio.Next(1, 11);
                suma = c + d;

                Console.WriteLine("¿Eres humano? suma estos numeros correctamente para continuar:");
                Console.WriteLine(c + " + " + d + " = ");
                respuesta = int.Parse(Console.ReadLine());
            }
            if (respuesta != suma)
            {
                Console.WriteLine("Validación incorrecta, no puedes continuar.");
            }
            if (respuesta == suma)
            Console.WriteLine("Puede continuar.");
        }
    }
}
