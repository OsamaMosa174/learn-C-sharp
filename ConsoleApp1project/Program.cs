using System;
using System.Collections.Generic;
using System.Threading.Tasks;


class Program
{
    static int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }
    static List<string> tasks = new List<string>();
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
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i); 
        }

        Console.WriteLine("Another way");

        Console.Write("Write a number");
        int g = Convert.ToInt32(Console.ReadLine());
        while (g <= 5)
        {
            Console.WriteLine(g); 
            g++;
        }
        List<double> yournumbers = new List<double>();
        Console.WriteLine("Enter numbers for the list. Type 'done' to finish:");

        while (true)
        {
            Console.Write("Enter a number (or 'done' to finish): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
                break;

            if (double.TryParse(input, out double number))
            {
                yournumbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        if (yournumbers.Count == 0)
        {
            Console.WriteLine("No numbers entered. Exiting program.");
            return;
        }

       
        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1. Addition (Sum)");
        Console.WriteLine("2. Multiplication (Product)");
        Console.WriteLine("3. Subtraction");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Maximum");
        Console.WriteLine("6. Minimum");

        int choice;
        while (true)
        {
            Console.Write("Enter your choice (1-6): ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 6)
                break;

            Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
        }

       
        switch (choice)
        {
            case 1: 
                double sum = 0;
                foreach (double number in yournumbers)
                {
                    sum += number;
                }
                Console.WriteLine($"\nThe sum of the numbers is: {sum}");
                break;

            case 2: 
                double product = 1;
                foreach (double number in yournumbers)
                {
                    product *= number;
                }
                Console.WriteLine($"\nThe product of the numbers is: {product}");
                break;

            case 3: 
                double difference = yournumbers[0];
                for (int i = 1; i < yournumbers.Count; i++)
                {
                    difference -= yournumbers[i];
                }
                Console.WriteLine($"\nThe result of the subtraction is: {difference}");
                break;

            case 4: 
                double quotient = yournumbers[0];
                for (int i = 1; i < yournumbers.Count; i++)
                {
                    if (yournumbers[i] == 0)
                    {
                        Console.WriteLine("Division by zero detected. Operation aborted.");
                        return;
                    }
                    quotient /= yournumbers[i];
                }
                Console.WriteLine($"\nThe result of the division is: {quotient}");
                break;

            case 5: 
                double max = yournumbers[0];
                foreach (double number in yournumbers)
                {
                    max = Math.Max(max, number);
                }
                Console.WriteLine($"\nThe maximum number is: {max}");
                break;

            case 6: 
                double min = yournumbers[0];
                foreach (double number in yournumbers)
                {
                    min = Math.Min(min, number);
                }
                Console.WriteLine($"\nThe minimum number is: {min}");
                break;

        }

        while (true)
        {
            Console.WriteLine("\nTodo List App");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Edit Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choices = Console.ReadLine();

            switch (choices)
            {
                case "1":
                    ViewTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    EditTask();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    Console.WriteLine("Exiting the app. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ViewTasks()
    {
        Console.WriteLine("\nYour Tasks:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available. Add some!");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void AddTask()
    {
        Console.Write("\nEnter the task: ");
        string newTask = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newTask))
        {
            tasks.Add(newTask);
            Console.WriteLine("Task added successfully!");
        }
        else
        {
            Console.WriteLine("Task cannot be empty. Try again.");
        }
    }

    static void EditTask()
    {
        ViewTasks();
        Console.Write("\nEnter the task number to edit: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            Console.Write("Enter the new task description: ");
            string updatedTask = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(updatedTask))
            {
                tasks[taskNumber - 1] = updatedTask;
                Console.WriteLine("Task updated successfully!");
            }
            else
            {
                Console.WriteLine("Task cannot be empty. Try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid task number. Try again.");
        }
    }

    static void DeleteTask()
    {
        ViewTasks();
        Console.Write("\nEnter the task number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Task deleted successfully!");
        }
        else
        {
            Console.WriteLine("Invalid task number. Try again.");
        }

        static void SearchTasks(List<string> tasks)
        {
            Console.Write("\nEnter a keyword to search: ");
            string keyword = Console.ReadLine();

            var filteredTasks = tasks
                .Where(task => task.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (filteredTasks.Count > 0)
            {
                Console.WriteLine("\nSearch Results:");
                foreach (var task in filteredTasks)
                {
                    Console.WriteLine($"- {task}");
                }
            }
            else
            {
                Console.WriteLine("\nNo tasks found with the given keyword.");
            }
        }


        class Task
    {
        public string Description { get; set; }
        public string Priority { get; set; } // e.g., High, Medium, Low
    }


    static void FilterTasksByPriority(List<Task> tasks)
        {
            Console.Write("\nEnter priority to filter (High, Medium, Low): ");
            string priority = Console.ReadLine();

            var filteredTasks = tasks
                .Where(task => task.Priority.Equals(priority, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (filteredTasks.Count > 0)
            {
                Console.WriteLine($"\nTasks with {priority} priority:");
                foreach (var task in filteredTasks)
                {
                    Console.WriteLine($"- {task.Description} [{task.Priority}]");
                }
            }
            else
            {
                Console.WriteLine($"\nNo tasks found with {priority} priority.");
            }
        }


    }
}

