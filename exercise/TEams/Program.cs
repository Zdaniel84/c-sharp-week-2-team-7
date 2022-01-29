using System;
using System.Collections.Generic;
using TEams.Classes;

namespace TEams
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            // create some departments
            List<Department> departments = new List<Department>();
            departments = CreateDepartments();

            // print each department by name
            PrintDepartments(departments);


            // create employees
            List<Employee> employees = new List<Employee>();
            employees = CreateEmployees(departments);

            // give Angie a 10% raise, she is doing a great job!


            // print all employees
            PrintEmployees(employees);

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private List<Department> CreateDepartments()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department(1, "Marketing"));
            departments.Add(new Department(2, "Sales"));
            departments.Add(new Department(3, "Engineering"));

            return departments;
        }

        /**
         * Print out each department in the collection.
         */
        



        private void PrintDepartments(List<Department> departments)
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            foreach (Department department in departments)
            {
                Console.WriteLine($"{department.Name}");
            }
        }

        /**
         * Create employees and add them to the collection of employees
         */
        private List<Employee> CreateEmployees(List<Department> departments)
        {
            List<Employee> newEmployees = new List<Employee>();
            newEmployees.Add(new Employee(1, "Dean", "Johnson", "djohnson@teams.com", departments[2], "08/21/2020"));
            newEmployees.Add(new Employee(2, "Angie", "Smith", "asmith@teams.com", departments[2], "08/21/2020"));
            newEmployees.Add(new Employee(3, "Margaret", "Thompson", "mthompson@teams.com", departments[0], "08/21/2020"));
            return newEmployees;
        }

        /**
         * Print out each employee in the collection.
         */
        private void PrintEmployees(List<Employee> employees)
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.FullName} {employee.Salary} {employee.Department.Name}");
            }
        }

        /**
         * Create the 'TEams' project.
         */
        private void CreateTeamsProject()
        {

        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private void CreateLandingPageProject()
        {

        }

        /**
         * Print out each project in the collection.
         */
        private void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");

        }
    }
}
