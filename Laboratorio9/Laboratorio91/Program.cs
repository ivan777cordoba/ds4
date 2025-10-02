using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables para almacenar datos
        double precio = 0;
        string formaPago;
        string numeroCuenta = "";

        // Pedir precio (debe ser positivo)
        Console.Write("Ingrese el precio del producto (valor positivo): ");
        precio = double.Parse(Console.ReadLine());

        // Validar que el precio sea positivo
        while (precio <= 0)
        {
            Console.Write("Precio inválido. Ingrese un valor positivo: ");
            precio = double.Parse(Console.ReadLine());
        }

        // Pedir forma de pago
        Console.Write("Forma de pago (efectivo/tarjeta): ");
        formaPago = Console.ReadLine().ToLower(); // Convertir a minúsculas

        // Si paga con tarjeta, pedir número de cuenta
        if (formaPago == "tarjeta")
        {
            Console.Write("Ingrese número de cuenta (16 dígitos): ");
            numeroCuenta = Console.ReadLine();

            // Validar que tenga 16 dígitos
            while (numeroCuenta.Length != 16)
            {
                Console.Write("Número inválido. Ingrese 16 dígitos: ");
                numeroCuenta = Console.ReadLine();
            }
        }

        // Mostrar resumen
        Console.WriteLine("\n--- RESUMEN DE COMPRA ---");
        Console.WriteLine("Precio: $" + precio);
        Console.WriteLine("Forma de pago: " + formaPago);
        if (formaPago == "tarjeta")
        {
            Console.WriteLine("Número de cuenta: " + numeroCuenta);
        }
        Console.WriteLine("¡Gracias por su compra!");

        Console.ReadKey();
    }
}