using System;

class Program
{
    static int addnumbers(int number1, int number2)
    {
        return number1 + number2;
    }
    static void Main(string[] args)
    {
        int[] number = new int[3];
        number[0] = 10;
        number[1] = 20;
        number[2] = 30;
        foreach (int numbers in number)
        {
            Console.WriteLine(numbers);
        }

        List<object> num = new List<object>();
        num.Add(10);
        num.Add(20);
        num.Add(30);
        num.Add("osama");

        foreach (object allnum in num)
        {
            Console.WriteLine(allnum);

        }


        Console.Write("Enter frist number: ");
        int fristnumber= Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter frist second: ");
        int secondnumber = Convert.ToInt32(Console.ReadLine());

        int result=addnumbers(fristnumber, secondnumber);
        Console.WriteLine($"\nThe sum of {fristnumber} and {secondnumber} is {result}.");

    }
}
