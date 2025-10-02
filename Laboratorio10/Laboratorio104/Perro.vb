Public Class Perro
    ' Propiedades (como variables públicas)
    Public nombre As String
    Public raza As String
    Public altura As String

    ' MÉTODO que retorna un valor
    Public Function comer(carne As String) As String
        Return nombre + " mide " + altura + " y comerá " + carne
    End Function

    ' MÉTODOS que no retornan valor
    Public Sub dormir()
        ' Aquí iría el código para dormir
    End Sub

    Public Sub ladrar()
        ' Aquí iría el código para ladrar
    End Sub

    ' MÉTODO que hace cálculo
    Public Function calcularCosto(costo As Double, impuesto As Double) As Double
        Dim preciototal As Double
        preciototal = costo + (costo * impuesto)
        Return preciototal
    End Function

    ' CONSTRUCTOR vacío
    Public Sub New()
        ' Constructor sin parámetros
    End Sub

    ' CONSTRUCTOR con parámetros
    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre   ' "Me" es como "this" en C#
        Me.raza = raza
        Me.altura = altura
    End Sub

End Class