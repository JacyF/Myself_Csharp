// 16. Write a C# program to create a new string from a given string 
// where the first and last characters will change their positions. 
// Test Data:
// w3resource
// Python
// Sample Output:
// e3resourcw
// nythoP 
// x 

string[] array = { " Python " };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}

void FirstLast (string [] arr)
{
    string last = "n";
    string first = "P";
    for (int i = 0 ; i < arr.Length ; i++)
    {
        if (i == 0) arr[i] = last ;
        // if (i == arr.Length ) arr[i] = first;
        Console.Write($"{arr[i]}, {i}");
    }
}


PrintArray(array);
Console.WriteLine("-------------");
FirstLast(array);
PrintArray(array);


