using System;

// CLASE SEALED - no puede ser heredada
sealed class ClassBase
{
    public void test()
    {
    }
    public void moreTesting()
    {
    }
}

// ERROR: No se puede heredar de una clase sealed
class ClassHijo : ClassBase  // ← Esto causa error
{
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Corrió la aplicación");
        Console.ReadKey();
    }
}