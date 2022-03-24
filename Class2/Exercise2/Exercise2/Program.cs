using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third, fourth, average;
            Console.WriteLine("Please enter four numbers");
            bool isValidFirst = int.TryParse(Console.ReadLine(), out first);
            bool isValidSecond = int.TryParse(Console.ReadLine(), out second);
            bool isValidThird = int.TryParse(Console.ReadLine(), out third);
            bool isValidFourth = int.TryParse(Console.ReadLine(), out fourth);

            if (isValidFirst && isValidSecond && isValidThird && isValidFourth){
                average = (first + second + third + fourth) / 4;
                Console.WriteLine("The average is: " + average);
            }
            else
            {
                Console.WriteLine("Wrong input, please enter valid numbers");
            }
        }
    }
}
