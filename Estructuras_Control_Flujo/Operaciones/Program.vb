Imports System


Module Program
    Enum Operaciones As Integer
        suma = 1
        resta
        multiplicacion
        division
    End Enum

    Sub main()
        Dim numero1 As Decimal = 25
        Dim numero2 As Decimal = 20
        Dim numero3 As Decimal = 15
        Dim numero4 As Decimal = 10
        'rutina(numero1, numero2)


        Console.WriteLine("OPERACIONES CON 2 PARAMETROS")
        Console.WriteLine("{0} + {1} = " & Calcular(Operaciones.suma, numero1, numero2), numero1, numero2)
        Console.WriteLine("{0} - {1} = " & Calcular(Operaciones.resta, numero1, numero2), numero1, numero2)
        Console.WriteLine("{0} * {1} = " & Calcular(Operaciones.multiplicacion, numero1, numero2), numero1, numero2)
        Console.WriteLine("{0} / {1} = " & Calcular(Operaciones.division, numero1, numero2), numero1, numero2)

        rutina(numero1, numero2, numero3)
        rutina(numero1, numero2, numero3, numero4)

        Console.WriteLine("-----------suma sin argumentos--------------")
        Console.WriteLine("suma 1: " & Calcular(numero1, numero2))
        Console.WriteLine("suma 2: " & Calcular(numero1, numero2, numero3))
        Console.WriteLine("suma 3: " & Calcular(numero1, numero2, numero3, numero4))
    End Sub


    Sub rutina(numero1, numero2, numero3)
        Console.WriteLine("OPERACIONES CON 3 PARAMETROS")
        Console.WriteLine("{0} + {1} + {2}= " & calcular(Operaciones.suma, numero1, numero2, numero3), numero1, numero2, numero3)
        Console.WriteLine("{0} - {1} - {2}= " & calcular(Operaciones.resta, numero1, numero2, numero3), numero1, numero2, numero3)
        Console.WriteLine("{0} * {1} * {2}= " & calcular(Operaciones.multiplicacion, numero1, numero2, numero3), numero1, numero2, numero3)
        Console.WriteLine("{0} / {1} / {2}= " & calcular(Operaciones.division, numero1, numero2, numero3), numero1, numero2, numero3)
    End Sub
    Sub rutina(numero1, numero2, numero3, numero4)
        Console.WriteLine("OPERACIONES CON 4 PARAMETROS")
        Console.WriteLine("{0} + {1} + {2} + {3}= " & Calcular(Operaciones.suma, numero1, numero2, numero3, numero4), numero1, numero2, numero3, numero4)
        Console.WriteLine("{0} - {1} - {2} - {3}= " & Calcular(Operaciones.resta, numero1, numero2, numero3, numero4), numero1, numero2, numero3, numero4)
        Console.WriteLine("{0} * {1} * {2} * {3}= " & Calcular(Operaciones.multiplicacion, numero1, numero2, numero3, numero4), numero1, numero2, numero3, numero4)
        Console.WriteLine("{0} / {1} / {2} / {3}= " & Calcular(Operaciones.division, numero1, numero2, numero3, numero4), numero1, numero2, numero3, numero4)
    End Sub


    Function calcular(accion As Operaciones, numero1 As Decimal, numero2 As Decimal) As Operaciones

        Select Case accion
            Case Operaciones.suma
                Return numero1 + numero2

            Case Operaciones.resta
                Return numero1 - numero2

            Case Operaciones.multiplicacion
                Return numero1 * numero2

            Case Operaciones.division
                Return numero1 / numero2

            Case Else

        End Select
        Return accion

    End Function


    Function Calcular(accion As Operaciones, numero1 As Decimal, numero2 As Decimal, numero3 As Decimal) As Operaciones
        Return (calcular(accion, calcular(accion, numero1, numero2), numero3))
    End Function


    Function Calcular(accion As Operaciones, numero1 As Decimal, numero2 As Decimal, numero3 As Decimal, numero4 As Decimal) As Operaciones
        Return (calcular(accion, Calcular(accion, numero1, numero2, numero3), numero4))
    End Function


    Function Calcular(numero1, numero2) As Decimal
        Return numero1 + numero2
    End Function

    Function Calcular(numero1, numero2, numero3) As Decimal
        Return Calcular(numero1, numero2) + numero3
    End Function

    Function Calcular(numero1 As Decimal, numero2 As Decimal, numero3 As Decimal, numero4 As Decimal) As Decimal
        Return Calcular(numero1, numero2, numero3) + numero4
    End Function



End Module


'3.16. Crear un proyecto y un módulo llamado “Operaciones” que implemente una función
'sobrecargada capaz de operar dos, tres y cuatro valores de acuerdo a un argumento que debe
'ser una enumeración para las siguientes operaciones: suma, resta, multiplicación y división.
'También debe haber una versión de la función que no reciba la enumeración y como
'operación predeterminada resuelva con una suma. Invocarla desde el módulo main probando
'las diferentes alternativas y mostrando los resultados por consola. Ej.
'calcular(operaciones.suma, 5, 8).Minimizar la repetición de código.