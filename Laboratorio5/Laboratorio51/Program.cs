using System;

class Program
{
    private int[] sueldos; // Declaramos el vector (arreglo)

    public void Cargar()
    {
        sueldos = new int[6]; // Inicializamos con 6 posiciones (índices 0 a 5)
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + f + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); // Guardamos en la posición f
        }
    }

    public void Imprimir()
    {
        Console.Write("Los 5 sueldos de los operarios: \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("[" + sueldos[f] + "] ");
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Program pv = new Program();
        pv.Cargar();
        pv.Imprimir();
    }
}