using System;

class Program
{
    static void Main(string[] args)
    {
        int numeroUno = 70;
        double numeroDos = 67.89;
        double numeroTres = 67.89;

        Console.WriteLine(Suma(numeroUno, numeroDos));           // z toma valor 0
        Console.WriteLine(Suma(numeroUno, numeroDos, numeroTres)); // z = numeroTres

        Console.ReadKey();
    }

    // Método con parámetro opcional z (valor por defecto = 0)
    static double Suma(int x, double y, double z = 0)
    {
        return x + y + z;
    }
}