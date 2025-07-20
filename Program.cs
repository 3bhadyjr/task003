using System;
using System.Collections.Generic;

namespace Task002
{
    internal class Program
    {
        static void Print(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");
            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i]);
                    if (i < numbers.Count - 1)
                        Console.Write(", ");
                }
                Console.Write("]");
            }
        }

        static void Add(List<int> numbers)
        {
            Console.WriteLine("Enter a number to add: ");
            int number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);
            Console.WriteLine(number + "is added succesfully");
        }

        static void Mean(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("Can't calculate the mean - no data");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
                double mean = (double)sum / numbers.Count;
                Console.WriteLine("Mean: " + mean);
            }
        }

        static void Smallest(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                int smallest = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] < smallest)
                    {
                        smallest = numbers[i];
                    }
                }
                Console.WriteLine("The smallest number is: " + smallest);
            }
        }

        static void Largest(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                int largest = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] > largest)
                    {
                        largest = numbers[i];
                    }
                }
                Console.WriteLine("The largest number is: " + largest);
            }
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");
                string choice1 = Console.ReadLine();

                if (choice1 == "" || choice1 == null)
                {
                    Console.WriteLine("Unknown selection, please try again");
                    continue;
                }

                char choice = Char.ToUpper(choice1[0]);

                if (choice == 'P')
                    Print(numbers);
                else if (choice == 'A')
                    Add(numbers);
                else if (choice == 'M')
                    Mean(numbers);
                else if (choice == 'S')
                    Smallest(numbers);
                else if (choice == 'L')
                    Largest(numbers);
                else if (choice == 'Q')
                {
                    Console.WriteLine("Goodbye");
                    running = false;
                }
                else
                    Console.WriteLine("Unknown selection, please try again");
            }
        }
    }
}
