// 3. Write a C# Sharp program to print the result of dividing two numbers.

Console.WriteLine(" Please, introduce 2 numbers ");
double number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Please, introduce one more number ");
double number2 = Convert.ToInt32(Console.ReadLine());

double div = number1 / number2 ;
Console.WriteLine($" {number1} / {number2} = {div} ");