using System;

namespace Matrices
{
    class Matrices
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;
            double contadorXs = 0;
            double contadorOs = 0;
            double contadorRayas = 0;
            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++){
                for (int j = 0; j < tablero.GetLength(1); j++){
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }
            Console.WriteLine("Entrada: ");
            for (int i = 0; i < tablero.GetLength(0); i++){
                for (int j = 0; j < tablero.GetLength(1); j++){
                    if (tablero[i, j] == "X") contadorXs++;
                    if (tablero[i, j] == "O") contadorOs++;
                    if (tablero[i, j] == "-") contadorRayas++;
                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }

            // Calcular porcentaje de Xs, Os y -s
            double porcentajeXs = (contadorXs * 100) / (n * m);
            double porcentajeOs = (contadorOs * 100) / (n * m);
            double porcentajeRayas = (contadorRayas * 100) / (n * m);
            Console.WriteLine("\nPorcentaje de Xs: " + porcentajeXs + " %");
            Console.WriteLine("Porcentaje de Os: " + porcentajeOs + " %");
            Console.WriteLine("Porcentaje de -s: " + porcentajeRayas + " %");
            //Programa
            for (int i = 0; i < tablero.GetLength(0)-2; i++)
            {
                for (int j = 0; j < tablero.GetLength(1)-2; j++)
                {
                    

                    if (tablero[i, j + 2] == tablero[i, j] && tablero[i, j + 2] == tablero[i, j + 1] && tablero[i,j] == "X")
                    {
                        salida[i, j] = "1";
                        salida[i, j + 1] = "1";
                        salida[i, j + 2] = "1";
                    }

                    if (tablero[i + 2, j] == tablero[i, j] && tablero[i + 2, j] == tablero[i + 1, j] && tablero[i,j] == "X")
                    {
                        salida[i, j] = "1";
                        salida[i + 1, j] = "1";
                        salida[i + 2, j] = "1";
                    }

                    if (tablero[i, j + 2] == tablero[i, j] && tablero[i, j + 2] == tablero[i, j + 1] && tablero[i, j] == "O")
                    {
                        salida[i, j] = "2";
                        salida[i, j + 1] = "2";
                        salida[i, j + 2] = "2";
                    }

                    if (tablero[i + 2, j] == tablero[i, j] && tablero[i + 2, j] == tablero[i + 1, j] && tablero[i, j] == "O")
                    {
                        salida[i, j] = "2";
                        salida[i + 1, j] = "2";
                        salida[i + 2, j] = "2";
                    }
                }
            }
            
            Console.WriteLine("\nSalida: ");
            for (int i = 0; i < tablero.GetLength(0); i++){
                for (int j = 0; j < tablero.GetLength(1); j++){
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
        }
    }
}
