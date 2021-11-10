Module Module1

    Sub Main()
        Dim a As Single
        Dim cm As Single

        Console.WriteLine("Introduce the distance en mters to convert to centimeters")
        a = Console.ReadLine()
        cm = a * 1 / 0.01
        Console.WriteLine("Su cantidad es:" & " " & cm & " " & "cm")
        Console.ReadKey()



    End Sub

End Module