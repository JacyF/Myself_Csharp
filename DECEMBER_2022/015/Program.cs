// 15. Write a C# program remove specified a character from a non-empty string 
// using index of a character. 
// Test Data:
// w3resource
// Sample Output:
// wresource
// w3resourc
// 3resource

string word = "w3resource" ;

string remove_char(string letter, int n)
{
    return letter.Remove(n, 1);
} 

Console.WriteLine(remove_char(word, 1));
Console.WriteLine(remove_char(word, 9));
Console.WriteLine(remove_char(word, 0));