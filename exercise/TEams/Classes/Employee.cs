using System;
using System.Collections.Generic;
using System.Text;

namespace TEams.Classes
{
    class Employee
    {
        public Employee(long employeeId, string firstName, string lastName, string email, Department department, string hireDate)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Department = department;
            this.HireDate = hireDate;
            this.Salary = defaultSalary;
        }

        Employee()
        {
            this.Salary = defaultSalary;
        }



        private static double defaultSalary = 60000;

        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public string HireDate { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }






    }
}
