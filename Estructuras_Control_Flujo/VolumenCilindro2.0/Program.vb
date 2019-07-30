Imports System
Imports System.Math
Module VolumenCilindro
    Sub Main(args As String())
        volumen()

    End Sub

    Function volumen() As Single
        Dim r, h As Single
        Console.Write("Ingrese el Radio: ")
        r = Console.ReadLine()
        Console.Write("Ingrese la Altura: ")
        h = Console.ReadLine()
        Return validar(r, h)

    End Function

    Function validar(r, h) As Single
        Dim v, p As Single
        p = 3.14159265
        If r > 0 And h > 0 Then
            v = p * (Pow(r, 2) * h)
            Console.WriteLine("El volumen es: " & v)
        Else
            Console.WriteLine("Numero Negativo!")
            Return volumen()
        End If
    End Function


End Module