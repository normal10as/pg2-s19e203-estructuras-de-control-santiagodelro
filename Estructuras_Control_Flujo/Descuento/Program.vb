Imports System9

Module Descuento
    Sub Main(args As String())
        Dim cantidad As Integer
        Dim precio, descuento As Integer

        cantidad = 1
        While cantidad <> 0
            Console.Write("Ingrese la Cantidad: ")
            cantidad = Console.ReadLine()
            Console.Write("Ingrese el precio: ")
            precio = Console.ReadLine()
            descuento = cantidad * precio

            If cantidad <= 50 And cantidad >= 10 Then
                Console.WriteLine("SubTotal: $" & descuento)
                Console.WriteLine("Descuento de 5%: $" & descuento * 0.05)
                Console.WriteLine("Total: $" & descuento * 0.95)

            ElseIf cantidad >= 51 And cantidad <= 250 Then
                Console.WriteLine("SubTotal: $" & descuento)
                Console.WriteLine("Descuento de 10%: $" & descuento * 0.1)
                Console.WriteLine("Total: $" & descuento * 0.9)

            ElseIf cantidad >= 251 Then
                Console.WriteLine("SubTotal: $" & descuento)
                Console.WriteLine("Descuento de 20%: $" & descuento * 0.2)
                Console.WriteLine("Total: $" & descuento * 0.8)

            Else
                Console.WriteLine("SubTotal: $" & descuento)
                Console.WriteLine("Total: $" & descuento)
            End If
        End While


    End Sub

End Module
'Crear un proyecto y un módulo “Descuento” para ingresar repetitivamente dos
'valores relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es
'entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es
'del 10% y si es 251 o más el descuento es del 20%. Informar por cada producto subtotal
'(cantidad por precio unitario), porcentaje de descuento aplicado, monto descontado y el total
'(subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a cero, informar el
'total de pesos descontados y el total a cobrar.