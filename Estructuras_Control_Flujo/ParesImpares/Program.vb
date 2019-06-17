Imports System
Imports System.Math

Module ParesImpares

    Sub Main(args As String())
        Dim numero As UInt16
        ParesImpares(numero)
    End Sub

    Sub ParesImpares(numero)
        Dim impar, par As UInt16
        Console.Write("Ingrese un valor: ")
        numero = Console.ReadLine
        While (numero <> 0)
            If numero Mod 2 = 0 Then
                par += 1
            Else
                impar += 1
            End If
            Console.Write("Ingrese un otro: ")
            numero = Console.ReadLine
        End While
        If par = 0 And impar <> 0 Then
            Console.WriteLine("Todos son impares: " & impar)
        ElseIf impar = 0 And par <> 0 Then
            Console.WriteLine("Todos son pares: " & par)
        Else
            Console.WriteLine("Pares: " & par)
            Console.WriteLine("Impares: " & impar)
        End If


    End Sub
End Module
'Crear un proyecto y un módulo “ParesImpares” Utilizando la estructura de repetición
'más adecuada elaborar un programa que se ingresen valores enteros hasta que se ingrese
'cero(descartar negativos).Luego informar cuantos son pares y cuantos impares. Si todos son
'pares o todos son impares informar esta situación particular en lugar de la consigna anterior.