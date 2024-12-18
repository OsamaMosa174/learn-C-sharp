using System;

class Program
{
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

        List<object>num = new List<object>();
        num.Add(10);
        num.Add(20);
        num.Add(30);
        num.Add("osama");
     
        foreach (object allnum in num)
        {
            Console.WriteLine(allnum);
       
        }
    }
}
