// 13. Write a C# program that takes a number as input and 
// then displays a rectangle of 3 columns wide 
// and 5 rows tall using that digit.
// Test Data:
// Enter a number: 5 
// Expected Output:
// 555 
// 5 5
// 5 5 
// 5 5 
// 555

Console.Write(" Please , write your a number : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" {number}{number}{number} ");
Console.WriteLine($" {number} {number} ");
Console.WriteLine($" {number} {number} ");
Console.WriteLine($" {number} {number} ");
Console.WriteLine($" {number}{number}{number} ");