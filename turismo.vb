Module Module1

    Sub Main()
        Dim meses As Single
        Dim turistas As Single
        Dim s As Single
        Dim pro As Single

        Console.WriteLine("Ingresar numero de turistas por mes")
        turistas = Console.ReadLine()
        Console.WriteLine(" ")

        s = turistas * 12
        pro = turistas * 12 / 12

        Console.WriteLine("El total anual de turismo es de " & " " & s & " anuales")

        If pro < 25000 Then
            Console.WriteLine("bajo turismo")
        ElseIf pro >= 25000 Then
            Console.WriteLine("medio turismo")
        ElseIf pro >= 50000 Then
            Console.WriteLine("alto turismo")
        ElseIf pro >= 50000 Then
            Console.WriteLine("Exelente turismo")

        End If

        Console.ReadKey()
    End Sub

End Module
