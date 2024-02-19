using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What task do you want?");
            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2");
            Console.WriteLine("3. Exit");

            int choice;
            bool isValidChoice = false;

            do
            {
                Console.Write("Enter number of task ");
                isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice || choice < 1 || choice > 3)
                {
                    Console.WriteLine("This task not exist");
                    isValidChoice = false;
                }
            } while (!isValidChoice);
            switch (choice)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    break;
            }
        }


        static void task1()
        {
            Console.WriteLine("Task 1");

        }
        static void task2()
        {
            Console.WriteLine("Task 2");

        }
    }

}