# Question 
Anwar works 40 hours a week. He is paid Rs.500 per hour for his work. Write a program in
VB which stores the name, hours and pay rate into meaningful variable names. Then
calculate and print with formatting Anwar’s weekly wages. Use the variable-name ‘Wages’
to store the value of wages.


# Explaination
Firstly I started by declaring and classifying some variables
```
 Dim pay, wage, time As Integer
        Dim Name, wage1 As String
        pay = 500
        time = 40
        wage = pay * time
        wage1 = wage
        Name = "Anwar"
```
Now, you may notice that there are 2 wage related variables wage and wage1. wage1 is declared as a string while the other is a integer. The reason is that when we try to add formatting, the different data types dont play very nice with one another.
<br>
And now all we have to do is print all of that
```
Console.WriteLine("Every week " + Name + " is paid:")
        Console.WriteLine("Rs." + wage1)
```
![Screenshot (658)](https://user-images.githubusercontent.com/79893903/130972363-1674c455-cc15-4f25-8163-7887aceb5dff.png)
