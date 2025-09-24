using System;

class Program
{
    private int[,] mat; // Declaramos matriz bidimensional

    public void Ingresar()
    {
        mat = new int[3, 4]; // 3 filas, 4 columnas
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write("Ingrese posición [" + (f + 1) + ", " + (c + 1) + "]: ");
                string linea = Console.ReadLine();
                mat[f, c] = int.Parse(linea);
            }
        }
    }

    public void Imprimir()
    {
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write(mat[f, c] + " ");
            }
            Console.WriteLine(); // Salto de línea después de cada fila
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Program ma = new Program();
        ma.Ingresar();
        ma.Imprimir();
    }
}