// 11. Write a C# Sharp program that takes an age (for example 20) 
// as input and prints something as "You look older than 20". 
// Test Data:
// Enter your age - 25
// Expected Output:
// You look older than 25

Console.Write(" Please , write your age : ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write($"You look older than {age} : ");
