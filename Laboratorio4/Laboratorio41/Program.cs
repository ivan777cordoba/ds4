using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaración de variables
        int n, x;
        string linea;

        // Pedir valor de n al usuario
        Console.Write("Ingrese el valor de n: ");
        linea = Console.ReadLine();  // Leemos lo que el usuario escribe
        n = int.Parse(linea);        // Convertimos a entero

        // Inicializamos x en 1 (empezamos desde 1)
        x = 1;

        // Mientras x sea menor o igual a n, se ejecuta el bloque
        while (x <= n)
        {
            Console.Write(x);        // Mostramos el número actual
            Console.Write(" , ");    // Separador
            x = x + 1;               // Incrementamos x en 1
        }

        // Pausa para ver el resultado
        Console.ReadKey();
    }
}