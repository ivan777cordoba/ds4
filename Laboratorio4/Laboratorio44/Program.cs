using System;

class Program
{
    static void Main(string[] args)
    {
        int edad;
        Console.Write("Ingrese su edad: ");
        edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("Eres menor de edad.");
        }

        Console.ReadKey();
    }
}