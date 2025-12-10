using System;

// CLASE PARCIAL - Parte 1
public partial class Coordenadas
{
    private int x;
    private int y;

    public Coordenadas(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

// CLASE PARCIAL - Parte 2
public partial class Coordenadas
{
    public void VerCoordenadas()
    {
        Console.WriteLine("Coordenadas: {0},{1}", x, y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Coordenadas miscCoords = new Coordenadas(10, 15);
        miscCoords.VerCoordenadas();
        Console.ReadKey();
    }
}