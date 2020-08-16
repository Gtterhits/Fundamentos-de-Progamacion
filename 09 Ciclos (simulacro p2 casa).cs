using System;

namespace _09_Ciclos__simulacro_p2_casa_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Juego de Dado 2!\nParte 2");

            int puntos = 0, contadorVidas = 3, contadorTurnos = 1;
            string respuesta = "";
            Random aleatorio = new Random();
            int dado1 = aleatorio.Next(1, 7);
            //int dado1 = int.Parse(Console.ReadLine());
            puntos += dado1;
            Console.WriteLine("\nSu dado es: " + dado1);
            Console.WriteLine("Total de puntos: " + puntos);
            Console.WriteLine("Vidas: " + contadorVidas);

            Console.WriteLine("\n¿Desea tirar un nuevo dado o desea retirarse?\n(s)/(n)");
            respuesta = Console.ReadLine();

            while (respuesta == "s" && puntos < 100) {
                int dado2 = aleatorio.Next(1, 7);
                //int dado2 = int.Parse(Console.ReadLine());
                puntos += dado2;
                contadorTurnos += 1;

                if (contadorTurnos != 4) {
                    Console.WriteLine("\nSu nuevo dado es: " + dado2);
                    Console.WriteLine("Total de puntos: " + puntos);

                    Console.WriteLine("Vidas: " + contadorVidas);
                }
                if (contadorTurnos == 2) {
                    contadorVidas -= 1;
                    Console.WriteLine("Vidas: " + contadorVidas);
                    Console.WriteLine("\nHan pasado 2 turnos. Haz perdido una vida.");
                }
                if (contadorTurnos == 4) {
                    int dado3 = aleatorio.Next(1, 7);
                    //int dado3 = int.Parse(Console.ReadLine());
                    int dado4 = aleatorio.Next(1, 7);
                    //int dado4 = int.Parse(Console.ReadLine());
                    int suma = dado3 + dado4;
                    puntos += suma;
                    Console.WriteLine("\nHan pasado 3 turnos. Puedes usar dos dados:\nDado 1: " + dado3 + "   Dado 2: " + dado4);
                    Console.WriteLine("Total de puntos: " + puntos);
                    Console.WriteLine("Vidas: " + contadorVidas);
                    if (dado3 == dado4)  {
                        contadorVidas += 1;
                        Console.WriteLine("Sacaste un doble. Haz ganado una vida.");
                        Console.WriteLine("Vidas: " + contadorVidas);
                    }
                    contadorTurnos = 0;
                }
                if (contadorVidas == 0) {
                    Console.WriteLine("¡Haz perdido!"); break;
                }
                if (puntos >= 100) {
                    Console.WriteLine("¡Felicidades haz ganado!"); break;
                }          
                Console.WriteLine("\n¿Desea tirar un nuevo dado o desea retirarse?\n(s)/(n)");
                respuesta = Console.ReadLine();
            }
            if (respuesta == "n") {
                Console.WriteLine("¡Te haz retirado!");
                Console.WriteLine("¡Haz perdido!");
            }
        }
    }
}
