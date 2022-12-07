// 14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
// Test Data:
// Enter the amount of celsius: 30
// Expected Output:
// Kelvin = 303
// Fahrenheit = 86

Console.Write(" Please , enter the temperature in celsius degrees : ");
int degrees = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Kelvin = {degrees+273} ");
Console.WriteLine($" Fahrenheit = {degrees*9/5 +32} ");