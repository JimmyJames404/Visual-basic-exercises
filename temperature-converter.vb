Sub Main()
        Dim n As Single
        Dim F As Single
        Dim C As Single
        Dim K As Single

        Console.WriteLine("Inresar dato de temperatura en celsius a convertir:")
        n = Console.ReadLine()
        F = n * 1.8 + 32
        C = (n - 32) * 1.8
        K = (n + 273.15)
        Console.WriteLine("Su valor ingresado en Farenheit es :" & " " & F & " " & "F")
        Console.WriteLine("Su valor ingresado en Celsius es :" & " " & n & " " & "C")
        Console.WriteLine("Su valor ingresado en Kelvin es :" & " " & K & " " & "K")

        Console.WriteLine("Inresar dato de temperatura en Farenheit a convertir:")
        n = Console.ReadLine()

        F = n
        C = (n - 32) * 5 / 9
        K = ((n - 32) * 5 / 9) + 273.5

        Console.WriteLine("Su valor ingresado en Farenheit es :" & " " & F & " " & "F")
        Console.WriteLine("Su valor ingresado en Celsius es :" & " " & C & " " & "C")
        Console.WriteLine("Su valor ingresado en Kelvin es :" & " " & K & " " & "K")


        Console.WriteLine("Inresar dato de temperatura en Kelvin a convertir:")
        n = Console.ReadLine()

        F = (((n - 273.15) * 9) / 5) + 32
        C = n - 273.15
        K = n
        Console.WriteLine("Su valor ingresado en Farenheit es :" & " " & F & " " & "F")
        Console.WriteLine("Su valor ingresado en Celsius es :" & " " & C & " " & "C")
        Console.WriteLine("Su valor ingresado en Kelvin es :" & " " & K & " " & "K")


        Console.ReadKey()
