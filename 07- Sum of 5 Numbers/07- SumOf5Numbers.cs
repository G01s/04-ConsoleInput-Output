using System;


class SumOfFiveNumbers
{

    //Problem 7. Sum of 5 Numbers

    //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.


    static void Main()
    {
        Console.WriteLine("Sum Of Five Numbers");
        Console.WriteLine("--------------------");
        Console.WriteLine("Enter five numbers in single line:");

        string[] input = Console.ReadLine().Split();
        double num = 0;
        double sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            num = double.Parse(input[i]);
            sum = sum + num;
        }
        Console.WriteLine("Sum of your numbers is = {0}", sum);
    }
}
