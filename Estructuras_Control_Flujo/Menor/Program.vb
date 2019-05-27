Imports System

Module Menor
    Sub Main(args As String())
        Dim a, b, c, menor As Integer
        Console.Write("Ingrese un valor: ")
        a = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        b = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        c = Console.ReadLine
        If a < b And a < c Then
            menor = a
        End If
        If b < a And b < c Then
            menor = b
        End If
        If c < b And c < a Then
            menor = c
        End If
        Console.WriteLine("El numero menor es: " & menor)
    End Sub
End Module
'Crear un proyecto y un módulo “Menor” para resolver con If: ingresar tres valores y mostrar
'el menor.