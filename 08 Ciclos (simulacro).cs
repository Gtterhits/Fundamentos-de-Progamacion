using System;
using System.IO;

namespace _08_Ciclos__simulacro_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Juego de dados");
            int puntos = 0, contadorTurnos = 1, numeroPares = 0, turnosSuma6 = 0;
            double porcentajeSuma = 0;
            string respuesta = "";


            Random aleatorio = new Random();
            //int dado1 = 1;
            //int dado2 = 1;
            int dado1 = aleatorio.Next(1, 7);
            int dado2 = aleatorio.Next(1, 7);
            Console.WriteLine("Su dado 1 es: " + dado1);
            Console.WriteLine("su dado 2 es: " + dado2);
            puntos = dado1 + dado2;
            Console.WriteLine("Total de puntos: " + puntos);

            if (dado1 + dado2 > 6)
            {
                turnosSuma6 += 1;
            }

            if (dado1 == 1 && dado2 == 1)
            {
                Console.WriteLine("\n¡Haz perdido!"); respuesta = "n";
            }
            else
            {
                Console.WriteLine("¿Desea tirar dos dados nuevos o desea retirarse?\nPara tirar (s) / Para retirarse (r)");
                respuesta = Console.ReadLine();
            }

            while (respuesta == "s" && puntos < 100)
            {
                int dado3 = aleatorio.Next(1, 7);
                int dado4 = aleatorio.Next(1, 7);
                puntos += dado3 + dado4;
                contadorTurnos += 1;
                if (dado3 == dado4) numeroPares += 1;
                if (dado1 + dado2 > 6) turnosSuma6 += 1;
                porcentajeSuma = (turnosSuma6 / contadorTurnos) * 100;

                Console.WriteLine("\nSu nuevo dado 1 es: " + dado3);
                Console.WriteLine("Su nuevo dado 2 es: " + dado4);
                Console.WriteLine("Total de puntos: " + puntos);
                
                if (dado3 == 1 && dado4 == 1)
                {
                    Console.WriteLine("\n¡Haz perdido!");
                    Console.WriteLine("Porcentaje de turnos donde la suma entre los dados fue superior a 6: " + porcentajeSuma + " %"); break;
                }
                if (puntos >= 100)
                {
                    Console.WriteLine("\n¡Felicidades!. Haz ganado el juego, llegaste hasta 100 puntos");
                    Console.WriteLine("Porcentaje de turnos donde la suma entre los dados fue superior a 6: " + porcentajeSuma + " %"); break;
                }
                if (numeroPares == 3)
                {
                    Console.WriteLine("\n¡Felicidades!. Haz ganado el juego, obtuviste 3 pares");
                    Console.WriteLine("Porcentaje de turnos donde la suma entre los dados fue superior a 6: " + porcentajeSuma + " %"); break;
                }

                Console.WriteLine("¿Desea tirar dos dados nuevos o desea retirarse?\nPara tirar (s) / Para retirarse (r)");
                respuesta = Console.ReadLine();

            }

            if (respuesta == "r")
            {
                Console.WriteLine("¡Te haz retirado!");
                Console.WriteLine("Porcentaje de turnos donde la suma entre los dados fue superior a 6: " + porcentajeSuma + " %");
            }
        }
    }
}
