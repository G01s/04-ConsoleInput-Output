﻿using System;

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
 //(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

class FibonacciNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int max = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        for (int i = 1; i <= max; i++)
        {
            Console.Write("{0} ", a);
            int sum = a;
            a = b;
            b = sum + b;
        }
        Console.WriteLine();
    }
}