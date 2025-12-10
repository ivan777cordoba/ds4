using System;

public class Cliente
{
    // ATRIBUTOS (variables de la clase)
    private string nombre;  // Guarda el nombre del cliente
    private int monto;      // Guarda el dinero que tiene el cliente

    // CONSTRUCTOR (se ejecuta al crear un objeto)
    public Cliente(string nom)
    {
        nombre = nom;  // Asigna el nombre recibido
        monto = 0;     // Inicia el monto en 0
    }

    // MÉTODO para depositar dinero
    public void Depositar(int m)
    {
        monto = monto + m;  // Suma el monto actual + el depósito
    }

    // MÉTODO para extraer dinero
    public void Extraer(int m)
    {
        monto = monto - m;  // Resta el monto actual - la extracción
    }

    // MÉTODO para obtener el monto actual
    public int RetornarMonto()
    {
        return monto;  // Devuelve el valor del monto
    }

    // MÉTODO para mostrar información del cliente
    public void Imprimir()
    {
        Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
    }
}