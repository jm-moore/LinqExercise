using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of numbers: \n{numbers.Sum()}");
            Console.WriteLine();

            //TODO: Print the Sum of numbers DONE

            Console.WriteLine($"Average of numbers: \n{numbers.Average()}");
            Console.WriteLine();

            //TODO: Print the Average of numbers DONE

            Console.WriteLine("Numbers in ascending order:");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();


            //TODO: Order numbers in ascending order and print to the console DONE

            Console.WriteLine("Numbers in descending order:");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Order numbers in decsending order adn print to the console DONE

            Console.WriteLine("Numbers greater than 6:");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6 DONE

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Numbers in ascending order with only last 4 numbers displayed:");
            numbers.OrderBy(x => x).ToList().Where(x => x > 5).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order DONE

                
            Console.WriteLine("Numbers in descending order with age added at index 4:");
            numbers[4] = 24;
            foreach (var item in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }
           // numbers.OrderByDescending(x => x).ToList().Where(x => x == 5).Append(24).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName. DONE

            Console.WriteLine("Employees with names that start with C or S in ascending order by first name:");
            employees.OrderBy(x => x.FirstName).ToList().Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).ToList().ForEach(x => Console.WriteLine(x.FirstName));
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result. DONE

            Console.WriteLine("Employees over the age of 26 in order by first name:");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"{x.FirstName} {x.Age}"));
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35 DONE
            Console.WriteLine("Sum and Average of employees' YOE if they have more than 10 YOE, and they are older than 35:");
            var sum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);     
            var average = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine($"Sum of employees' YOE- {sum}\nAverage of employees' YOE- {average}");
            Console.WriteLine();



            //TODO: Add an employee to the end of the list without using employees.Add() DONE
            employees = employees.Append(new Employee() { FirstName = "Joshua", LastName = "Moore", Age = 24, YearsOfExperience = 1 }).ToList();
            Console.WriteLine("List of employees with new employee added:");
            employees.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} {x.YearsOfExperience}"));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
