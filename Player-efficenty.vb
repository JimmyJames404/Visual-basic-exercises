Module Module1

    Sub Main()
        Dim partidos As Single
        Dim goles As Single
        Dim p As Single
        Dim pro As Single

        Console.WriteLine("Ingresar numero de partidos")
        partidos = Console.ReadLine()
        Console.WriteLine(" ")

        Console.WriteLine("Ingresar numero de goles")
        goles = Console.ReadLine()
        Console.WriteLine(" ")

        p = 16 - partidos
        pro = goles / partidos

        If partidos > 16 Then
            Console.WriteLine("Se a excedido el limite de 16 partidos")
        ElseIf partidos = 16 Then
            Console.WriteLine("El jugador esta en su limite de partidos")

        ElseIf partidos < 16 Then
            Console.WriteLine("El jugador aun tiene" & " " & p & " " & "partidos por jugar")

            If pro >= 5 Then
                Console.WriteLine("El jugador es un excelente jugador con" & " " & pro & " goles de promedio")
            ElseIf pro >= 3 Then
                Console.WriteLine("El jugador es un jugador promedio  con" & " " & pro & " goles de promedio")
            ElseIf pro < 2 Then
                Console.WriteLine("El jugador es un jugador malo con" & " " & pro & " goles de promedio")
            ElseIf pro > 5 Then
                Console.WriteLine("El jugador es un buen jugador con" & " " & pro & " goles de promedio")



            End If

        Console.ReadKey()
    End Sub

End Module
