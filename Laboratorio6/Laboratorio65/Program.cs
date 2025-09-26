using System;

class Program
{
    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Accesso negado - Edad: " + age + " es menor de 18");
        }
        else if (age > 100)
        {
            throw new ArithmeticException("Accesso negado - Edad: " + age + " no es válida");
        }
        else
        {
            Console.WriteLine("Acceso Concedido para edad: " + age);
        }
    }

    static void Main(string[] args)
    {
        int[] edades = { 15, 25, 105, 20 };
        
        foreach (int edad in edades)
        {
            try
            {
                checkAge(edad);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        
        Console.ReadKey();
    }
}