using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el numero deseado");
        
        try
        {
            num = Int16.Parse(Console.ReadLine());
        }
        catch (FormatException ex)  // Error cuando no es un número
        {
            Console.WriteLine("No se ha introducido un dígito valido");
            num = -1;
        }
        catch (OverflowException ex)  // Error cuando el número es muy grande
        {
            Console.WriteLine("El numero introducido es muy grande");
            num = -1;
        }
        
        Console.WriteLine("El valor ingresado es: " + num);
        Console.ReadKey();
    }
}