// Archivo: Program.cs
// Proyecto: Laboratorio2
// Namespace: Laboratorio2
// Lenguaje: C#
// Este es el código del laboratorio 2. Solo ejemplos de sintaxis y tipos básicos.

using System;

namespace Laboratorio2
{
    // Clase para probar variables de instancia y de clase (estáticas)
    class DemoVariables
    {
        // Esta variable es de instancia (cada objeto tiene su propia copia)
        public int instanciaEntero;

        // Esta es estática = compartida entre todos los objetos de la clase
        public static string claseTexto = "Valor estático inicial";

        // Constructor para asignar el valor de instancia
        public DemoVariables(int valor)
        {
            instanciaEntero = valor;
        }
    }

    // Clase Persona (tipo referencia)
    class Persona
    {
        public string Nombre;
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Laboratorio 2 - Sintaxis y tipos básicos ===");
            Console.WriteLine();

            // -------------------------
            // Variables locales
            // -------------------------
            int variableLocal = 10; // esta solo existe dentro de este método
            Console.WriteLine("Variable local (int) = " + variableLocal);

            // -------------------------
            // Variables de instancia y de clase
            // -------------------------
            DemoVariables obj1 = new DemoVariables(5);  // objeto 1 con su instanciaEntero
            DemoVariables obj2 = new DemoVariables(20); // objeto 2 con otro valor

            Console.WriteLine();
            Console.WriteLine("obj1.instanciaEntero = " + obj1.instanciaEntero);
            Console.WriteLine("obj2.instanciaEntero = " + obj2.instanciaEntero);

            // accedo a la estática desde la clase (no necesito objeto)
            Console.WriteLine("Variable estática DemoVariables.claseTexto = " + DemoVariables.claseTexto);

            // cambio el valor estático -> se refleja en todos
            DemoVariables.claseTexto = "Nuevo valor estático";
            Console.WriteLine("Nuevo valor estático = " + DemoVariables.claseTexto);

            // -------------------------
            // Tipos de valor
            // -------------------------
            short s = -300;   // número chico
            int i = 123456;   // número normal
            long l = 1234567890123L; // número grande
            Console.WriteLine();
            Console.WriteLine("short = " + s + ", int = " + i + ", long = " + l);

            float f = 3.1415F;   // precisión simple
            double d = 2.718281828459; // doble precisión
            decimal dec = 1000.50M; // decimal para dinero
            Console.WriteLine("float = " + f + ", double = " + d + ", decimal = " + dec);

            char c = 'A';             // un solo carácter
            string texto = "Hola, C#"; // texto (cadena)
            Console.WriteLine("char = " + c + ", string = " + texto);

            bool bandera = true; // booleano
            Console.WriteLine("bool = " + bandera);

            // -------------------------
            // Tipos de valor copian
            // -------------------------
            int valor1 = 28;
            int valor2 = valor1; // aquí se copia el valor
            valor2 = 30;         // cambio valor2 pero valor1 queda igual
            Console.WriteLine();
            Console.WriteLine("valor1 = " + valor1 + ", valor2 = " + valor2);

            // -------------------------
            // Tipos de referencia (comparten la dirección en memoria)
            // -------------------------
            Persona persona1 = new Persona("Carlos");
            Persona persona2 = persona1; // los dos apuntan al mismo objeto
            persona2.Nombre = "María";  // cambio en persona2 también cambia persona1

            Console.WriteLine();
            Console.WriteLine("persona1.Nombre = " + persona1.Nombre);
            Console.WriteLine("persona2.Nombre = " + persona2.Nombre);

            // -------------------------
            // Null = referencia vacía
            // -------------------------
            Persona personaNull = null; // todavía no apunta a ningún objeto
            Console.WriteLine();
            Console.WriteLine("personaNull es null? " + (personaNull == null));

            // -------------------------
            // Declarar y asignar en la misma línea
            // -------------------------
            int otroEntero = 42;
            string otraCadena = "Laboratorio";
            char otraLetra = 'Z';
            Console.WriteLine();
            Console.WriteLine("otroEntero = " + otroEntero + ", otraCadena = " + otraCadena + ", otraLetra = " + otraLetra);

            Console.WriteLine();
            Console.WriteLine("=== Fin del Laboratorio 2 ===");
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
