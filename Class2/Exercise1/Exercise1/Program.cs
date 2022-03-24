using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber, secondNumber;
            string operation;

            if (!float.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Wrong Input. Please enter a number");
                return;
            };
            if (!float.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Wrong Input. Please enter a number");
                return;
            };
            Console.WriteLine("Please enter an operation(+, -, /, *)");
            operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine("The result is: " + (firstNumber + secondNumber));
                    break;
                case "-":
                    Console.WriteLine("The result is: " + (firstNumber - secondNumber));
                    break;
                case "*":
                    Console.WriteLine("The result is: " + (firstNumber * secondNumber));
                    break;
                case "/":
                    Console.WriteLine("The result is: " + (firstNumber / secondNumber));
                    break;
                default:
                    Console.WriteLine("Wrong operator");
                    break;
            }
        }
    }
}
