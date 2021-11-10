Module Module1

    Sub Main()
        Dim edad As Single
        Console.Write("Ingresar edad:")
        edad = Console.ReadLine
        If edad <= 3 Then
            Console.WriteLine("Es un bebe")
        ElseIf edad <= 12 Then
            Console.WriteLine("Es un niño")
        ElseIf edad <= 13 Then
            Console.WriteLine("Es un joven")
        ElseIf edad <= 18 Then
            Console.WriteLine("Es un adulto")
        ElseIf edad <= 56 Then
            Console.WriteLine("Es un adulto mayor")
        ElseIf edad <= 100 Then
            Console.WriteLine("Es una leyenda")
        ElseIf edad > 100 Then
            Console.WriteLine("Es una leyenda")


        End If
        Console.ReadKey()

    End Sub

End Module