using System;

namespace Laboratorio104
{
    public class Perro
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Perro(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Ladrar()
        {
            Console.WriteLine($"{Nombre} dice: ¡Guau!");
        }
    }
}
