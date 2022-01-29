using System;
using System.Collections.Generic;
using TEams.Classes;

namespace TEams
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Caleb was here!");







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
            foreach (Employee employee in employees)
            {
                if (employee.FirstName.Equals("Angie"))
                {
                    employee.RaiseSalary(10);
                }

            }

            // print all employees
            PrintEmployees(employees);

            Dictionary<string, Project> projects = new Dictionary<string, Project>();

            // create the TEams project
            projects["TEams"] = CreateTeamsProject(employees);

            


            // create the Marketing Landing Page Project
            projects["Marking Landing Page"] = CreateLandingPageProject(employees);

            // print each project name and the total number of employees on the project
            PrintProjectsReport(projects);
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
        private Project CreateTeamsProject(List<Employee> employees)
        {

            Project newProject = new Project("TEams", "Project Management Software", "10/10/2020", "11/10/2020");

            foreach  (Employee employee in employees)
            {
                if (employee.Department.DepartmentId.Equals(3))
                {
                    newProject.TeamMembers.Add(employee);

                }


            }

            return newProject;


        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private Project CreateLandingPageProject(List<Employee> employees)
        {

            Project newProject = new Project("Marketing Landing Page", "Lead Capture Landing Page for Marketing", "10/10/2020", "10/17/2020");

            foreach (Employee employee in employees)
            {
                if (employee.Department.DepartmentId.Equals(1))
                {
                    newProject.TeamMembers.Add(employee);

                }


            }

            return newProject;
           

        }

        /**
         * Print out each project in the collection.
         */
        private void PrintProjectsReport(Dictionary<string, Project> projects)
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");

            foreach (KeyValuePair<string, Project> kvp in projects)
            {

                Console.WriteLine($"{kvp.Key}: {kvp.Value.TeamMembers.Count}");

                 
            }


        }
    }
}
