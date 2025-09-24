using System;

namespace Laboratorio33
{
	class CalculosMatematicos
	{
		public static int CalcularPerimetro(int lado1, int lado2)
		{
			// fórmula perímetro = 2*(lado1 + lado2)
			return 2 * (lado1 + lado2);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// pido los lados al usuario
			Console.Write("Ingrese el valor del lado 1: ");
			int lado1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingrese el valor del lado 2: ");
			int lado2 = Convert.ToInt32(Console.ReadLine());

			// llamo al método
			int perimetro = CalculosMatematicos.CalcularPerimetro(lado1, lado2);

			// muestro resultado
			Console.WriteLine("El perímetro del rectángulo es: " + perimetro);

			Console.WriteLine("Presione una tecla para salir...");
			Console.ReadKey();
		}
	}
}
