Imports System

Module Program
    Sub Main(args As String())
        Dim Tipo As Int16
        Dim Medida, Centimetro, metro, pulgada, pies, yarda As Single
        Console.Write("Ingrese para 1 metro " & vbTab & " 2 pulgada" & vbTab & "3 pies" & vbTab & "4 Yarda: ")
        Tipo = Console.ReadLine
        Console.Write("Ingrese la medida: ")
        Medida = Console.ReadLine
        Select Case (Tipo)
            Case 1
                metro = Medida
                Centimetro = Medida * 100
                pulgada = Centimetro / 2.54
                pies = pulgada / 12
                yarda = pies / 3
            Case 2
                pulgada = Medida
                Centimetro = pulgada * 2.54
                metro = Centimetro / 100
                pies = pulgada / 12
                yarda = pies / 3
            Case 3
                pies = Medida
                pulgada = pies * 12
                Centimetro = pulgada * 2.54
                metro = Centimetro / 100
                yarda = pies / 3
            Case 4
                yarda = Medida
                pies = yarda / 3
                pulgada = pies * 12
                Centimetro = pulgada * 2.54
                metro = Centimetro / 100
            Case Else
                Console.WriteLine("Incorrecto")
        End Select
        Console.WriteLine(metro & " Metros")
        Console.WriteLine(Centimetro & " Centimetros")
        Console.WriteLine(pulgada & " Pulgadas")
        Console.WriteLine(pies & " Pies")
        Console.WriteLine(yarda & " Yardas")
    End Sub
End Module
'Crear un proyecto y un módulo “ConversionMedidas”, para resolver con Case: Elabore un
'algoritmo que permita hacer conversiones de equivalencias entre metros, centímetros,
'yardas, pies y pulgadas: 
'• Presentar un menú y preguntar que unidad de medida desea convertir (pie, pulgadas,
'yarda, pulgada, cms y metros), el valor a convertir y después mostrar las equivalencias.
'• Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
'pulgada = 2.54 cm, 1 metro = 100 cm.
'• Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
'imprimir la equivalencia en centímetros, pies, yardas y pulgadas.