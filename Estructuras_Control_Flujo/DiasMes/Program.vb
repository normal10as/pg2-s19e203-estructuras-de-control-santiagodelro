Imports System

Module DiasMes
    Enum Meses
        enero = 1
        febrero
        marzo
        abril
        mayo
        junio
        julio
        agosto
        septiembre
        octubre
        noviembre
        diciembre
    End Enum

    Sub Main(args As String())
        Dim Mes As Integer
        Dim Anio As Single

        Console.Write("Ingrese el mes: ")
        Mes = Console.ReadLine()

        Select Case (Mes)
            Case 1 : Console.WriteLine("El mes {0} tiene 31 dias ", Meses.enero)
            Case 2
                Console.Write("Ingrese el Anio: ")
                Anio = Console.ReadLine()
                If Anio Mod 4 = 0 And (Anio Mod 100 <> 0 Or Anio Mod 400 = 0) Then
                    Console.WriteLine("El mes {0} tiene 29 dias ", Meses.febrero)
                Else
                    Console.WriteLine("El mes {0} tiene 28 dias ", Meses.febrero)

                End If

            Case 3 : Console.WriteLine("El mes {0} tiene 31 dias ", Meses.marzo)
            Case 4 : Console.WriteLine("El mes {0} tiene 30 dias ", Meses.abril)
            Case 5 : Console.WriteLine("El mes {0} tiene 31 dias ", Meses.mayo)
            Case 6 : Console.WriteLine("El mes {0} tiene 30 dias ", Meses.junio)
            Case 7 : Console.WriteLine("El mes {0} tiene 31 dias ", Meses.julio)
            Case 8 : Console.WriteLine("El mes {0} tiene 31 dias ", Meses.agosto)
            Case 9 : Console.WriteLine("El mes {0} tiene 30 dias ", Meses.septiembre)
            Case 10 : Console.WriteLine("El mes {0} tiene 31 dias ", Meses.octubre)
            Case 11 : Console.WriteLine("El mes {0} tiene 30 dias ", Meses.noviembre)
            Case 12 : Console.WriteLine("El mes {0} tiene 31 dias ", Meses.diciembre)


        End Select
    End Sub

End Module


'Crear un proyecto y un módulo “DiasMes” para resolver con Case: Elabore un programa
'que indique cuantos días tiene un mes respetando los siguientes requerimientos:
'• En el flujo normal se ingresa el número de mes a evaluar y mediante una enumeración
'se informa la cantidad de días que tiene el mes.
'• En el caso de ser febrero, además ingresar el año y tener en cuenta que tiene 28 días y si
'es un año bisiesto tiene 29 días. Un año bisiesto es aquél que es múltiplo de 4 y no de 100
'o cuando es múltiplo de 400. Por ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.