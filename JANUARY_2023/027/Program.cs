// 27. Write a C# program and compute the sum of the digits of an integer. 
// Sample Output:
// Input a number(integer): 12
// Sum of the digits of the said integer: 3 

Console.Write(" Write a number : ");
// int number = Convert.Toint32(Console.ReadLine());
int number = Convert.ToInt32(Console.ReadLine());

int sumdigits = 0 ;
 int control = number;

while( number > 0)
{
    control = number;
    number = number % 10 ;
    sumdigits = sumdigits + number;
    number = control/10;
}

Console.WriteLine($" Sum of the digits of the said integer: {sumdigits}");
