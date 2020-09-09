using System;

namespace Matrices_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }

            Console.WriteLine("Entrada: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }

            Console.WriteLine("Ahora, por favor ingrese una X.");
            Console.WriteLine("\nIngrese la fila: ");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese la columna: ");
            int columna = int.Parse(Console.ReadLine());
            Console.WriteLine("La posicion seleccionada fue: (" + fila + ", " + columna + ")");

            while (tablero[fila, columna] != "-")
            {
                Console.WriteLine("\nLa posicion (" + fila + ", " + columna + ") se encuentra ocupada.\nDebe seleccionar otra posicion.");
                Console.WriteLine("\nIngrese la fila: ");
                fila = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese la columna: ");
                columna = int.Parse(Console.ReadLine());
                Console.WriteLine("La posicion seleccionada fue: (" + fila + ", " + columna + ")");
            }

            salida[fila, columna] = "X";

            Console.WriteLine("\nSalida: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
        }
    }
}
