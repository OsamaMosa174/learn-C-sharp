using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Task
    {
        public string Description { get; set; }
        public string Priority { get; set; } // High, Medium, Low
        public bool IsCompleted { get; set; } = false; // Default: not completed
    }

    static void Main(string[] args)
    {
        List<Task> tasks = new List<Task>();
        bool showCompletedTasks = true;

        while (true)
        {
            Console.WriteLine("\nTask Manager:");
            Console.WriteLine("1. Add a Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Edit a Task");
            Console.WriteLine("4. Delete a Task");
            Console.WriteLine("5. Mark Task as Completed");
            Console.WriteLine("6. Toggle Viewing Completed Tasks");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask(tasks);
                    break;
                case "2":
                    ViewTasks(tasks, showCompletedTasks);
                    break;
                case "3":
                    EditTask(tasks);
                    break;
                case "4":
                    DeleteTask(tasks);
                    break;
                case "5":
                    MarkTaskAsCompleted(tasks);
                    break;
                case "6":
                    showCompletedTasks = !showCompletedTasks;
                    Console.WriteLine($"Show completed tasks: {showCompletedTasks}");
                    break;
                case "7":
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

    static void ViewTasks(List<Task> tasks, bool showCompletedTasks)
    {
        Console.WriteLine("\nYour Tasks:");
        var tasksToView = showCompletedTasks ? tasks : tasks.Where(t => !t.IsCompleted).ToList();

        if (tasksToView.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            for (int i = 0; i < tasksToView.Count; i++)
            {
                var task = tasksToView[i];
                string status = task.IsCompleted ? " (Completed)" : "";
                Console.WriteLine($"{i + 1}. {task.Description} [{task.Priority}]{status}");
            }
        }
    }

    static void EditTask(List<Task> tasks)
    {
        ViewTasks(tasks, true);
        Console.Write("\nEnter the task number to edit: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            Task task = tasks[taskNumber - 1];

            Console.Write($"Enter the new description (leave blank to keep '{task.Description}'): ");
            string newDescription = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newDescription))
            {
                task.Description = newDescription;
            }

            Console.Write("Enter the new priority (High, Medium, Low, leave blank to keep current): ");
            string newPriority = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newPriority) &&
                (newPriority.Equals("High", StringComparison.OrdinalIgnoreCase) ||
                 newPriority.Equals("Medium", StringComparison.OrdinalIgnoreCase) ||
                 newPriority.Equals("Low", StringComparison.OrdinalIgnoreCase)))
            {
                task.Priority = newPriority;
            }

            Console.WriteLine("Task updated successfully!");
        }
        else
        {
            Console.WriteLine("Invalid task number. Try again.");
        }
    }

    static void DeleteTask(List<Task> tasks)
    {
        ViewTasks(tasks, true);
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
    }

    static void MarkTaskAsCompleted(List<Task> tasks)
    {
        ViewTasks(tasks, false);
        Console.Write("\nEnter the task number to mark as completed: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1].IsCompleted = true;
            Console.WriteLine("Task marked as completed!");
        }
        else
        {
            Console.WriteLine("Invalid task number. Try again.");
        }
    }
}

