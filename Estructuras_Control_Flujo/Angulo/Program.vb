Imports System

Module Angulo
    Sub Main(args As String())
        Dim angulo As Int16
        Console.Write("Ingrese el Angulo: ")
        angulo = Console.ReadLine

        Select Case (angulo)
            Case 1 To 90 : Console.WriteLine("Angulo Agudo")
            Case = 90 : Console.WriteLine("Angulo Recto")
            Case 90 To 180 : Console.WriteLine("Angulo Obusto")
            Case = 180 : Console.WriteLine("Angulo Llano")
            Case 180 To 360 : Console.WriteLine("Angulo Cóncavo")
            Case Else : Console.WriteLine("Error")

        End Select
    End Sub
End Module
