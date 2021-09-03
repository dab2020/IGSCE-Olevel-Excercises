# Input
Up till now we have assigned variables and used thoose to calculate things, but thoose aren't user friendly. The user would have to understand the code and would have to manually edit the vb file, and that is something that is not possible with a compiled binary. So for this we can use user input with the ``` console.readline() ```
command.

## Explianation
For an example I will be making a program that calculate the area of a rectangle
<br>
First we are going to declare the lenght area and width variables as integers
```
 Dim lenght, width, area As Integer
 ```
 Then we are going to make a line appear that asks the user to input the lenght
 ```
 Console.WriteLine("Please enter lenght")
 ```
 Then we will specify the value with a  input using ``` Console.readline ```
 ```
 lenght = Console.ReadLine()
 ```
 Then we repeat it for Width
 ```
 console.WriteLine("Please enter Width")
        width = Console.ReadLine()
```

Then I specify the area variable to be a product of both of them and print it
```
area = lenght * width
        Console.WriteLine("The area is " & area & " cm^2")
```

# Difference between ``` Console.readline ``` or ``` Console.readkey ```
``` Console.readline ``` will take the value of what ever the user has entered untill he presses enter. the ``` Console.readkey ``` will only be able to read one key, this is usefull when lets say you create a prompt along the lines of ``` Enter M for male and F for Female ```
