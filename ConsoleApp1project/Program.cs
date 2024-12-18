using System;
using System.Collections.Generic;

class Program
{
    static int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }

    static void Main(string[] args)
    {
        // Array Example
        int[] numbers = { 10, 20, 30 };
        Console.WriteLine("Array Elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // List Example
        List<int> num = new List<int> { 10, 20, 30 };
        Console.WriteLine("\nList Elements:");
        foreach (int number in num)
        {
            Console.WriteLine(number);
        }

        // Read and validate first number
        Console.Write("\nEnter first number: ");
        int firstNumber;
        while (!int.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter first number: ");
        }

        // Read and validate second number
        Console.Write("Enter second number: ");
        int secondNumber;
        while (!int.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter second number: ");
        }

        // Calculate and display result
        int result = AddNumbers(firstNumber, secondNumber);
        Console.WriteLine($"\nThe sum of {firstNumber} and {secondNumber} is {result}.");

        // Read and validate age
        Console.Write("Enter age: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for age.");
            Console.Write("Enter age: ");
        }

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else if (age >= 13)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are a child.");
        }

        Console.Write("\nEnter day number (1 for Saturday, 7 for Friday): ");
        int day;
        while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            Console.Write("Enter day number: ");
        }

        
        switch (day)
        {
            case 1:
                Console.WriteLine("Saturday");
                break;
            case 2:
                Console.WriteLine("Sunday");
                break;

            case 3:
                Console.WriteLine("Monday");
                break;
            case 4:
                Console.WriteLine("Tuesday");
                break;
            case 5:
                Console.WriteLine("Wednesday");
                break;
            case 6:
                Console.WriteLine("Thursday");
                break;
            case 7:
                Console.WriteLine("Friday");
                break;
           
        }
    }
}

