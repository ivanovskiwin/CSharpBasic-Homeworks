using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            int sumOfArray=0;
            for(int i=0; i<6; i++)
            {
                Console.WriteLine($"Enter integer n.{i+1}");
                numbers[i] = int.Parse(Console.ReadLine());
            };
            foreach(int number in numbers) {
                if (number % 2 == 0) {
                    sumOfArray += number;
                }
            };
            Console.WriteLine($"The result is: {sumOfArray}");
        }
    }
}
