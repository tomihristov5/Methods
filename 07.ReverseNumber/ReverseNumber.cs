// Problem 7. Reverse number
// Write a method that reverses the digits of given decimal number

using System;
using System.Numerics;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        Reverse(number);
    }

    static void Reverse(BigInteger number)
    {
        char[] numToStr = number.ToString().ToCharArray();
        Array.Reverse(numToStr);
        string reversedNumInStr = new string(numToStr);
        Console.WriteLine("The new number is " + reversedNumInStr);
    }
}

