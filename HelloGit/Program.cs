﻿namespace HelloGit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Git!");
        Console.WriteLine("My name is Danica");

        CountTo(5);
    }
    
    // This method counts to the number specified
    static void CountTo(int num)
    {
        Console.WriteLine($"Counting to {num}");
        for (int i = 1; i < num; i++)
        {
            Console.WriteLine(i + " ...");
        }
    }
}