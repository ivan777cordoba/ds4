using System;

class Program
{
    static void Main(string[] args)
    {
        double lado1, lado2, lado3;

        // Pedir los 3 lados
        Console.WriteLine("Ingrese los 3 lados del triángulo:");
        Console.Write("Lado 1: ");
        lado1 = double.Parse(Console.ReadLine());
        Console.Write("Lado 2: ");
        lado2 = double.Parse(Console.ReadLine());
        Console.Write("Lado 3: ");
        lado3 = double.Parse(Console.ReadLine());

        // Primero verificar si puede ser un triángulo
        // La suma de dos lados debe ser mayor que el tercero
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            // Verificar tipo de triángulo
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo EQUILÁTERO (todos los lados iguales)");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo ISÓSCELES (dos lados iguales)");
            }
            else
            {
                Console.WriteLine("Es un triángulo ESCALENO (todos los lados diferentes)");
            }
        }
        else
        {
            Console.WriteLine("¡Estos lados NO forman un triángulo!");
            Console.WriteLine("Recuerda: la suma de dos lados debe ser mayor al tercero");
        }

        Console.ReadKey();
    }
}