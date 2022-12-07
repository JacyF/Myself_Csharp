// 12. Write a C# program to that takes a number as input 
// and display it four times in a row (separated by blank spaces),
//  and then four times in the next row, with no separation. 
//  You should do it two times: Use Console. 
//  Write and then use {0}. 
// Test Data:
// Enter a digit: 25 
// Expected Output:
// 25 25 25 25 
// 25252525 
// 25 25 25 25 
// 25252525

Console.Write(" Please , write your a number : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" {number} {number} {number} {number} ");
Console.WriteLine($" {number}{number}{number}{number} ");
Console.WriteLine($" {number} {number} {number} {number} ");
Console.WriteLine($" {number}{number}{number}{number} ");



