using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
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

        public class ITriangle
        {
            protected int a, b;
            protected int c;
            public ITriangle (int sideBase, int side, int color)
            {
                a = sideBase;
                b = side;
                c = color;
            }

            public void Print () {
                Console.WriteLine($"sideBase: {a}");
                Console.WriteLine($"side: {b}");
            }
            public float P () {
                 return a + b * 2;
            }

            public float S ()
            {
                double p = P() / 2.0;
                return (float)Math.Sqrt(p * (p - a) * (p - a) * (p - b));
            }

            public bool EquilateralTriangle()
            {
                return a == b;
            }

        }
            static void task1()
        {
            Console.WriteLine("Task 1");

            var triangle = new ITriangle(3, 5, 6);
            triangle.Print();
            Console.WriteLine(triangle.P());
            Console.WriteLine(triangle.S());
            Console.WriteLine(triangle.EquilateralTriangle());
        }
        class Administration { 
        
        }
        class Engineer
        {

        }
        class HumanResources
        {

        }
        class Worker
        {

        }
        static void task2()
        {
            Console.WriteLine("Task 2");

        }
    }

}