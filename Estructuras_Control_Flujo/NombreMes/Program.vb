Imports System

Module NombreMes
    Sub Main(args As String())
        Dim Mes As Int16
        Console.Write("Ingrese el Mes: ")
        Mes = Console.ReadLine
        Select Case (Mes)
            Case 1 : Console.WriteLine("Enero")
            Case 2 : Console.WriteLine("Febrero")
            Case 3 : Console.WriteLine("Marzo")
            Case 4 : Console.WriteLine("Abril")
            Case 5 : Console.WriteLine("Mayo")
            Case 6 : Console.WriteLine("Junio")
            Case 7 : Console.WriteLine("Julio")
            Case 8 : Console.WriteLine("Agosto")
            Case 9 : Console.WriteLine("Septiembre")
            Case 10 : Console.WriteLine("Octubre")
            Case 11 : Console.WriteLine("Noviembre")
            Case 12 : Console.WriteLine("Diciembre")
            Case Else : Console.WriteLine("Numero Incorrecto")
        End Select

    End Sub
End Module
'Crear un proyecto y un módulo “NombreMes” para resolver con Case. Crear una
'enumeración para los meses del año. Ingresar un valor numérico y mostrar a que mes
'corresponde.Si el valor es inválido mostrar el mensaje correspondiente.