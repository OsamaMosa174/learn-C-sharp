using System;
class app
{
    static void Main(string[]args) {
        Console.Write("Entre your name: ");
        string name = Console.ReadLine();
        Console.Write("Entre your age: ");
        int age =Convert.ToInt32( Console.ReadLine());
        Console.Write("Enter your height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Are you a student? (yes/no or true/false): ");
        string input = Console.ReadLine().ToLower();
        bool isStudent = (input == "yes" || input == "true");

        Console.WriteLine($"Hello {name}!");
        Console.WriteLine($"Your age is {age} years old.");
        Console.WriteLine($"Your height is {height} cm.");
        Console.WriteLine($"Are you student= {isStudent}");
    }
}
