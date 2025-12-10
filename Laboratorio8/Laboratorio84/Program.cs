using System;

// Propiedades de lectura/escritura
public class Empleado
{
    private string nombre;

    // PROPIEDAD con get y set
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }  // 'value' es el valor asignado
    }
}

// Propiedades con validación
public class CuentaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
        set 
        { 
            if (value >= 0)
                saldo = value;
            else
                throw new ArgumentException("El saldo no puede ser negativo.");
        }
    }
}

// Propiedades de solo lectura
public class Cobertura
{
    private double radio;

    public Cobertura(double radio)
    {
        this.radio = radio;
    }

    // SOLO LECTURA - no tiene 'set'
    public double Radio
    {
        get { return radio; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Probar Empleado
        Empleado empleado = new Empleado();
        empleado.Nombre = "John Doe";
        Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");

        // Probar CuentaBancaria
        CuentaBancaria cta = new CuentaBancaria();
        cta.Saldo = 100;
        Console.WriteLine($"El saldo de la cuenta: {cta.Saldo}");

        // Probar con saldo negativo (descomenta para ver el error)
        // cta.Saldo = -50;  // Esto lanzará una excepción

        // Probar Cobertura (solo lectura)
        Cobertura c = new Cobertura(5);
        Console.WriteLine($"Radio de cobertura: {c.Radio}");
        // c.Radio = 10;  // Error: solo lectura

        Console.ReadKey();
    }
}