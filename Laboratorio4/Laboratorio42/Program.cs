using System;

class Program
{
    static void Main(string[] args)
    {
        int fac = 1, n;
        string linea;

        Console.Write("Ingrese un numero entero: ");
        linea = Console.ReadLine();
        n = int.Parse(linea);

        // For: i va desde 1 hasta n, incrementando de 1 en 1
        for (int i = 1; i <= n; i++)
        {
            fac = fac * i;  // Multiplicamos acumulativamente
        }

        Console.Write("La factorial es: " + fac);
        Console.ReadKey();
    }
}