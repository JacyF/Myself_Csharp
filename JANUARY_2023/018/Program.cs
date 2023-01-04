// 18. Write a C# program to check two given integers 
// and return true if one is negative and one is positive. Go to the editor
// Sample Output:
// Input first integer:
// -5 
// Input second integer: 
// 25 
// Check if one is negative and one is positive: 
// True 

Console.Write("please the first number : ");
int firstnum = Convert.ToInt32(Console.ReadLine());

Console.Write("please the second number : ");
int secondnum = Convert.ToInt32(Console.ReadLine());

bool CheckTwoNumbers(int num1, int num2)
{
    if ((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0)) return true;
    else return false;
}

bool checkTwoNumbers = CheckTwoNumbers(firstnum,secondnum);
Console.WriteLine(checkTwoNumbers);
