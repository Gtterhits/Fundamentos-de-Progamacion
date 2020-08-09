using System;

namespace _08_Ciclos__simulacro_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Juego de dado");
            int puntos = 0, contadorTurnos = 1, contador12 = 0;
            string respuesta = "";

            Random aleatorio = new Random();
            int dado1 = aleatorio.Next(1, 13);
            Console.WriteLine("Su dado es: " + dado1);
            puntos = dado1;
            Console.WriteLine("Total de puntos: " + puntos);

            Console.WriteLine("¿Desea tirar un nuevo dado o desea retirarse?\nPara tirar (s) / Para retirarse (r)");
            respuesta = Console.ReadLine();
            while (respuesta == "s" && puntos < 100)
            {
                int dado2 = aleatorio.Next(1, 13);
                puntos += dado2;
                contadorTurnos += 1;
                Console.WriteLine("\nSu nuevo dado es: " + dado2);
                Console.WriteLine("Total de puntos: " + puntos);

                if (contadorTurnos > 3 && dado2 % 2 != 0)
                {
                    Console.WriteLine("\n¡Haz perdido!"); break;
                }

                if (contadorTurnos > 3 && dado2 == 12)
                {
                    contador12 += 1;
                    if (contador12 == 1 && dado2 == 10)
                    {
                        Console.WriteLine("¡Felicidades haz ganado!"); break;
                    }
                    else
                    {
                        contador12 = 0;
                    }

                }

                if (puntos >= 100)
                {
                    Console.WriteLine("¡Felicidades haz ganado!"); break;
                }

                Console.WriteLine("¿Desea tirar un nuevo dado o desea retirarse?\nPara tirar (s) / Para retirarse (r)");
                respuesta = Console.ReadLine();

            }
            if (respuesta == "r")
            {
                Console.WriteLine("¡Te haz retirado!");
                Console.WriteLine("\n¡Haz perdido!");
            }
        }
    }
}
