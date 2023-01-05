// 21. Write a C# program to check the sum of the two given integers 
// and return true if one of the integer is 20 or if their sum is 20.

Console.WriteLine("Please introduce two numbers ");
Console.Write("Fisrt number : ");
int firstnum = Convert.ToInt32(Console.ReadLine());

Console.Write("Fisrt number : ");
int secondnum = Convert.ToInt32(Console.ReadLine());



bool TrueSum20 (int num1, int num2)
{
    int sum = num1 + num2;
    if (sum == 20 || num1 == 20 || num2 == 20 ) return true;
    else return false;
}

Console.Write( TrueSum20(firstnum, secondnum)  ); 
