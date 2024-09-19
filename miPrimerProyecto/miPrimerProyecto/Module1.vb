Module Module1

    Sub Main()
        Dim num1, num2, num3, mayor As Integer

        Console.Write("num1: ")
        num1 = Console.ReadLine

        Console.Write("num2: ")
        num2 = Console.ReadLine

        Console.Write("num3: ")
        num3 = Console.ReadLine

        If num1 > num2 Then
            mayor = num1
        Else
            mayor = num2
        End If

        If num3 > mayor Then
            mayor = num3
        End If

        Console.WriteLine("El mayor de los tres numero es: {0}", mayor)

        Console.ReadKey()


    End Sub

End Module
