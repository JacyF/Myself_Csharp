// 24. Write a C# program to find the longest word in a string. Go to the editor
// Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
// Sample Output:
// following

string line = " Write a C# Sharp Program to display the following pattern using the alphabet. ";
string [] words = line.Split(new [] {" "}, StringSplitOptions.None);
// string[] words = { "Write", "a", "C#", "Sharp", "Program:",
//                     " to", "display", "the" ,"following" ,"pattern",
//                     "using", "the", "alphabet" };
string word = " ";
int ctc = 0;

foreach (String s in words)
{
    if (s.Length > ctc)
    {
        word = s;
        ctc = s.Length;
    }
}

Console.Write(word);

