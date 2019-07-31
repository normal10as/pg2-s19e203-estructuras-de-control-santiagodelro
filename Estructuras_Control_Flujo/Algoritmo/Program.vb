Imports System

Module Cuadrados
    Sub Main()
        Validar()
    End Sub
    Function Validar()
        Dim Numero As Single
        Console.Write("Ingrese un numero: ")
        Numero = Console.ReadLine()
        If Numero > 0 And Numero Mod 1 = 0 Then
            Cuadrados(Numero)
        Else
            Validar()
        End If
    End Function
    Sub Cuadrados(Numero)
        Dim Contador, NumeroNuevo, NumeroAnterior As Int16
        NumeroAnterior = 0
        NumeroNuevo = 0
        For Contador = 1 To Numero
            Sumar(Contador, NumeroNuevo, NumeroAnterior)

            Console.Write("{0} ", NumeroNuevo)
        Next
        Console.WriteLine("")
    End Sub
    Sub Sumar(ByRef Contador, ByRef NumeroNuevo, ByRef NumeroAnterior)
        NumeroNuevo = Contador ^ 2 + NumeroAnterior
        NumeroAnterior = NumeroNuevo
    End Sub
End Module


'3.20. Elaborar un algoritmo que lea un n�mero N, que imprima la sumatoria de los
'cuadrados de los enteros entre 1 y N. Utilizar un m�todo para el c�lculo de la sumatoria v�a
'par�metro por referencia. Utilizar un m�todo para validar los valores ingresados sean enteros
'positivos, si no cumple esta condici�n pedir el reingreso del dato. 