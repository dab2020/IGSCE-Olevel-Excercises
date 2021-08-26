# Question:
Declare a decimal variable ‘num’. Assign a value to it. Then see if the assigned value is a negative number.
<h1>NOTE: Everything below the OLD heading  is for the "old" code, I found a better way to do this</h1>
<h2>NEW</h2>
<a href="https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/statements/if-then-else-statement">I found this resource and figured out the if, then and Else statements</a>

## Explaination
I declared and assigned a decimal value to num by

```
Dim num As Decimal
        num = -1
```

Then I passed an argument that if if the number is greater than one (means positive) then it should print that the number is positive
```
 If num > 0 Then
            Console.WriteLine("the number is positive")
            Console.ReadKey()
```

I also added a Else statement that if the number isnt greater than one then it should print that the number is negative
```
 Else
            Console.WriteLine("The number is negative")
            Console.ReadKey()
```
I then ended the argument with the ``` End If ```

## Proof for Positive number
![Screenshot (647)](https://user-images.githubusercontent.com/79893903/130951512-ad7746a3-2ff8-4deb-bb75-37e8847afbf2.png)

## Proof for Negative number
![Screenshot (648)](https://user-images.githubusercontent.com/79893903/130951571-d642b3d4-658f-42a8-ad01-849ba68a6155.png)


<h1>OLD</h1>


## Explaination
I first assigned a value to num
```
Dim num As Decimal
        num = -1
```
I then added a line that print a message that tells the user how to interpet the output.
``` Console.WriteLine("If true this number is positive and if false the number is negative") ```
Finally I added ```  Console.WriteLine(num > 0) ``` this compares the number in comparison to zero and this means that true is a positive number and false a negative number.

## Proof for Positive number
![Screenshot (645)](https://user-images.githubusercontent.com/79893903/130941198-55ec3237-4b7a-471b-86af-569c802baf33.png)

## Proof for negative number
![Screenshot (646)](https://user-images.githubusercontent.com/79893903/130941269-dd06e313-5613-4d14-93f2-a024bcd5c162.png)


# NOTE
I dont know the VB.NET equavilent of the if command in python, if that was used, we might be able to bypass user judgement and instead have this VB.NET equivalent of python code
```
if num > 0:
  print("The Number is positive")
if num < 0:
  print("The Number is negative")
  ```
