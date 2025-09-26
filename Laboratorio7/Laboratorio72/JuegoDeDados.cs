using System;

public class JuegoDeDados
{
    // ATRIBUTOS: 3 objetos Dado
    private Dado dado1, dado2, dado3;

    // CONSTRUCTOR
    public JuegoDeDados()
    {
        // Crear 3 dados
        dado1 = new Dado();
        dado2 = new Dado();
        dado3 = new Dado();
    }

    // MÉTODO principal del juego
    public void Jugar()
    {
        // Tirar los 3 dados
        dado1.Tirar();
        dado2.Tirar();
        dado3.Tirar();
        
        // Mostrar los valores
        dado1.Imprimir();
        dado2.Imprimir();
        dado3.Imprimir();
        
        // Verificar si los 3 dados son iguales
        if (dado1.RetornarValor() == dado2.RetornarValor() && 
            dado1.RetornarValor() == dado3.RetornarValor())
        {
            Console.WriteLine("Ganó");
        }
        else
        {
            Console.WriteLine("Perdió");
        }
        
        Console.ReadKey();
    }
}