Module Module1

    Sub Main()
        Console.Write("num1:")
        Dim num1 As Double
        num1 = Console.ReadLine()

        Console.Write("num2:")
        Dim num2 As Double
        num2 = Console.ReadLine()

        Dim suma As Double
        suma = num1 + num2

        Console.WriteLine("La suma es: {0}", suma)

        Console.ReadKey()

    End Sub

End Module
