using System;

// CLASE BASE
public class Cuenta
{
    private string idCuenta;

    public Cuenta(string idCuenta)
    {
        this.idCuenta = idCuenta;
        Console.WriteLine("Constructor Class Base para cuenta {0}", idCuenta);
    }

    // MÉTODO VIRTUAL - puede ser sobrescrito por clases hijas
    public virtual void CalcularIntereses()
    {
        Console.WriteLine("Cuenta.CalcularIntereses() para la cuenta {0}", this.idCuenta);
    }

    public string getIdCuenta()
    {
        return this.idCuenta;
    }
}

// CLASE HIJA 1
public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string idCuenta) : base(idCuenta)
    {
    }

    // SOBRESCRIBE el método de la clase base
    public override void CalcularIntereses()
    {
        Console.WriteLine("CuentaCorriente.CalcularIntereses() para {0}", getIdCuenta());
    }
}

// CLASE HIJA 2
public class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string idCuenta) : base(idCuenta)
    {
    }

    // SOBRESCRIBE el método de la clase base
    public override void CalcularIntereses()
    {
        Console.WriteLine("CuentaAhorro.CalcularIntereses() para {0}", getIdCuenta());
    }
}

class Program
{
    static void Main(string[] args)
    {
        const string CUENTA = "100";

        // Crear diferentes tipos de cuentas
        Cuenta cuenta = new Cuenta(CUENTA);
        CuentaCorriente cuentaCorriente = new CuentaCorriente(CUENTA);
        CuentaAhorro cuentaAhorro = new CuentaAhorro(CUENTA);

        // POLIMORFISMO: mismo método, comportamiento diferente
        cuenta.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
        cuentaAhorro.CalcularIntereses();

        Console.ReadKey();
    }
}