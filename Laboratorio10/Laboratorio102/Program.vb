Module area

    Sub Main()
        ' Declarar variables
        Dim radio As Single
        Dim area As Single
        Dim circunferencia As Single
        Const pi = 3.1415926  ' Constante no cambia

        ' Pedir datos al usuario
        Console.Write("Ingrese el radio: ")
        radio = Console.ReadLine()  ' Leer lo que escribe el usuario

        ' Calcular
        area = pi * radio ^ 2          ' ^ es para potencia (radio al cuadrado)
        circunferencia = 2 * pi * radio

        ' Mostrar resultados
        Console.WriteLine("El area es : {0}", area)
        Console.WriteLine("La circunferencia es : {0}", circunferencia)

        Console.ReadKey()
    End Sub

End Module