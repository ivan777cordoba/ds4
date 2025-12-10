using System;

public class Banco
{
    // ATRIBUTOS: 3 objetos de la clase Cliente
    private Cliente cliente1, cliente2, cliente3;

    // CONSTRUCTOR
    public Banco()
    {
        // Crear 3 clientes con nombres diferentes
        cliente1 = new Cliente("Yhonas");
        cliente2 = new Cliente("Ana");
        cliente3 = new Cliente("Pedro");
    }

    // MÉTODO para simular operaciones bancarias
    public void Operar()
    {
        // Cada cliente hace depósitos y extracciones
        cliente1.Depositar(100);
        cliente2.Depositar(150);
        cliente3.Depositar(200);
        cliente3.Extraer(150);  // Pedro extrae 150
    }

    // MÉTODO para calcular y mostrar totales
    public void DepositosTotales()
    {
        // Sumar los montos de los 3 clientes
        int total = cliente1.RetornarMonto() + 
                   cliente2.RetornarMonto() + 
                   cliente3.RetornarMonto();
        
        Console.WriteLine("El total de dinero en el banco es: " + total);
        
        // Mostrar información de cada cliente
        cliente1.Imprimir();
        cliente2.Imprimir();
        cliente3.Imprimir();
    }
}