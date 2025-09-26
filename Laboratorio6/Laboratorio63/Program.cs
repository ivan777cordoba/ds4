using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] myNumbers = {1, 2, 3};
            Console.WriteLine(myNumbers[10]);  // ¡Error! El índice 10 no existe
        }
        catch (Exception e)  // Captura cualquier tipo de error
        {
            Console.WriteLine("Algo salio mal, valide el índice del arreglo");
            Console.WriteLine("Error: " + e.Message);  // Mostramos el mensaje del error
        }
        finally
        {
            // Este bloque SIEMPRE se ejecuta, haya error o no
            Console.WriteLine("Continuacion de la aplicacion, luego del bloque try/catch");
        }
        
        Console.ReadKey();
    }
}