Module Module1

    Sub Main()
        Dim a As Single
        Dim F As Single

        Console.WriteLine("Ingresar dato en Celsius para convertir en farenheit")
        a = Console.ReadLine()
        F = a * 1.8 + 32
        Console.WriteLine("Su valor ingresado en farenheit es :" & " " & F & " " & "F")
        Console.ReadKey()

    End Sub

End Module
