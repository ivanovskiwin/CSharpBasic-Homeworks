using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, temp;
            Console.WriteLine("Please enter two numbers");
            bool isValidFirst = int.TryParse(Console.ReadLine(), out first);
            bool isValidSecond = int.TryParse(Console.ReadLine(), out second);
            if(isValidFirst && isValidSecond)
            {
                Console.WriteLine("Your input: " + first + " " + second);
                temp = first;
                first = second;
                second = temp;
                Console.WriteLine("Swapped variables: " + first + " " + second);
            }
            else
            {
                Console.WriteLine("Wrong input, please enter valid numbers");
            }

        }
    }
}
