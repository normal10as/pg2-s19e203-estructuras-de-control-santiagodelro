Imports System

Module Tercero
    Sub Main(args As String())
        Dim a, b, c, d, e, mayor As Integer
        Console.Write("Ingrese un valor: ")
        a = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        b = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        c = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        d = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        e = Console.ReadLine
        If a > b And a > c And a > d And a > e Then
            mayor = a
            Console.WriteLine("El mayor esta en la primera posicion : " & mayor)
        End If
        If b > a And b > c And b > d And b > e Then
            mayor = b
            Console.WriteLine("El mayor esta en la segunda posicion : " & mayor)
        End If
        If c > b And c > a And c > d And c > e Then
            mayor = c
            Console.WriteLine("El mayor esta en la tercera posicion : " & mayor)
        End If
        If d > b And d > a And d > c And d > e Then
            mayor = c
            Console.WriteLine("El mayor esta en la cuarta posicion : " & mayor)
        End If
        If e > b And e > a And e > d And e > c Then
            mayor = c
            Console.WriteLine("El mayor esta en la quinta posicion : " & mayor)
        End If
    End Sub
End Module
'Crear un proyecto y un módulo “Tercero” para resolver con If: ingresar 5 valores enteros e
'informar cual es el mayor por su posición de ingreso, por ejemplo, dado los siguientes
'valores: 3,7,12,5,9 informar: “El tercer número es el mayor valor”.