Imports System

Module Venta2
    Sub Main(args As String())
        Dim cant, precio, descuento, subtotal, total As Integer
        Console.Write("Ingrese la cantidad: ")
        cant = Console.ReadLine
        Console.Write("Ingrese el precio Unitario: ")
        precio = Console.ReadLine
        subtotal = precio * cant

        Select Case (cant)
            Case 10 To 50
                descuento = subtotal * 0.05
                total = subtotal - descuento
                Console.WriteLine("Subtotal: $" & subtotal)
                Console.WriteLine("Descuento 5%: $" & descuento)
                Console.WriteLine("Total: $" & total)
            Case 51 To 250
                descuento = subtotal * 0.1
                total = subtotal - descuento
                Console.WriteLine("Subtotal: $" & subtotal)
                Console.WriteLine("Descuento 10%: $" & descuento)
                Console.WriteLine("Total: $" & total)
            Case > 251
                descuento = subtotal * 0.2
                total = subtotal - descuento
                Console.WriteLine("Subtotal: $" & subtotal)
                Console.WriteLine("Descuento 20%: $" & descuento)
                Console.WriteLine("Total: $" & total)
        End Select

    End Sub
End Module

'Crear un proyecto y un módulo “Venta2.0”, para resolver el problema “Venta” (3.4) con
'Case .