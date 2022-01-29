using System;
using System.Collections.Generic;
using System.Text;

namespace TEams.Classes
{
    class Project
    {

        public Project(string name, string description, string startDate, string dueDate)
        {
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.DueDate = dueDate;
            this.TeamMembers = new List<Employee>();
        }






        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
        public List<Employee> TeamMembers { get; set; }


    }
}
