using System;

class Program
{
    static void checkAge(int age)
    {
        if (age < 18)
        {
            // Lanzamos una excepción personalizada
            throw new ArithmeticException("Accesso negado - No cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Acceso Concedido");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            checkAge(15);  // Esta edad provocará una excepción
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        
        Console.WriteLine("Programa continúa...");
        Console.ReadKey();
    }
}