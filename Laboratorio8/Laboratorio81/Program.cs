using System;

// CLASE PADRE (Base)
class Persona
{
    // Campos públicos (pueden ser accedidos directamente)
    public string Nombre;
    public int Edad;
    public string NIF;

    // Método que incrementa la edad
    public void Cumpleaños()
    {
        Edad++;
    }

    // Constructor de Persona
    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }
}

// CLASE HIJA (Hereda de Persona)
class Trabajador : Persona
{
    // Campo adicional solo para Trabajador
    public int Sueldo;

    // Constructor de Trabajador
    public Trabajador(string nombre, int edad, string nif, int sueldo)
        : base(nombre, edad, nif)  // Llama al constructor de Persona
    {
        Sueldo = sueldo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un Trabajador (que también es una Persona)
        Trabajador p = new Trabajador("Josan", 22, "77588260-Z", 100000);
        
        // Podemos acceder a los campos de Persona y Trabajador
        Console.WriteLine("Nombre = " + p.Nombre);
        Console.WriteLine("Edad = " + p.Edad);
        Console.WriteLine("NIF = " + p.NIF);
        Console.WriteLine("Sueldo = " + p.Sueldo);
        
        Console.ReadKey();
    }
}