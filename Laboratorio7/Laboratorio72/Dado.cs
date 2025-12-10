using System;

public class Dado
{
    // ATRIBUTOS
    private int valor;           // Valor actual del dado (1-6)
    private static Random aleatorio = new Random();  // Generador de números aleatorios

    // CONSTRUCTOR
    public Dado()
    {
        // El generador de números aleatorios ya está inicializado como static.
    }

    // MÉTODO para tirar el dado
    public void Tirar()
    {
        // Next(1,7) genera números entre 1 y 6
        valor = aleatorio.Next(1, 7);
    }

    // MÉTODO para mostrar el valor del dado
    public void Imprimir()
    {
        Console.WriteLine("El valor del dado es: " + valor);
    }

    // MÉTODO para obtener el valor (sin mostrar)
    public int RetornarValor()
    {
        return valor;
    }
}