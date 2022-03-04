using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company awesomeCompany = new Company("My Awesome Company", new DateTime(2022, 2, 28));

            // Create three employees
            Employee harry = new Employee
            {
                FirstName = "Harry",
                LastName = "Potter",
                Title = "CEO",
                StartDate = new DateTime(2022, 1, 1)
            };
            Employee bob = new Employee
            {
                FirstName = "Bob",
                LastName = "Dillon",
                Title = "CFO",
                StartDate = new DateTime(2020, 4, 30)
            };
            Employee patrick = new Employee
            {
                FirstName = "Patrick",
                LastName = "StarFish",
                Title = "COO",
                StartDate = new DateTime(2021, 5, 08)
            };


            // Assign the employees to the company
            awesomeCompany.Employees.Add(harry);
            awesomeCompany.Employees.Add(bob);
            awesomeCompany.Employees.Add(patrick);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            awesomeCompany.ListEmployees();
        }
    }
}