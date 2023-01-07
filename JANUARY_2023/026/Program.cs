// 26. Write a C# program to compute the sum of the first 500 prime numbers.
// Sample Output:
// Sum of the first 500 prime numbers: 
// 824693 

Console.Write(" The sum of the first 500 prime numbers : ");

int sum = 0;
int counter = 0;

for (int i = 2; i <= 5000; i++)
{
    int count = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0) count++;
    }
    if (count == 2)
    {
        sum = sum + i;
        counter += 1;
    }
    if (counter == 500) break;
}
Console.WriteLine(sum);
Console.WriteLine($" Quantity of numebers summed : {counter}");
