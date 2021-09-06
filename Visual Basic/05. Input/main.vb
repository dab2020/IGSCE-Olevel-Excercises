odule Module1

    Sub Main()
        Dim lenght, width, area As Integer
        Console.WriteLine("Please enter lenght")
        lenght = Console.ReadLine()
        Console.WriteLine("Please enter Width")
        width = Console.ReadLine()
        area = lenght * width
        Console.WriteLine("The area is " & area & " cm^2")
        Console.ReadKey()
    End Sub

End Module
