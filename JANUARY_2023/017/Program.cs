// 17. Write a C# program to create a new string from a given string (length 1 or more ) 
// with the first character added at the front and back. Go to the editor
// Sample Output:
// Input a string : The quick brown fox jumps over the lazy dog. 
// TThe quick brown fox jumps over the lazy dog.T

string[] array = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

void Printarray(string[] arr)
{
    Console.Write(" ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write(" ");
}
Printarray(array);
Console.WriteLine();

void FirstaddedBackFront(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) arr[i] = "T" + arr[i];
        if (i == arr.Length - 1) arr[arr.Length - 1] = arr[arr.Length - 1] + ".T";
    }
}

Console.WriteLine();
FirstaddedBackFront(array);
Printarray(array);

