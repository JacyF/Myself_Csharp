// 9. Write a C# Sharp program that takes four numbers as input 
// to calculate and print the average. 
// Test Data:
// Enter the First number: 10 
// Enter the Second number: 15 
// Enter the third number: 20 
// Enter the four number: 30 

// Expected Output:
// The average of 10 , 15 , 20 , 30 is: 18

Console.Write("Please , introduce the first number  : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please , introduce the second number  : ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please , introduce the third number  : ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please , introduce the four number  : ");
int num4 = Convert.ToInt32(Console.ReadLine());

Console.Write($" The avarege is ({num1} + {num2} + {num3} + {num4})/4 =  ");
Console.Write($"{(num1 + num2 + num3 + num4) / 4} ");