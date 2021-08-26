Module Module1

    Sub Main()
        Dim password, quality_control As String
        password = "Pakistan"
        quality_control = "Pakistan786"
        If password = quality_control Then
            Console.WriteLine("the passwords match")
            Console.ReadKey()
        Else
            Console.WriteLine("The passwords donot match")
            Console.ReadKey()
        End If
    End Sub

End Module
