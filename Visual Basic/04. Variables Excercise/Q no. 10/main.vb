Module Module1

    Sub Main()
        Dim a, b, c, d As Integer
        a = 2
        b = -3
        c = -3
        d = (b ^ 2) + (-4 * a * c)
        Console.WriteLine(d)
        If d < 0 Then
            Console.WriteLine("The discriminant is negative")
        End If
        Console.ReadKey()

    End Sub

End Module
