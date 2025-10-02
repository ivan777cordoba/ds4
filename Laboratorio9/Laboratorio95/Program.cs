using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Aleatorios generador = new Aleatorios();
        
        Console.Write("¿Cuántos números no repetidos desea generar?: ");
        int cantidad = int.Parse(Console.ReadLine());
        
        Console.Write("Valor mínimo: ");
        int min = int.Parse(Console.ReadLine());
        
        Console.Write("Valor máximo: ");
        int max = int.Parse(Console.ReadLine());

        // Verificar que sea posible generar números no repetidos
        if (max - min + 1 < cantidad)
        {
            Console.WriteLine("¡Error! No se pueden generar " + cantidad + 
                            " números no repetidos entre " + min + " y " + max);
            Console.ReadKey();
            return;
        }

        // Generar números no repetidos
        List<int> numerosNoRepetidos = new List<int>();
        
        while (numerosNoRepetidos.Count < cantidad)
        {
            int numero = generador.GenerarNumero(min, max);
            
            // Si el número no está en la lista, lo agregamos
            if (!numerosNoRepetidos.Contains(numero))
            {
                numerosNoRepetidos.Add(numero);
            }
        }

        // Mostrar resultados
        Console.WriteLine("\nNúmeros no repetidos generados:");
        foreach (int num in numerosNoRepetidos)
        {
            Console.Write(num + " ");
        }

        Console.ReadKey();
    }
}