using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(fizzBuzz(2));

        Console.WriteLine(fizzBuzz(9));

        Console.WriteLine(fizzBuzz(25));

        Console.WriteLine(fizzBuzz(15));
    }

    //Write a method that accepts a number

    public static string fizzBuzz(int number)
    {
        //when the number is divisible by 3 return the word fizz
        if (number % 3 == 0 && number % 5 != 0)
        {
            return "fizz";
        }
        //when the number is divisible by 5 return the word buzz
        else if (number % 5 == 0 && number % 3 != 0)
        {
            return "buzz";
        }
        //when the number is divisible by both, return the word fizzbuzz
        else if (number % 3 == 0 && number % 5 == 0)
        {
            return "fizzbuzz";
        }
        else
        {
            return "no fizzbuzz for you.";
        }
    }
}