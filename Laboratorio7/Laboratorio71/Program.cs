using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto Banco
        Banco banco1 = new Banco();
        
        // Realizar operaciones
        banco1.Operar();
        
        // Mostrar resultados
        banco1.DepositosTotales();
        
        Console.ReadKey();  // Pausa para ver resultados
    }
}