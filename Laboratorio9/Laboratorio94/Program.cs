using System;

public class Aleatorios
{
    // Atributo: generador de números aleatorios
    private Random random;

    // Constructor
    public Aleatorios()
    {
        random = new Random();
    }

    // Método 1: Generar un número entre min y max
    public int GenerarNumero(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    // Método 2: Generar un arreglo de números aleatorios
    public int[] GenerarArreglo(int tamaño, int min, int max)
    {
        int[] arreglo = new int[tamaño];
        
        for (int i = 0; i < tamaño; i++)
        {
            arreglo[i] = GenerarNumero(min, max);
        }
        
        return arreglo;
    }
}