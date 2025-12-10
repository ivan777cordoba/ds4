using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Números del 1 al 100 que son pares o divisibles entre 3:");
        Console.WriteLine("--------------------------------------------------------");

        // Recorrer del 1 al 100
        for (int i = 1; i <= 100; i++)
        {
            // Verificar si es par O divisible entre 3
            if (i % 2 == 0 || i % 3 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}