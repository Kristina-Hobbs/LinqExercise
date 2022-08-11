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
            int sum = (from x in numbers select x).Sum();
            Console.WriteLine(sum);
            //TODO: Print the Sum of numbers


            Console.WriteLine("----");


            double average = numbers.Average();
            Console.WriteLine(average);
            //TODO: Print the Average of numbers


            Console.WriteLine("----");


            var ascending = numbers.OrderBy(item => item);
            foreach (var number in ascending)
            {
                Console.WriteLine(number);
            }
            //TODO: Order numbers in ascending order and print to the console


            Console.WriteLine("----");


            var descending = numbers.OrderByDescending(num => num);
            foreach (var number in descending)
            {
                Console.WriteLine(number);
            }
            //TODO: Order numbers in decsending order adn print to the console


            Console.WriteLine("----");


            var greaterThanSix = numbers.Where(num => num > 6);
            foreach (var number in greaterThanSix)
            {
                Console.WriteLine(number);
            }
            //TODO: Print to the console only the numbers greater than 6


            Console.WriteLine("----");


            foreach (var num in ascending.Take(4))
            {
                Console.WriteLine(num);
            }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**


            Console.WriteLine("----");


            numbers.SetValue(36, 4);
            var withMyAge = numbers.OrderByDescending(num => num);

            foreach (var number in withMyAge)
            {
                Console.WriteLine(number);
            }
            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order






            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */


            //list of employees ***Do not remove this***
            var employees = CreateEmployees();

            var filtered = employees.Where(person => person.FirstName.ToLower().StartsWith('c') || person.FirstName.ToLower()[0] == 's')
            .OrderBy(person => person.FirstName);

            var otherFiltered = employees.FindAll(name => name.FirstName.ToLower()[0] == 'c' || name.FirstName.ToLower()[0] == 's')
            .OrderBy(name => name.FirstName);

            foreach (var person in filtered)
            {
                Console.WriteLine(person.FullName);
            }
            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.


            Console.WriteLine("----");


            var twentySixers = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);

            foreach (var item in twentySixers)
            {
                Console.WriteLine($"Name: {item.FullName}, Age: {item.Age}");
            }
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.


            Console.WriteLine("----");



            var employeeYEO = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            Console.WriteLine($"Total YOE:{employeeYEO.Sum(x => x.YearsOfExperience)}");
            Console.WriteLine($"Avg YOE:{employeeYEO.Average(x => x.YearsOfExperience)}");
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35


            Console.WriteLine("----");


            employees = employees.Append(new Employee("First", "Last", 30, 10)).ToList();

           foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }
            Console.ReadLine();
            //TODO: Add an employee to the end of the list without using employees.Add()


           
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
    }
        #endregion
    }

