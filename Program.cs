using System;

namespace DevYou_ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"The value of i is: {i}");
            }

            //Exercise Two
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"The value of i is: {i}");
            }

            //Exercise Three
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Today is a good day!");
            }

            //Challenge Exercise
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {sum / 5}");
        }
    }
}
