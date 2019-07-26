Imports System
Imports System.Math
Module Hipotenusa
    Sub Main(args As String())
        validar()

    End Sub

    Function validar() As Integer
        Dim a, b As Integer
        Console.Write("Ingrese el lado A: ")
        a = Console.ReadLine()
        Console.Write("Ingrese el lado B: ")
        b = Console.ReadLine()
        If a Mod 2 = 0 And b Mod 2 = 0 Then
            Return hipotenusa(a, b)
        Else
            Return validar()
        End If

    End Function


    Function hipotenusa(a, b) As Integer
        Dim c As Integer
        c = Pow(a, 2) + Pow(b, 2)
        c = Pow(c, 2)
        Console.WriteLine("La hipotenusa el triangulo es: " & c)
        Return 0
    End Function


End Module
'Utilizar una función para validar los valores ingresados en el punto 2.3 sean enteros
'positivos, si no cumple esta condición pedir el reingreso del dato.