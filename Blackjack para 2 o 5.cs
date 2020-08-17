using System;

namespace Blackjack_para_2_o_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          $$$ Blackjack $$$");
            Random aleatorio = new Random();
            int jugador = 1, jugador1Gano = 0, jugador2Gano = 0, jugador3Gano = 0, jugador4Gano = 0, jugador5Gano = 0;
            string respuesta = "";
            Console.WriteLine("¿Cantidad de jugadores? (2-5 only)");
            int cantidadJugadores = int.Parse(Console.ReadLine());
            while (2 != cantidadJugadores && cantidadJugadores != 3 && cantidadJugadores != 4 && cantidadJugadores != 5)
            {
                Console.WriteLine("ingresaste un mal un dato, intenta de nuevo.");
                cantidadJugadores = int.Parse(Console.ReadLine());
            }
            while (jugador <= cantidadJugadores)
            {
                Console.WriteLine("\n$$$ Empecemos el juego, Good Luck. $$$");
                Console.WriteLine("\nJugador: " + jugador);
                int carta1 = aleatorio.Next(1, 11);
                int carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("\nCarta 1: " + carta1);
                Console.WriteLine("Carta 2: " + carta2);
                int total = carta1 + carta2;
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Desea tomar una carta nueva? s/n");
                respuesta = Console.ReadLine();
                while (respuesta == "s" && total <= 21)
                {

                    int nuevaCarta = aleatorio.Next(1, 11);
                    total += nuevaCarta;
                    Console.WriteLine("Su nueva carta es: " + nuevaCarta);
                    Console.WriteLine("Total: " + total);
                    if (total < 21)
                    {
                        Console.WriteLine("Desea tomar una carta nueva? s/n");
                        respuesta = Console.ReadLine();
                    }
                    else if (total > 21)
                    {
                        Console.WriteLine("\n ¡Haz perdido!"); break;
                    }
                    else
                    {
                        Console.WriteLine("\n ¡Felicidades haz ganado el juego!");
                        jugador1Gano++;
                        jugador2Gano++;
                        jugador3Gano++;
                        jugador4Gano++;
                        jugador5Gano++;
                        break;
                    }
                }
                if (total < 21 && respuesta == "n")
                {
                    Console.WriteLine("\n¡Te haz retirado!");
                    Console.WriteLine("¡Haz perdido!");
                }
                jugador++;
            }
            if (jugador1Gano == 1)
            {
                Console.WriteLine("Resultados...\nJugador ganador: 1");
            }
            else if (jugador2Gano == 1)
            {
                Console.WriteLine("Resultados...\nJugador ganador: 2");
            }
            else if (jugador3Gano == 1)
            {
                Console.WriteLine("Resultados...\nJugador ganador: 3");
            }
            else if (jugador4Gano == 1)
            {
                Console.WriteLine("Resultados...\nJugador ganador: 4");
            }
            else if (jugador5Gano == 1)
            {
                Console.WriteLine("Resultados...\nJugador ganador: 5");
            }
        }   
    }
}
