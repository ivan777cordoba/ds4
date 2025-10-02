using System;

namespace Laboratorio104
{
	class Program
	{
		static void Main(string[] args)
		{
			Perro miPerro = new Perro("Firulais", 3);
			Console.WriteLine($"Nombre: {miPerro.Nombre}, Edad: {miPerro.Edad}");
			miPerro.Ladrar();
		}
	}
}
