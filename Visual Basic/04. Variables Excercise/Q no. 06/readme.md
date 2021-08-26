# Question
Declare a boolean variable ‘signal’. Assign a value to it. Then print its inverse.
# Method One
## Explaination
We declare and classify a Boolean variable using
```
Dim signal As Boolean
        signal = True
```
Then we simply print the variable while also using a logic operator such as NOT
```
Console.WriteLine(Not True)
```
## Proof
![Screenshot (653)](https://user-images.githubusercontent.com/79893903/130957393-d21ded6a-41e3-4407-ba13-134272779bc1.png)


# Second Method
I declare and classify two Boolean variable using
```
  Dim signal, output As Boolean
        signal = True
        output = Not True
```
The ``` output ``` is dependent on ``` signal ``` and simply flips the variable using the ``` NOT ``` operator
<br>
Then the output can simply be printed
```
Console.WriteLine(output)
```
## Proof
![Screenshot (655)](https://user-images.githubusercontent.com/79893903/130957790-dd7e1258-de8c-4e9f-94a5-4164075d0b35.png)
