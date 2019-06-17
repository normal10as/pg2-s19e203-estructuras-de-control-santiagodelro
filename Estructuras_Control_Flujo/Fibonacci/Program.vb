Imports System

Module Fibonacci
    Sub Main(args As String())
        Dim fibonacci, valoranterior, valornuevo As Integer
        valoranterior = 0
        valornuevo = 1
        For contador As Integer = 0 To 20 Step 1
            fibonacci = valoranterior + valornuevo
            Console.WriteLine(contador & "  -  " & fibonacci)
            valoranterior = valornuevo
            valornuevo = fibonacci
        Next
    End Sub
End Module
