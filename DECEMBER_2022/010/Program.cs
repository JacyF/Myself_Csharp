// 10. Write a C# Sharp program to that takes three numbers(x,y,z) 
// as input and print the output of (x+y).z and x.y + y.z. 
// Test Data:
// Enter first number - 5
// Enter second number - 6
// Enter third number - 7

// Expected Output:
// Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72

Console.Write("Please , introduce the first number  : ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Please , introduce the second number  : ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Please , introduce the third number  : ");
int z = Convert.ToInt32(Console.ReadLine());

Console.Write($"Result of specified numbers {x}, {y} and {z} ");
Console.Write($"(X+Y).Z is {(x + y)*z} and X.Y + Y.Z is {x*y + y*z} ");
