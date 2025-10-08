using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Ingrese el valor de N (debe ser par y >= 6): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 6 || n % 2 != 0);

        int[,] matriz = new int[n, n];
        Random random = new Random();
        BigInteger producto = 1;

        // Llenar la matriz con ceros
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = 0;
            }
        }

        // Definir los bloques de 2x2 en las esquinas
        int[,] esquinas = {
            {0, 0}, {0, n-2}, {n-2, 0}, {n-2, n-2}
        };

        // Llenar los bloques con valores aleatorios y calcular el producto
        for (int k = 0; k < 4; k++)
        {
            int filaInicio = esquinas[k, 0];
            int columnaInicio = esquinas[k, 1];
            
            for (int i = filaInicio; i < filaInicio + 2; i++)
            {
                for (int j = columnaInicio; j < columnaInicio + 2; j++)
                {
                    int valor = random.Next(1, 101);
                    matriz[i, j] = valor;
                    producto *= valor;
                }
            }
        }

        // Mostrar la matriz
        Console.WriteLine("\nMatriz generada:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matriz[i, j],3} ");
            }
            Console.WriteLine();
        }

        // Mostrar el producto
        Console.WriteLine($"\nMultiplicación de elementos aleatorios: {producto}");
    }
}