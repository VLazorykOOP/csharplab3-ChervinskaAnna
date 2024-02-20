using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using static Lab3CSharp.Program;


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
            public ITriangle (int Base, int side, int color)
            {
                a = Base;
                b = side;
                c = color;
            }

            public void Print () {
                Console.WriteLine($"Base: {a}");
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

            public int Side {
                get { return b; } set { b = value; }
            }
            public int Base
            {
                get { return a; }
                set { a = value; }
            }

            public int Color
            {
                get { return c; }
            }
        }
            static void task1()
        {
            Console.WriteLine("Task 1");
            List < ITriangle >  triangles = new List<ITriangle>();
            triangles.Add(new ITriangle(3, 5, 6));
            triangles.Add(new ITriangle(4, 4, 10));
            triangles.Add(new ITriangle(2, 7, 9));
            triangles.Add(new ITriangle(8, 8, 1));
            triangles.Add(new ITriangle(1, 5, 4));
            foreach(var t in triangles) {
                Console.WriteLine();
                t.Print();
                Console.WriteLine($"P = {t.P()}");
                Console.WriteLine($"S = {t.S()}");
                Console.WriteLine($"Equilateral triangle? = {t.EquilateralTriangle()}");
            }
           
        }

        class Worker
        {
            protected string Name;
            protected string Surname;
            protected int Age;
            public Worker(string name, string surname, int age)
            {
                Name = name;
                Surname = surname;
                Age = age;
            }
            public virtual void Show()
            {
                Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}");
            }
        }
       
        class Engineer : Worker
        {
            public Engineer(string name, string surname, int age, string specialization, double salary) : base(name, surname, age) {
                Specialization = specialization;
                Salary = salary;
            }
            public string Specialization;
            public double Salary;

              public override void Show()
            {
                base.Show();
                Console.WriteLine($"Specialization: {Specialization}, Salary: {Salary}");
            }
        }
        class HumanResources : Worker 
        {
            public HumanResources(string name, string surname, int age, string role) : base(name, surname, age) {
                Role = role;
            }
            public string Role;
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Role: {Role}");
            }
        }
        class Administration : HumanResources
        { 
            public Administration(string name, string surname, int age, string role, string department) : base(name, surname, age, role) {
                Department = department;
            }
            public string Department;
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Department: {Department}");
            }
        }
        static void task2()
        {
            Console.WriteLine("Task 2");
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("John", "Doe", 35));
            workers.Add(new Engineer("Jane", "Smith", 28, "Software Engineering", 50000));
            workers.Add(new HumanResources("Mike", "Johnson", 40, "Recruiter"));
            workers.Add(new Administration("Emily", "Williams", 32, "Manager", "HR"));

            foreach (var worker in workers)
            {
                worker.Show();
                Console.WriteLine(); 
            }

        }
    }

}