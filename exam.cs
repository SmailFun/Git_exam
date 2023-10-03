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
        string[] finalArray = new string[resultCount];
        Array.Copy(resultArray, finalArray, resultCount);
        
        Console.WriteLine("Отфильтрованный массив строк:");
        foreach (string word in finalArray)
        {
            Console.WriteLine(word);
        }
    }
}