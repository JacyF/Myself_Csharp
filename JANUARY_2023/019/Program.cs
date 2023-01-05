// 19. Write a C# program to compute the sum of two given integers, 
// if two values are equal then return the triple of their sum.

Console.WriteLine("Please introduce two numbers ");
Console.Write("Fisrt number : ");
int firstnum = Convert.ToInt32(Console.ReadLine());

Console.Write("Fisrt number : ");
int secondnum = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (firstnum == secondnum) sum = 3*(firstnum+secondnum);
else sum = (firstnum+secondnum);

Console.Write($" Sum = {sum} ");

