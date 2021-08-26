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

## Proof of When the password match
![Screenshot (650)](https://user-images.githubusercontent.com/79893903/130953646-8f39766c-2b3b-49f9-ac89-221311420c31.png)

## Proof of when the passwords dont match
![Screenshot (651)](https://user-images.githubusercontent.com/79893903/130953682-8ad9f48d-7ed8-435e-8428-ed4bde0416d1.png)
