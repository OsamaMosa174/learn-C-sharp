using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Define the Task class
    public class Task
    {
        public string Description { get; set; }
        public string Priority { get; set; } // e.g., High, Medium, Low
    }

    static void Main(string[] args)
    {
        // Initialize an empty list of tasks
        List<Task> tasks = new List<Task>();

        while (true)
        {
            Console.WriteLine("\nTask Manager:");
            Console.WriteLine("1. Add a Task");
            Console.WriteLine("2. View All Tasks");
            Console.WriteLine("3. Filter Tasks by Priority");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask(tasks);
                    break;
                case "2":
                    ViewTasks(tasks);
                    break;
                case "3":
                    FilterTasksByPriority(tasks);
                    break;
                case "4":
                    Console.WriteLine("Exiting the application. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddTask(List<Task> tasks)
    {
        Console.Write("\nEnter the task description: ");
        string description = Console.ReadLine();

        string priority;
        while (true)
        {
            Console.Write("Enter the task priority (High, Medium, Low): ");
            priority = Console.ReadLine();
            if (priority.Equals("High", StringComparison.OrdinalIgnoreCase) ||
                priority.Equals("Medium", StringComparison.OrdinalIgnoreCase) ||
                priority.Equals("Low", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid priority. Please enter 'High', 'Medium', or 'Low'.");
            }
        }

        tasks.Add(new Task { Description = description, Priority = priority });
        Console.WriteLine("Task added successfully!");
    }

    static void ViewTasks(List<Task> tasks)
    {
        Console.WriteLine("\nAll Tasks:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Description} [{tasks[i].Priority}]");
            }
        }
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

