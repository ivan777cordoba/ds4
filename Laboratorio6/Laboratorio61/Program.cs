using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el numero deseado");
        
        try
        {
            num = Int16.Parse(Console.ReadLine()); // Intenta convertir a número
        }
        catch (FormatException ex)  // Captura error de formato (cuando no es número)
        {
            Console.WriteLine("No ha introducido un dígito valido");
            num = -1; // Valor por defecto en caso de error
        }
        
        Console.WriteLine("El valor ingresado es: " + num);
        Console.ReadKey();
    }
}