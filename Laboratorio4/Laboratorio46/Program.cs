using System;

class Program
{
    static void Main(string[] args)
    {
        const double PI = Math.PI;  // Constante (no cambia)
        double radio, area;

        Console.WriteLine("Digite el radio del círculo:");
        radio = double.Parse(Console.ReadLine());

        area = Math.Pow(radio, 2) * PI;  // radio al cuadrado * PI

        Console.WriteLine($"El área del círculo es: {area}");
        Console.ReadKey();
    }
}// Proyecto Laboratorio46
// Agrega aquí tu código principal
