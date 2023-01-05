// 22. Write a C# program to check if an given integer is within 20 of 100 or 200. 
// Sample Output:
// Input an integer: 
// 25 
// False 

Console.Write("Please introduce a number : ");
int number = Convert.ToInt32(Console.ReadLine());

bool Within20Of100Or200(int num)
{
    if (Math.Abs(num - 100) <= 20 || Math.Abs(num - 200) <= 20) return true;
    return false;
}

bool within20Of100Or200 = Within20Of100Or200(number);
Console.Write(within20Of100Or200);



