Public Class Perro
    Public Property Nombre As String
    Public Property Edad As Integer

    Public Sub New(nombre As String, edad As Integer)
        Me.Nombre = nombre
        Me.Edad = edad
    End Sub

    Public Sub Ladrar()
        Console.WriteLine($"{Nombre} dice: ¡Guau!")
    End Sub
End Class
