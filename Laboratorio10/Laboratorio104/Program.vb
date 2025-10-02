Public Module Program
    Public Sub Main(args() As String)
        
        ' Crear perro 1 (usando constructor vacío)
        Dim perrito As Perro = New Perro()
        perrito.nombre = "chizu"
        perrito.raza = "Pastor Alemán"
        perrito.altura = "0.70cm"
        Console.WriteLine(perrito.comer("Carne"))

        ' Crear perro 2 (usando constructor vacío)
        Dim perrito2 As Perro = New Perro()
        perrito2.nombre = "Lasy"
        perrito2.altura = "0.60cm"
        Console.WriteLine(perrito2.comer("Pollo"))

        ' Crear perro 3 (usando constructor con parámetros)
        Dim perrito3 As Perro = New Perro("Peluchín", "Poodle", "0.50")
        Console.WriteLine(perrito3.comer("Pan"))

        Console.ReadKey()
    End Sub
End Module