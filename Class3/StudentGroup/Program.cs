using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            string[] studentG2 = { "John", "Petar", "Bruce", "Steve", "Kim" };

            Console.WriteLine("Enter group number(1 or 2): ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("The students in G1 are: ");
                foreach(string student in studentG1)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("The students in G2 are: ");
                foreach (string student in studentG2)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
