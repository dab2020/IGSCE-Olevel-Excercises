# Question
Declare an integer variable ‘mynum’. Assign a value to it. Then print the double of the assigned value.
# Explaination
## First Method
First of all I am declaring and specifying the variable of mynum
```
Dim mynum As Integer
        mynum = 256
```
It then prints a line that says that this is the first method ```  Console.WriteLine("First Method of doing it") ```. After that the next line multiplies the variable mynum with 2 and prints it ``` Console.WriteLine(mynum * 2) ```
![Screenshot (641)](https://user-images.githubusercontent.com/79893903/130936191-e53076fa-5eee-43e3-a029-88685251bc95.png)
<br>
## Second Method
like above, first I am declaring and specifying the variable of mynum and add
```
 Dim mynum, add As Integer
        mynum = 256
        add = 2
```
It then prints a line that says that this is the second method ```  Console.WriteLine("Second Method of doing it") ```.
It then multiplies the two variables and prints the answer with the following line ``` Console.WriteLine(mynum * add) ```
![Screenshot (643)](https://user-images.githubusercontent.com/79893903/130937204-62257a27-2eb7-40fa-88c6-3bdd3ad2f856.png)
<br>
## Third Method
This time, we introduce yet another variable that is result, it will the product of mynum(256) and add(2).
```
Dim mynum, add, result As Integer
        mynum = 256
        add = 2
        result = mynum * add
```
We can then simply print this with ``` Console.WriteLine(result) ```
![Screenshot (644)](https://user-images.githubusercontent.com/79893903/130937782-3a4a03fd-ce24-411a-b617-9126382a91c0.png)
