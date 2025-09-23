using System;

namespace Laboratorio32
{
    // Uso la misma clase del lab anterior pero agrego el método
    class CalculosMatematicos
    {
        public static double CalculoArea(double radio)
        {
            // fórmula área = π * r^2
            return Math.PI * radio * radio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // pido el radio al usuario
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            // llamo al método
            double area = CalculosMatematicos.CalculoArea(radio);

            // muestro resultado
            Console.WriteLine("El área del círculo es: " + area);

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
