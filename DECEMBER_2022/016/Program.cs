// 16. Write a C# program to create a new string from a given string 
// where the first and last characters will change their positions. 
// Test Data:
// w3resource
// Python
// Sample Output:
// e3resourcw
// nythoP 
// x 

string[] array = { " P", "y", "t", "h", "o", "n " };
string[] array1 = {"w", "3" , "r", "e", "s", "o", "u", "r", "c", "e"};

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}

void FirstLast (string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) arr[i] = "n";
        if (i == arr.Length - 1) arr[arr.Length - 1] = "P";
    }
}

void FirstLast1 (string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) arr[i] = "e";
        if (i == arr.Length - 1) arr[arr.Length - 1] = "w";
    }
}

PrintArray(array);
Console.WriteLine(" ");

FirstLast(array);
PrintArray(array);
Console.WriteLine(" ");

PrintArray(array1);
Console.WriteLine(" ");
FirstLast1(array1);
PrintArray(array1);








