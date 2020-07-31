using System;

namespace Juego_Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          $$$ Blackjack $$$");
            Console.WriteLine("$$$ Empecemos el juego, Good Luck. $$$");
            Random aleatorio = new Random();
            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            Console.WriteLine("Carta 1: " + carta1);
            Console.WriteLine("Carta 2: " + carta2);
            int total = carta1 + carta2;
            Console.WriteLine("Total: " + total);


            string respuesta = "";
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
                    Console.WriteLine("\n ¡Haz perdido!"); respuesta = "n";
                }
                else
                {
                    Console.WriteLine("\n ¡Felicidades haz ganado el juego!"); respuesta = "n";
                }

            }
            if (total < 21)
            {
                Console.WriteLine("\n ¡Haz perdido!");
            }
        }
    }
}
