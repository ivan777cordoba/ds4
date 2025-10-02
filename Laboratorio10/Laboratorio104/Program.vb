Module Program
    Sub Main()
        Dim miPerro As New Perro("Firulais", 3)
        Console.WriteLine($"Nombre: {miPerro.Nombre}, Edad: {miPerro.Edad}")
        miPerro.Ladrar()
        Console.ReadKey()
    End Sub
End Module
