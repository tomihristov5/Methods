// Problem 3. English digit
// Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDgit
{
    static void Main()
    {
        Console.Write("Enter digit: ");
        int number = int.Parse(Console.ReadLine());
        int last = (number / 1) % 10;
        string word = GetWord(last);
        Console.WriteLine("Digit as a word: {0}", word);

    }

    private static string GetWord(int last)
    {
        string result = "";
        switch (last)
        {
            case 1: result = "one"; break;
            case 2: result = "two"; break;
            case 3: result = "three"; break;
            case 4: result = "four"; break;
            case 5: result = "five"; break;
            case 6: result = "six"; break;
            case 7: result = "seven"; break;
            case 8: result = "eight"; break;
            case 9: result = "nine"; break;
           
        }
        return result;
    }
}
   