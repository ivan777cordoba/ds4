using System;

class Program
{
    static void Main(string[] args)
    {
        // SOBRECARGA: mismo nombre, diferentes tipos de parámetros
        Console.WriteLine("Suma int: " + Suma(5, 3));
        Console.WriteLine("Suma double: " + Suma(1.5, 2.7));
        Console.WriteLine("Suma long: " + Suma(100000L, 200000L));
        
        Console.ReadKey();
    }

    // Tres métodos con mismo nombre pero diferentes parámetros
    static int Suma(int x, int y)
    {
        return x + y;
    }

    static double Suma(double x, double y)
    {
        return x + y;
    }

    static long Suma(long x, long y)
    {
        return x + y;
    }
}