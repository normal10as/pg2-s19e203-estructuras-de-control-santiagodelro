Imports System

Module Venta
    Sub Main(args As String())
        Dim cant, precio, descuento, subtotal, total As Integer
        Console.Write("Ingrese la cantidad: ")
        cant = Console.ReadLine
        Console.Write("Ingrese el precio Unitario: ")
        precio = Console.ReadLine
        subtotal = precio * cant

        If cant > 10 And cant < 50 Then
            descuento = subtotal * 0.05
            total = subtotal - descuento
            Console.WriteLine("Subtotal: $" & subtotal)
            Console.WriteLine("Descuento 5%: $" & descuento)
            Console.WriteLine("Total: $" & total)
        End If
        If cant > 51 And cant < 250 Then
            descuento = subtotal * 0.1
            total = subtotal - descuento
            Console.WriteLine("Subtotal: $" & subtotal)
            Console.WriteLine("Descuento 10%: $" & descuento)
            Console.WriteLine("Total: $" & total)
        End If
        If cant > 251 Then
            descuento = subtotal * 0.2
            total = subtotal - descuento
            Console.WriteLine("Subtotal: $" & subtotal)
            Console.WriteLine("Descuento 20%: $" & descuento)
            Console.WriteLine("Total: $" & total)
        End If

    End Sub
End Module
'Crear un proyecto y un módulo “Venta” para resolver con If: ingresar dos valores
'relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es entre a 10 y
'50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es del 10% y si
'es 251 o más el descuento es del 20%. Informar subtotal (cantidad por precio unitario),
'porcentaje de descuento aplicado, monto descontado y el total (subtotal – monto
'descontado).