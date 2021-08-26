# Question
The discriminant in a quadratic equation is calculated by the expression
b^2−4ac. Write a program in VB which stores the values of a, b and c of your choice. Use ‘d’
as the variable-name to save the value of the discriminant. Then see if ‘d’ is a negative
number.

## Explaination
Declared and specified the required variables.
```
Dim a, b, c, d As Integer
        a = 2
        b = -3
        c = -3
        d = (b ^ 2) + (-4 * a * c)
```
the ``` d ``` variable is the one that calculates the discriminant
<br>
It will them print them out using ``` Console.WriteLine(d) ```
<br>
Next I used an if command that will respond if the discriminant is negative
```
If d < 0 Then
            Console.WriteLine("The discriminant is negative")
        End If
        Console.ReadKey()
```

## Proof
![Screenshot (659)](https://user-images.githubusercontent.com/79893903/130981059-e93b8f73-7ad1-4b8e-9189-6d4b014a12d4.png)
![maxresdefault (1)](https://user-images.githubusercontent.com/79893903/130981105-f18307d0-a2c8-4018-97cc-a0ace69ddef3.jpg)
