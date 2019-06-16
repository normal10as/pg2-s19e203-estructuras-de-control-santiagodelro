Imports System

Module Venta
    Sub Main(args As String())
        Dim cant, precio, descuento, subtotal, montodescuento As Integer
        Console.Write("Ingrese la cantidad: ")
        cant = Console.ReadLine
        Console.Write("Ingrese el precio Unitario: ")
        precio = Console.ReadLine
        subtotal = precio * cant

        descuento = ObtenerDescuento(cant)

        montodescuento = subtotal * descuento / 100
        Console.WriteLine("Subtotal: $" & subtotal)
        Console.WriteLine("Descuento {0}%: $" & montodescuento, descuento)
        Console.WriteLine("Total: $" & subtotal - montodescuento)

    End Sub
    Private Function ObtenerDescuento(cant As Integer) As Integer
        If cant < 10 Then
            Return 0
        ElseIf cant < 50 Then
            Return 5
        ElseIf cant < 250 Then
            Return 10
        Else
            Return 20
        End If

    End Function
End Module
'Crear un proyecto y un módulo “Venta” para resolver con If: ingresar dos valores
'relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es entre a 10 y
'50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es del 10% y si
'es 251 o más el descuento es del 20%. Informar subtotal (cantidad por precio unitario),
'porcentaje de descuento aplicado, monto descontado y el total (subtotal – monto
'descontado).