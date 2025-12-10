Module peso

    Sub Main()
        ' Declarar variables
        Dim M As Double    ' Masa
        Dim G As Double    ' Gravedad
        Dim P As Double    ' Peso

        ' Asignar valores
        G = 9.8  ' Gravedad de la Tierra
        Console.Write("Ingrese la masa del objeto: ")
        M = Console.ReadLine()

        ' Calcular peso
        P = M * G

        ' Mostrar resultado
        Console.WriteLine("Peso del objeto: {0}", P)
        Console.ReadKey()

    End Sub

End Module