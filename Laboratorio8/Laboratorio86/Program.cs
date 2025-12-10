using System;

class ClassBase
{
    public void test()
    {
    }
    
    // MÉTODO SEALED - no puede ser sobrescrito
    public sealed void masTests()
    {
    }
}

class ClassHijo : ClassBase
{
    // ERROR: No se puede sobrescribir un método sealed
    public override void masTests()  // ← Esto causa error
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Corrió la aplicación");
        Console.ReadKey();
    }
}