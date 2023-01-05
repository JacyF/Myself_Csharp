// 20. Write a C# program to get the absolute value of the difference between two given numbers. 
// Return double the absolute value of the difference if the first number is greater than second number

Console.WriteLine("Please introduce two numbers ");
Console.Write("Fisrt number : ");
int firstnum = Convert.ToInt32(Console.ReadLine());

Console.Write("Fisrt number : ");
int secondnum = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (firstnum > secondnum) sum = 2 * Math.Abs(firstnum-secondnum);
else sum = Math.Abs(firstnum-secondnum);

Console.Write($" Sum = {sum} ");