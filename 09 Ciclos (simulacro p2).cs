using System;

namespace _09_Ciclos__simulacro_p2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Juego de Dado 2!");
            int puntos = 0, contadorVidas = 3, contador1s = 0, contador6s = 0, dados12Caras = 2, dadoEspecial = 0, dado2 = 0;
            string respuesta = "", respuestaDados = "";
            Random aleatorio = new Random();

            /*int dado1 = aleatorio.Next(1, 7);*/
            int dado1 = int.Parse(Console.ReadLine());
            puntos = dado1;
            if (dado1 == 1) contador1s += 1;
            if (dado1 == 6) contador6s += 1;
            Console.WriteLine("\nSu dado es: " + dado1);
            Console.WriteLine("Total de puntos: " + puntos);
            Console.WriteLine("Vidas: " + contadorVidas);
            
            Console.WriteLine("\n¿Desea tirar un nuevo dado o desea retirarse?\n(s)/(n)");
            respuesta = Console.ReadLine();

            while (respuesta == "s" && puntos < 100)
            {
                if (dados12Caras != 0)
                {
                    Console.WriteLine("¿Desea usar un dado especial? " + "\nDados especiales: (" + dados12Caras + ")\n(s)/(n)");
                    respuestaDados = Console.ReadLine();
                    if (respuestaDados == "s")
                    {
                        dados12Caras -= 1;
                        dadoEspecial = aleatorio.Next(1, 13);
                        //dadoEspecial = int.Parse(Console.ReadLine());
                        puntos += dadoEspecial;
                        if (dadoEspecial == 1) contador1s += 1;
                        if (dadoEspecial == 6) contador6s += 1;
                        Console.WriteLine("\nSu dado especial es: " + dadoEspecial);
                        Console.WriteLine("Total de puntos: " + puntos);
                    }
                    else
                    {    
                        int dado2 = aleatorio.Next(1, 7);
                        //dado2 = int.Parse(Console.ReadLine());
                        puntos += dado2;
                        Console.WriteLine("\nSu nuevo dado es: " + dado2);
                        Console.WriteLine("Total de puntos: " + puntos);
                    }
                }
                else
                {
                    int dado2 = aleatorio.Next(1, 7);
                    //dado2 = int.Parse(Console.ReadLine());
                    puntos += dado2;
                    Console.WriteLine("\nSu nuevo dado es: " + dado2);
                    Console.WriteLine("Total de puntos: " + puntos);
                }

                if (respuesta == "s" && contador6s == 1 && dado2 == 6 && contadorVidas < 3)
                {
                    contadorVidas += 1;
                    contador6s = 0;
                }
                if (dado2 == 1 || dadoEspecial == 1)
                {
                    contador1s += 1;
                }
                if (contador1s == 2)
                {
                    contadorVidas -= 1;
                    puntos -= 10;
                    contador1s = 0;
                }
                if (contadorVidas == 0)
                {
                    Console.WriteLine("¡Haz perdido!"); break;
                }
                if (dado2 == 6 || dadoEspecial == 6)
                {
                    contador6s += 1;
                }
                if (puntos >= 100)
                {
                    Console.WriteLine("¡Felicidades haz ganado!"); break;
                }

                Console.WriteLine("Vidas: " + contadorVidas);
                Console.WriteLine("¿Desea tirar un nuevo dado o desea retirarse?\n(s)/(n)");
                respuesta = Console.ReadLine();
            }
            if (respuesta == "n")
            {
                Console.WriteLine("¡Te haz retirado!");
                Console.WriteLine("¡Haz perdido!");
            }

        }
    }
}
