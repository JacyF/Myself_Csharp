// 6. Write a C# Sharp program to print the output of multiplication of three numbers 
// which will be entered by the user. 
// Test Data:
// Input the first number to multiply: 2
// Input the second number to multiply: 3
// Input the third number to multiply: 6
// Expected Output:
// 2 x 3 x 6 = 36

Console.Write("Please , introduce the first number to multiply : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please , introduce the second number to multiply : ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please , introduce the third number to multiply : ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.Write($" {num1} x {num2} x {num3} = {num1 * num2 * num3} ");