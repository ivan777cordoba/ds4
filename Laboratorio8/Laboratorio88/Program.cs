using System;

// CLASE ABSTRACTA - no se puede instanciar directamente
abstract class ClassAbstracta
{
    // MÉTODO ABSTRACTO - debe ser implementado por clases hijas
    protected abstract string tomarValor();
    
    // Otro método abstracto
    public abstract string prefixValor(string prefix);
    
    // Método común (no abstracto)
    public void printOut()
    {
        Console.WriteLine(tomarValor());
    }
}

// CLASE CONCRETA que implementa la clase abstracta
class ClassConcreta1 : ClassAbstracta
{
    protected override string tomarValor()
    {
        return "ClassConcreta1";
    }
    
    public override string prefixValor(string prefix)
    {
        return $"{prefix}ClassConcreta1";
    }
}

class ClassConcreta2 : ClassAbstracta
{
    protected override string tomarValor()
    {
        return "ClassConcreta2";
    }
    
    public override string prefixValor(string prefix)
    {
        return $"{prefix}ClassConcreta2";
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClassConcreta1 concreta1 = new ClassConcreta1();
        concreta1.printOut();
        Console.WriteLine(concreta1.prefixValor("ES_"));
        
        ClassConcreta2 concreta2 = new ClassConcreta2();
        concreta2.printOut();
        Console.WriteLine(concreta2.prefixValor("ES_"));
        
        Console.ReadKey();
    }
}