using System;

class Program
{
    static void Main()
    {
        string[] originalArray = { "apple", "banana", "cherry", "date", "elderberry", "fig" };
        string[] resultArray = new string[originalArray.Length];
        int resultCount = 0;
        foreach (string word in originalArray)
        {
            if (word.Length <= 3)
            {
                resultArray[resultCount] = word;
                resultCount++;
            }
        }
    }
}