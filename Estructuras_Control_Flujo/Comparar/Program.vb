Imports System

Module Comparar
    Sub Main(args As String())
        Dim a, b As Integer
        Console.Write("Ingrese un valor: ")
        a = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        b = Console.ReadLine
        If a = b Then
            Console.WriteLine("Los numeros son iguales")
        End If
        If a < b Then
            Console.WriteLine("El primer numero es menor: ")
        End If
        If a > b Then
            Console.WriteLine("El primer numero es mayor: ")
        End If

    End Sub
End Module
'Crear un proyecto y un m�dulo �Comparar� para resolver con If: se ingresan dos valores
'num�ricos e informar por pantalla cu�l es la relaci�n entre ambos: mayor, menor o igual.