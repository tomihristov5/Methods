// Problem 1. Say Hello
// Write a method that asks the user for his name and prints “Goodbye, <name>”
// Write a program to test this method.

using System;

class SayHello
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine(ReturnGreeting(name));
    }

    public static string ReturnGreeting(string name)
    {
        return String.Format("Goodbye, {0}!", name);
    }
}