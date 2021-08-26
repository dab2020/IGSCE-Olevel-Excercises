# Question
Declare a string variable ‘password’. Assign a value to it. Then see if the assigned value is equal to ‘Pakistan786’.
## Explaination

<a href="https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/statements/if-then-else-statement">Again using this resource</a>

First We are declaring the password and a quality_control variable. The password is the variable which will store the text we will be comparing. The quality_control variable is the one it will compared against
```
Dim password, quality_control As String
        password = "Pakistan"
        quality_control = "Pakistan786"
```

Then I passed a if argument that if the password and QC match then, it should tell so
```
If password = quality_control Then
            Console.WriteLine("the passwords match")
            Console.ReadKey()
 ```
 
 Then I also told it that if the passwords didnt match then it should also print as such.
 ```
  Else
            Console.WriteLine("The passwords donot match")
            Console.ReadKey()
        End If
```
