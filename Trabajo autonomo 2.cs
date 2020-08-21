using System;

namespace Trabajo_autonomo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          $$$ Blackjack $$$");
            //Entrada de variales
            Random aleatorio = new Random();
            int jugador = 1;
            string respuesta = "";
            //Pregunta cantidad de Jugadores
            Console.WriteLine("¿Cantidad de jugadores? (2-5 only)");
            int cantidadJugadores = int.Parse(Console.ReadLine());
            //Validacion
            while (2 != cantidadJugadores && cantidadJugadores != 3 && cantidadJugadores != 4 && cantidadJugadores != 5)
            {
                Console.WriteLine("Ingresaste un mal un dato, intenta de nuevo.");
                cantidadJugadores = int.Parse(Console.ReadLine());
            }
            //Arreglo de datos
            string[] nombres = new string[cantidadJugadores];
            int[] puntos = new int[cantidadJugadores];        
            //Inicio de juego
            while (jugador <= cantidadJugadores)
            {
                for (int i = 0; i < nombres.Length; i++)
                {
                    // Almacenar nombre en el arreglo de datos
                    Console.WriteLine("\nIngrese el nombre del jugador "+jugador +": ");
                    nombres[i] = Console.ReadLine();
                    // inicio de juego
                    Console.WriteLine("\n$$$ Empecemos el juego, Good Luck. $$$");
                    Console.WriteLine("\n" + nombres[i] + ", jugador: " + jugador);
                    int carta1 = aleatorio.Next(1, 11);
                    int carta2 = aleatorio.Next(1, 11);
                    Console.WriteLine("\nCarta 1: " + carta1);
                    Console.WriteLine("Carta 2: " + carta2);
                    int total = carta1 + carta2;
                    puntos[i] = total;
                    Console.WriteLine("Total: " + total);
                    // Pregunta de nueva carta
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
                            puntos[i] = total; //Almacena puntos en el arreglo de datos
                            Console.WriteLine("\n¡Perdiste!");
                            break;
                        }
                        else
                        {
                            puntos[i] = total; //Almacena puntos en el arreglo de datos
                            Console.WriteLine("\n¡Felicidades haz ganado!");
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
            }
            for (int j = 0; j < puntos.Length; j++)
            {
                for (int i = 0; i < puntos.Length - 1; i++)
                {
                    if (puntos[i] < puntos[i + 1]) //Ordenar de Mayor a menor
                    {
                        int tmp = puntos[i];
                        puntos[i] = puntos[i + 1];
                        puntos[i + 1] = tmp;

                        string tmp1 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp1;
                    }
                }
            }

            Console.WriteLine("\nResultados (Orden desendente): ");
            for (int i = 0; i < puntos.Length; i++)
            {
                Console.WriteLine(nombres[i] + " obtuvo " + puntos[i] + " puntos");
            }

            Console.WriteLine("\nResultados: Primer y segundo lugar");
            string[] resultados = { "Ganador", "Segundo lugar" }; 
            for (int i = 0; i < nombres.Length; i++)
            {
                
                Console.WriteLine("Ganador: " + nombres[i] + ", obtuvo " + puntos[i] + " puntos." + resultados[i]);
                
                if (puntos[i] > 21)
                {
                    Console.WriteLine(nombres[i] + " obtuvo " + puntos[i] + " puntos. ¡Ha perdido!");
                }
                
              
               
                  
                
            }
            



        }
    }
}
