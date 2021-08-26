## Variables
Variables are used to store values that can be used through out the code.
## How to declare
The command for this in visual basic is ``` Dim ``` this is followed by the name of the variable lets take ``` test ``` as an example. This is then followed by ``` As ``` which is followed by what type of variable this is. Lets take ``` integer ``` as an example
So the full command is <br> ``` Dim test As Integer ``` <br>. After that you can simple specify the value, by <br> ``` test = 25 ``` <br>
## Variable name
The variable name must always be a alphabet. It cannot be a special character or number. The name must also not have spaces in it.
## Multiple variables
What if we want to express multiple variables that are in the same form, i.e integers, we we can seperate them using commas. Like this <br>
```
Dim height, width, area As Integer
  ```
## Example Question
``` Q: Write a program that calculates the area of a rectangle while storing its widht and height as variables ```
## Explaination
First we are declaring the variables with
``` Dim height, width, area As Integer ```
Then we can specify each variable.
```
height = 10
        width = 15
        area = height * width
```
<br>
Note that the value for area is height multiplied by width. This gives us our area and all we have to do is print it.
``` Console.WriteLine(area) ``` <br> And this gives us our answer or 150


Here you go ![Screenshot (637)](https://user-images.githubusercontent.com/79893903/130921168-c2f6134c-8be3-46d5-9618-644fda230008.png)
