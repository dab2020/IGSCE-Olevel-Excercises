# Question 
Two adjacent sides of a rectangle are 13 cm and 27 cm. Write a program in VB which stores
the length and width into appropriately named variables. Then calculate and print with
formatting the area of this rectangle. Use the variable-name ‘Area’ to store the value of
area

## Explaination
I started by initaiting some variable and assigning some values
```
Dim lenght, width, area As Integer
        Dim area1 As String
```
The variable area1 is a string as I couldn't get a integer and a string to merge properly (which was needed to show the value with proper formatting)
<br>
I assigned values to all of them
```
 lenght = 13
        width = 15
        area = lenght * width
        area1 = area
```
Then it was simply a matter of printing the result along with formatting
```
Console.WriteLine(area1 + " cm^2")
```
![Screenshot (657)](https://user-images.githubusercontent.com/79893903/130961057-db39880b-f989-4b83-a50b-1bbb98bbcbea.png)
