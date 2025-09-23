using System;

namespace Laboratorio31
{
    // Clase con el método para calcular
    class CalculosMatematicos
    {
        public static int Calcular(int a, int b)
        {
            // hago la operación (a+b)*(a-b)
            return (a + b) * (a - b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // pedir valores al usuario
            Console.Write("Ingrese el primer número (a): ");
            int a = Convert.ToInt32(Console.ReadLine()); // convierto string a int

            Console.Write("Ingrese el segundo número (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            // llamar al método
            int resultado = CalculosMatematicos.Calcular(a, b);

            // mostrar el resultado
            Console.WriteLine("El resultado de (a+b)*(a-b) es: " + resultado);

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
